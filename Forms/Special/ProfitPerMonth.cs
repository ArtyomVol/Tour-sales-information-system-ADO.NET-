using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.TravelAgencyDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class ProfitPerMonth : Form
    {
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

        public ProfitPerMonth()
        {
            InitializeComponent();
        }

        private void ProfitPerMonth_Load(object sender, EventArgs e)
        {
            yearTextBox.Text = DateTime.Now.Year.ToString();
            monthComboBox.DataSource = monthes.ToList();
            monthComboBox.DisplayMember = "Value";
            monthComboBox.ValueMember = "Key";
            monthComboBox.SelectedValue = DateTime.Now.Month;
            buttonGetProfit_Click(sender, e);
        }

        private void buttonGetProfit_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();
            int? profit = queriesTableAdapter.GetProfitPerMonth(
                Convert.ToInt32(yearTextBox.Text), Convert.ToInt32(monthComboBox.SelectedValue));
            if (profit == null)
            {
                profit = 0;
            }
            label1.Text = $"Доход за {monthComboBox.SelectedValue}.{yearTextBox.Text} составляет: {profit}";
        }

        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void yearTextBox_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(yearTextBox.Text) > DateTime.Now.Year)
            {
                yearTextBox.Text = DateTime.Now.Year.ToString();
            }
        }

        private void monthComboBox_Leave(object sender, EventArgs e)
        {
            if (monthes.FirstOrDefault(x => x.Value.ToLower() == monthComboBox.Text.ToLower()).Equals(
                new KeyValuePair<int, string>(0, null)))
            {
                monthComboBox.SelectedIndex = 0;
            }
        }
    }
}
