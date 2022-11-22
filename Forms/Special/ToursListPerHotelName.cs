using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.TravelAgencyDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class ToursListPerHotelName : Form
    {
        const string CONNECTION_STRING = "Server=DESKTOP-SECVAD\\SQLEXPRESS;Database=TravelAgency;Integrated Security=True";
        SqlDataAdapter adapter;
        DataSet dataSet = new DataSet();
        string baseTableName = "SalesPerYearPerMonth";

        public ToursListPerHotelName()
        {
            InitializeComponent();
        }

        private void hotelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelAgencyDataSet);

        }

        private void hotelsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelAgencyDataSet);

        }

        private void ToursListPerHotelName_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);
            adapter = new SqlDataAdapter("", CONNECTION_STRING);
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            if (dataSet.Tables.Contains(baseTableName))
            {
                dataSet.Tables[baseTableName].Clear();
            }
            QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();
            queriesTableAdapter.create_tours_list_per_hotel_name(nameComboBox.Text);
            adapter.SelectCommand.CommandText =
                $"SELECT T.Name as НазваниеТура, H.Name as НазваниеОтеля, T.BeginDate as ДатаНачала, T.EndDate as ДатаОкончания, " +
                $"T.Price as Цена " +
                $"FROM tours_list_per_hotel_name as T " +
                $"JOIN Hotels as H on H.HotelId = T.HotelId";
            adapter.Fill(dataSet, baseTableName);
            dataGridView1.DataSource = dataSet.Tables[baseTableName];
            dataGridView1.Columns[0].HeaderText = "Название тура";
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].HeaderText = "Название отеля";
            dataGridView1.Columns[1].Width = 115;
            dataGridView1.Columns[2].HeaderText = "Дата начала";
            dataGridView1.Columns[3].HeaderText = "Дата окончания";
            dataGridView1.Columns[3].Width = 115;
        }

        private void nameComboBox_Leave(object sender, EventArgs e)
        {
            ComboBoxCheckValue.ComboBox_Leave(sender);
        }
    }
}
