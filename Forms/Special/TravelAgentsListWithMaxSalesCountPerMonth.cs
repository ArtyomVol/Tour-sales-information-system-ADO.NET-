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
    public partial class TravelAgentsListWithMaxSalesCountPerMonth : Form
    {
        const string CONNECTION_STRING = "Server=DESKTOP-SECVAD\\SQLEXPRESS;Database=TravelAgency;Integrated Security=True";
        SqlDataAdapter adapter;
        DataSet dataSet = new DataSet();
        string baseTableName = "TravelAgentsWithMaxSalesCount";

        public TravelAgentsListWithMaxSalesCountPerMonth()
        {
            InitializeComponent();
        }

        private void TravelAgentsListWithMaxSalesCountPerMonth_Load(object sender, EventArgs e)
        {
            if (dataSet.Tables.Contains(baseTableName))
            {
                dataSet.Tables[baseTableName].Clear();
            }
            QueriesTableAdapter queriesTableAdapter = new QueriesTableAdapter();
            queriesTableAdapter.create_travel_agents_list_with_max_sales_count_per_month();
            string command =
                $"SELECT LastName as Фамилия, FirstName as Имя, Patronymic as Отчество, BirthDate as ДатаРождения, " +
                $"PassportID as НомерПаспорта, SalesCount as КоличествоПродаж " +
                $"FROM travel_agents_list_with_max_sales_count_per_month";
            adapter = new SqlDataAdapter(command, CONNECTION_STRING);
            adapter.Fill(dataSet, baseTableName);
            dataGridView1.DataSource = dataSet.Tables[baseTableName];
            dataGridView1.Columns[3].HeaderText = "Дата рождения";
            dataGridView1.Columns[3].Width = 115;
            dataGridView1.Columns[4].HeaderText = "Номер паспорта";
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].HeaderText = "Количество продаж";
            dataGridView1.Columns[5].Width = 130;
        }
    }
}
