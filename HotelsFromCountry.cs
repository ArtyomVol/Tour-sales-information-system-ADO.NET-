using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HotelsFromCountry : Form
    {
        public HotelsFromCountry()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxCheckValue.ComboBox_Leave(countryToolStripComboBox);
                getHotelsFromCountryTableAdapter.Fill(travelAgencyDataSet.GetHotelsFromCountry, countryToolStripComboBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void HotelsFromCountry_Load(object sender, EventArgs e)
        {
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);

        }

        private void countryToolStripComboBox_Leave(object sender, EventArgs e)
        {
            ComboBoxCheckValue.ComboBox_Leave(sender);
        }
    }
}
