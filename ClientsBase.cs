using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClientsBase : Form
    {
        public ClientsBase()
        {
            InitializeComponent();
        }

        private void ClientsBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TravelAgencyDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.ClientsTableAdapter.Fill(this.TravelAgencyDataSet.Clients);
            this.reportViewer1.RefreshReport();
        }
    }
}
