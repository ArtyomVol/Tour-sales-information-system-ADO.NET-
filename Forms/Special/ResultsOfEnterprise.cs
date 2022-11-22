using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.TravelAgencyDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class ResultsOfEnterprise : Form
    {
        TravelAgencyDataSet travelAgencyDataSet;
        string firstCheckString = "Доход предприятия";
        string secondCheckString = "Количество продаж предприятия";
        string thirdCheckString = "Доход от каждого турагента";
        string fourthCheckString = "Количество продаж каждого турагента";

        public ResultsOfEnterprise()
        {
            InitializeComponent();
        }

        private void ResultsOfEnterprise_Load(object sender, EventArgs e)
        {
            travelAgencyDataSet = new TravelAgencyDataSet();
            TravelAgentsTableAdapter travelAgentsTableAdapter = new TravelAgentsTableAdapter();
            travelAgentsTableAdapter.Fill(travelAgencyDataSet.TravelAgents);
            fromDateTimePicker.MaxDate = DateTime.Now;
            toDateTimePicker.MaxDate = DateTime.Now;
            UpdateDateTimePickers();
            checkedListBox1.Items.Add(firstCheckString);
            checkedListBox1.Items.Add(secondCheckString);
            checkedListBox1.Items.Add(thirdCheckString);
            checkedListBox1.Items.Add(fourthCheckString);
            reportViewer1.RefreshReport();
        }

        private void UpdateDateTimePickers()
        {
            fromDateTimePicker.MaxDate = toDateTimePicker.Value;
            toDateTimePicker.MinDate = fromDateTimePicker.Value;
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateDateTimePickers();
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateDateTimePickers();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Вы должны выбрать хотябы один из пунктов.");
                return;
            }
            string fromDate = fromDateTimePicker.Text;
            string toDate = toDateTimePicker.Text;
            string enterpriseProfit = "";
            string enterpriseSalesCount = "";
            string travelAgentsProfit = "";
            string travelAgentsSalesCount = "";
            if (checkedListBox1.CheckedItems.Contains(firstCheckString))
            {
                enterpriseProfit = GetEnterpriseProfit(queriesTableAdapter);
            }
            if (checkedListBox1.CheckedItems.Contains(secondCheckString))
            {
                enterpriseSalesCount = GetEnterpriseSalesCount(queriesTableAdapter);
            }
            if (checkedListBox1.CheckedItems.Contains(thirdCheckString))
            {
                travelAgentsProfit = GetTravelAgentsProfit(queriesTableAdapter);
            }
            if (checkedListBox1.CheckedItems.Contains(fourthCheckString))
            {
                travelAgentsSalesCount = GetTravelAgentsSalesCount(queriesTableAdapter);
            }

            ReportParameter fromDateParam = new ReportParameter("fromDate", fromDate);
            ReportParameter toDateParam = new ReportParameter("toDate", toDate);
            ReportParameter enterpriseProfitParam =
                new ReportParameter("enterpriseProfit", enterpriseProfit);
            ReportParameter enterpriseSalesCountParam =
                new ReportParameter("enterpriseSalesCount", enterpriseSalesCount);
            ReportParameter travelAgentsProfitParam =
                new ReportParameter("travelAgentsProfit", travelAgentsProfit);
            ReportParameter travelAgentsSalesCountParam =
                new ReportParameter("travelAgentsSalesCount", travelAgentsSalesCount);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                    fromDateParam, toDateParam, enterpriseProfitParam, enterpriseSalesCountParam,
                travelAgentsProfitParam, travelAgentsSalesCountParam});
            reportViewer1.RefreshReport();
        }

        private string GetEnterpriseProfit(QueriesTableAdapter queriesTableAdapter)
        {
            int? profit = queriesTableAdapter.GetProfitBetweenDates(fromDateTimePicker.Value, toDateTimePicker.Value);
            if (profit == null)
            {
                profit = 0;
            }
            return $"Доход турагентства \"Взлёты без падений\" составляет: {profit}\n\n";
        }

        private string GetEnterpriseSalesCount(QueriesTableAdapter queriesTableAdapter)
        {
            int? salesCount = queriesTableAdapter.GetSalesCountBetweenDates(fromDateTimePicker.Value, toDateTimePicker.Value);
            if (salesCount == null)
            {
                salesCount = 0;
            }
            return $"Количество продаж турагентства \"Взлёты без падений\" равно: {salesCount}\n\n";
        }

        private string GetTravelAgentsProfit(QueriesTableAdapter queriesTableAdapter)
        {
            StringBuilder travelAgentsProfit = new StringBuilder();
            if (travelAgencyDataSet.TravelAgents.Rows.Count > 0)
            {
                travelAgentsProfit.Append("Доход от каждого из сотрудника составляет:\n");
                Dictionary<string, int?> travelAgentsProfitDict = new Dictionary<string, int?>();
                foreach (DataRow row in travelAgencyDataSet.TravelAgents.Rows)
                {
                    int? profit = queriesTableAdapter.GetProfitPerTravelAgentBetweenDates(
                        Convert.ToInt32(row["TravelAgentId"]), fromDateTimePicker.Value, toDateTimePicker.Value);
                    if (profit == null)
                    {
                        profit = 0;
                    }
                    travelAgentsProfitDict.Add(TravelAgentString(row), profit);
                }
                foreach (var item in travelAgentsProfitDict.OrderBy(x => x.Key))
                {
                    travelAgentsProfit.Append("   • ").Append(item.Key).Append(": ").Append(item.Value).
                        Append("\n");
                }
                travelAgentsProfit.Append("\n");
            }
            return travelAgentsProfit.ToString();
        }

        private string GetTravelAgentsSalesCount(QueriesTableAdapter queriesTableAdapter)
        {
            StringBuilder travelAgentsSalesCount = new StringBuilder();
            if (travelAgencyDataSet.TravelAgents.Rows.Count > 0)
            {
                travelAgentsSalesCount.Append("Количество продаж каждого сотрудника составляет:\n");
                Dictionary<string, int?> travelAgentsSalesCountDict = new Dictionary<string, int?>();
                foreach (DataRow row in travelAgencyDataSet.TravelAgents.Rows)
                {
                    int? salesCount = queriesTableAdapter.GetSalesCountPerTravelAgentBetweenDates(
                        Convert.ToInt32(row["TravelAgentId"]), fromDateTimePicker.Value, toDateTimePicker.Value);
                    if (salesCount == null)
                    {
                        salesCount = 0;
                    }
                    travelAgentsSalesCountDict.Add(TravelAgentString(row), salesCount);
                }
                foreach (var item in travelAgentsSalesCountDict.OrderBy(x => x.Key))
                {
                    travelAgentsSalesCount.Append("   • ").Append(item.Key).Append(": ").Append(item.Value).
                        Append("\n");
                }
                travelAgentsSalesCount.Append("\n");
            }
            return travelAgentsSalesCount.ToString();
        }

        private string TravelAgentString(DataRow row)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(row["LastName"]).Append(" ").Append(row["FirstName"]).
                Append(row["Patronymic"] != null ? " " : "").Append(row["Patronymic"]).
                Append(" (номер паспорта: ").Append(row["PassportID"]).Append(")");
            return sb.ToString();
        }
    }
}
