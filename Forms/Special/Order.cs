using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.travelAgencyDataSet.Sales);
            this.travelAgentsTableAdapter.Fill(this.travelAgencyDataSet.TravelAgents);
            this.toursTableAdapter.Fill(this.travelAgencyDataSet.Tours);
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);
            this.clientsTableAdapter.Fill(this.travelAgencyDataSet.Clients);
            Sales main = this.Owner as Sales;
            if (main != null)
            {
                string saleDate = main.saleDateDateTimePicker.Text;

                int tourId = Convert.ToInt32(main.TourComboBox.SelectedValue);
                DataRow tourRow = travelAgencyDataSet.Tours.Select($"TourId = {tourId}").First();
                string tourName = tourRow["Name"].ToString();
                string tourBeginDate = GetDate((DateTime)tourRow["BeginDate"]);
                string tourEndDate = GetDate((DateTime)tourRow["EndDate"]);
                string tourPrice = tourRow["Price"].ToString();

                int hotelId = Convert.ToInt32(tourRow["HotelId"].ToString());
                DataRow hotelRow = travelAgencyDataSet.Hotels.Select($"HotelId = {hotelId}").FirstOrDefault();
                string hotelName = hotelRow["Name"].ToString();
                string hotelCountry = hotelRow["Country"].ToString();
                string hotelStars = hotelRow["StarsRate"].ToString();

                int clientId = Convert.ToInt32(main.ClientComboBox.SelectedValue);
                DataRow clientRow = travelAgencyDataSet.Clients.Select($"ClientId = {clientId}").FirstOrDefault();
                string clientFIO = $"{clientRow["LastName"]} {clientRow["FirstName"]} {clientRow["patronymic"]}";
                string clientPassportID = clientRow["PassportID"].ToString();
                string clientBirthDate = GetDate((DateTime)clientRow["BirthDate"]);

                int travelAgentId = Convert.ToInt32(main.TravelAgentComboBox.SelectedValue);
                DataRow travelAgentRow = travelAgencyDataSet.TravelAgents.Select($"TravelAgentId = {travelAgentId}").FirstOrDefault();
                string travelAgentFIO = $"{travelAgentRow["LastName"]} {travelAgentRow["FirstName"]} {travelAgentRow["patronymic"]}";

                string currentDate = GetDate(DateTime.Now);

                ReportParameter tourNameParam = new ReportParameter("tourName", tourName);
                ReportParameter tourBeginDateParam = new ReportParameter("tourBeginDate", tourBeginDate);
                ReportParameter tourEndDateParam = new ReportParameter("tourEndDate", tourEndDate);
                ReportParameter tourPriceParam = new ReportParameter("tourPrice", tourPrice);

                ReportParameter hotelNameParam = new ReportParameter("hotelName", hotelName);
                ReportParameter hotelCountryParam = new ReportParameter("hotelCountry", hotelCountry);
                ReportParameter hotelStarsParam = new ReportParameter("hotelStars", hotelStars);

                ReportParameter clientFIOParam = new ReportParameter("clientFIO", clientFIO);
                ReportParameter clientPassportIDParam = new ReportParameter("clientPassportID", clientPassportID);
                ReportParameter clientBirthDateParam = new ReportParameter("clientBirthDate", clientBirthDate);

                ReportParameter travelAgentFIOParam = new ReportParameter("travelAgentFIO", travelAgentFIO);

                ReportParameter saleDateParam = new ReportParameter("saleDate", saleDate);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                    tourNameParam, tourBeginDateParam, tourEndDateParam, tourPriceParam,
                hotelNameParam, hotelCountryParam, hotelStarsParam,
                clientFIOParam, clientPassportIDParam, clientBirthDateParam,
                travelAgentFIOParam, saleDateParam});
                this.reportViewer1.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private string GetDate(DateTime dateTime)
        {
            string day = dateTime.Day < 10 ? $"0{dateTime.Day}" : dateTime.Day.ToString();
            string month = dateTime.Month < 10 ? $"0{dateTime.Month}" : dateTime.Month.ToString();
            return $"{day}.{month}.{dateTime.Year}";
        }
    }
}
