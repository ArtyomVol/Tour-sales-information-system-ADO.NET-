using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SalesWithNotStartedTours : Form
    {
        public SalesWithNotStartedTours()
        {
            InitializeComponent();
        }

        private void SalesWithNotStartedTours_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.travelAgencyDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.TravelAgents". При необходимости она может быть перемещена или удалена.
            this.travelAgentsTableAdapter.Fill(this.travelAgencyDataSet.TravelAgents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Tours". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter.Fill(this.travelAgencyDataSet.Tours);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.GetSalesWithNotStartedTours". При необходимости она может быть перемещена или удалена.
            this.getSalesWithNotStartedToursTableAdapter.Fill(this.travelAgencyDataSet.GetSalesWithNotStartedTours);

        }
    }
}
