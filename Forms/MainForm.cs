using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private Sales sales;
        private Clients clients;
        private TravelAgents travelAgents;
        private Tours tours;
        private Hotels hotels;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            try
            {
                if (sales == null || sales.IsDisposed)
                {
                    sales = new Sales();
                }
                sales.ShowDialog();
            }
            catch {  }
        }

        private void buttonTours_Click(object sender, EventArgs e)
        {
            try
            {
                if (tours == null || tours.IsDisposed)
                {
                    tours = new Tours();
                }
                tours.ShowDialog();
            }
            catch { }
        }

        private void buttonHotels_Click(object sender, EventArgs e)
        {
            try
            {
                if (hotels == null || hotels.IsDisposed)
                {
                    hotels = new Hotels();
                }
                hotels.ShowDialog();
            }
            catch { }
        }

        private void buttonTravelAgents_Click(object sender, EventArgs e)
        {
            try
            {
                if (travelAgents == null || travelAgents.IsDisposed)
                {
                    travelAgents = new TravelAgents();
                }
                travelAgents.ShowDialog();
            }
            catch { }
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            try
            {
                if (clients == null || clients.IsDisposed)
                {
                    clients = new Clients();
                }
                clients.ShowDialog();
            }
            catch { }
        }
    }
}