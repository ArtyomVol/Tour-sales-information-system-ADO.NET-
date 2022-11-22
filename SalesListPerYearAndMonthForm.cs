using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.TravelAgencyDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class SalesListPerYearAndMonthForm : Form
    {
        const string CONNECTION_STRING = "Server=DESKTOP-SECVAD\\SQLEXPRESS;Database=TravelAgency;Integrated Security=True";
        SqlDataAdapter adapter;
        DataSet dataSet = new DataSet();
        string baseTableName = "SalesPerYearPerMonth";

        Dictionary<int, string> monthes = new Dictionary<int, string>()
        {
            { 1, "Январь" },
            { 2, "Февраль" },
            { 3, "Март" },
            { 4, "Апрель" },
            { 5, "Май" },
            { 6, "Июнь" },
            { 7, "Июль" },
            { 8, "Август" },
            { 9, "Сентябрь" },
            { 10, "Октябрь" },
            { 11, "Ноябрь" },
            { 12, "Декабрь" }
        };

        public SalesListPerYearAndMonthForm()
        {
            InitializeComponent();
        }

        private void SalesListPerYearAndMonthForm_Load(object sender, EventArgs e)
        {
            yearTextBox.Text = DateTime.Now.Year.ToString();
            monthComboBox.DataSource = monthes.ToList();
            monthComboBox.DisplayMember = "Value";
            monthComboBox.ValueMember = "Key";
            adapter = new SqlDataAdapter("", CONNECTION_STRING);
        }

        private void monthComboBox_Leave(object sender, EventArgs e)
        {
            if (monthes.FirstOrDefault(x => x.Value.ToLower() == monthComboBox.Text.ToLower()).Equals(
                new KeyValuePair<int, string>(0, null)))
            {
                monthComboBox.SelectedIndex = 0;
            }
        }

        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = DataChecker.CheckStringForLengthAndCharIsNumberInKeyPressEvent(
                yearTextBox.Text, 4, e.KeyChar);
        }

        private void yearTextBox_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(yearTextBox.Text) > DateTime.Now.Year)
            {
                yearTextBox.Text = DateTime.Now.Year.ToString();
            }
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            string tableName = $"sales_list_{yearTextBox.Text}_{monthComboBox.SelectedValue}";
            if (dataSet.Tables.Contains(baseTableName))
            {
                dataSet.Tables[baseTableName].Clear();
            }
            ExecuteProcedure(tableName);
            dataGridView1.DataSource = dataSet.Tables[baseTableName];
            DropTable(tableName);
            dataGridView1.Columns[0].HeaderText = "Дата продажи";
            dataGridView1.Columns[1].HeaderText = "Название тура";
            dataGridView1.Columns[2].HeaderText = "Номер паспорта турагента";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Номер паспорта клиента";
            dataGridView1.Columns[3].Width = 140;
        }

        private void ExecuteProcedure(string tableName)
        {
            QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();
            queriesTableAdapter.create_sales_list_per_year_and_month(
                Convert.ToInt32(yearTextBox.Text), Convert.ToInt32(monthComboBox.SelectedValue));
            adapter.SelectCommand.CommandText =
                $"SELECT SaleDate as ДатаПродажи, T.Name as Тур, TA.PassportID as НомерПаспортаТурагента," +
                $"C.PassportID as НомерПаспортаКлиента " +
                $"FROM {tableName} as Tab " +
                $"JOIN Tours as T on T.TourId = Tab.TourId " +
                $"JOIN TravelAgents as TA on TA.TravelAgentId = Tab.TravelAgentId " +
                $"JOIN Clients as C on C.ClientId = Tab.ClientId";
            adapter.Fill(dataSet, baseTableName);
        }

        private void DropTable(string tableName)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand($"DROP TABLE {tableName}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
