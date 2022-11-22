using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sales : Form
    {
        ToursDirectory toursDirectory;
        ClientsDirectory clientsDirectory;
        TravelAgentsDirectory travelAgentsDirectory;
        Order order;
        SalesListPerYearAndMonthForm salesListPerYearAndMonthForm;
        SalesWithMoreThenAverageCost salesWithMoreThenAverageCost;
        SalesWithNotStartedTours salesWithNotStartedTours;
        ProfitPerMonth profitPerMonth;
        ResultsOfEnterprise resultsOfEnterprise;

        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.TravelAgents". При необходимости она может быть перемещена или удалена.
            this.travelAgentsTableAdapter.Fill(this.travelAgencyDataSet.TravelAgents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.travelAgencyDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Tours". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter.Fill(this.travelAgencyDataSet.Tours);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.travelAgencyDataSet.Sales);
            salesDataGridView.DataSource = salesBindingSource;
            saleDateDateTimePicker.MaxDate = DateTime.Now;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            salesBindingSource.MoveFirst();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            salesBindingSource.MoveLast();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                salesBindingSource.MovePrevious();
            }
            catch { }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            salesBindingSource.MoveNext();
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                salesBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните предыдущую запись");
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            salesBindingSource.RemoveCurrent();
        }

        private void buttonSaveToBD_Click(object sender, EventArgs e)
        {
            try
            {
                DataTableActions.RemoveErrorText(travelAgencyDataSet.Sales);
                salesBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelAgencyDataSet);
            }
            catch (Exception exc)
            {
                if (exc.Message.Contains("Конфликт произошел в базе данных \"TravelAgency\", таблица \"dbo.Sales\", " +
                    "column 'SaleDate'."))
                {
                    DateTime date = DateTime.Now;
                    MessageBox.Show("Ошибка. Неверно введена дата продажи. Дата продажи должна быть не раньше " +
                        $"01.01.2022 и не позже, чем текущая дата: {date.Day}.{date.Month}.{date.Year}");
                }
                else if (exc.Message.Contains("Транзакция завершилась в триггере. Выполнение пакета прервано."))
                {
                    DataRow rowWithError = DataTableActions.GetRowWithError(travelAgencyDataSet.Sales);
                    int tourId = Convert.ToInt32(rowWithError["TourId"]);
                    DateTime saleDate = (DateTime)rowWithError["SaleDate"];
                    DateTime tourBegindDate = (DateTime)travelAgencyDataSet.Tours.FindByTourId(tourId)["BeginDate"];
                    MessageBox.Show($"Ошибка. Неверно введена дата продажи. Дата продажи " +
                        $"({saleDate.Day}.{saleDate.Month}.{saleDate.Year}) должна быть не позже, " +
                        $"чем дата выбранного тура: {tourBegindDate.Day}.{tourBegindDate.Month}.{tourBegindDate.Year}");
                }
                else
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void buttonRejectChanges_Click(object sender, EventArgs e)
        {
            travelAgencyDataSet.Tables["Sales"].RejectChanges();
        }

        public void updateTravelAgemtsComboBox()
        {
            int selectId = Convert.ToInt32(TravelAgentComboBox.SelectedValue);
            this.travelAgentsTableAdapter.Fill(this.travelAgencyDataSet.TravelAgents);
            List<int> possibleIds = new List<int>();
            foreach (DataRow row in travelAgencyDataSet.TravelAgents.Rows)
            {
                possibleIds.Add(Convert.ToInt32(row["TravelAgentId"]));
            }
            if (possibleIds.Contains(selectId))
            {
                TravelAgentComboBox.SelectedValue = selectId;
            }
            else
            {
                TravelAgentComboBox.SelectedValue = possibleIds[0];
            }
        }

        public void updateClientComboBox()
        {
            int selectId = Convert.ToInt32(ClientComboBox.SelectedValue);
            this.clientsTableAdapter.Fill(this.travelAgencyDataSet.Clients);
            List<int> possibleIds = new List<int>();
            foreach (DataRow row in travelAgencyDataSet.Clients.Rows)
            {
                possibleIds.Add(Convert.ToInt32(row["ClientId"]));
            }
            if (possibleIds.Contains(selectId))
            {
                ClientComboBox.SelectedValue = selectId;
            }
            else
            {
                ClientComboBox.SelectedValue = possibleIds[0];
            }
        }

        public void updateTourComboBox()
        {
            int selectId = Convert.ToInt32(TourComboBox.SelectedValue);
            this.toursTableAdapter.Fill(this.travelAgencyDataSet.Tours);
            List<int> possibleIds = new List<int>();
            foreach (DataRow row in travelAgencyDataSet.Tours.Rows)
            {
                possibleIds.Add(Convert.ToInt32(row["TourId"]));
            }
            if (possibleIds.Contains(selectId))
            {
                TourComboBox.SelectedValue = selectId;
            }
            else
            {
                TourComboBox.SelectedValue = possibleIds[0];
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (toursDirectory == null || toursDirectory.IsDisposed)
                {
                    toursDirectory = new ToursDirectory();
                    toursDirectory.Owner = this;
                }
                toursDirectory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                button9_Click(sender, e);
            }
        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewToolStripMenuItemClick();
        }

        private void textBoxesViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewToolStripMenuItemClick();
        }

        private void ViewToolStripMenuItemClick()
        {
            tableViewToolStripMenuItem.Checked = !tableViewToolStripMenuItem.Checked;
            textBoxesViewToolStripMenuItem.Checked = !textBoxesViewToolStripMenuItem.Checked;
            salesDataGridView.Visible = tableViewToolStripMenuItem.Checked;
            textBoxesPanel.Visible = textBoxesViewToolStripMenuItem.Checked;
        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (travelAgencyDataSet.Sales.GetChanges() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Внесённые изменения не сохраннены, всё равно закрыть?", "Внимание", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            if (!e.Cancel)
            {
                salesDataGridView.DataSource = null;
            }
        }

        private void getOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (order == null || order.IsDisposed)
                {
                    order = new Order();
                    order.Owner = this;
                }
                bool panelVisible = textBoxesPanel.Visible;
                textBoxesPanel.Visible = true;
                order.ShowDialog();
                textBoxesPanel.Visible = panelVisible;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void salesPerMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (salesListPerYearAndMonthForm == null || salesListPerYearAndMonthForm.IsDisposed)
                {
                    salesListPerYearAndMonthForm = new SalesListPerYearAndMonthForm();
                }
                salesListPerYearAndMonthForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void profitPerMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (profitPerMonth == null || profitPerMonth.IsDisposed)
                {
                    profitPerMonth = new ProfitPerMonth();
                }
                profitPerMonth.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void salesMoreThenAverageCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (salesWithMoreThenAverageCost == null || salesWithMoreThenAverageCost.IsDisposed)
                {
                    salesWithMoreThenAverageCost = new SalesWithMoreThenAverageCost();
                }
                salesWithMoreThenAverageCost.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void salesWithNotStartedToursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (salesWithNotStartedTours == null || salesWithNotStartedTours.IsDisposed)
                {
                    salesWithNotStartedTours = new SalesWithNotStartedTours();
                }
                salesWithNotStartedTours.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void toursListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (toursDirectory == null || toursDirectory.IsDisposed)
                {
                    toursDirectory = new ToursDirectory();
                    toursDirectory.Owner = this;
                }
                toursDirectory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void clientsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientsDirectory == null || clientsDirectory.IsDisposed)
                {
                    clientsDirectory = new ClientsDirectory();
                    clientsDirectory.Owner = this;
                }
                clientsDirectory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void travelaAgentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (travelAgentsDirectory == null || travelAgentsDirectory.IsDisposed)
                {
                    travelAgentsDirectory = new TravelAgentsDirectory();
                    travelAgentsDirectory.Owner = this;
                }
                travelAgentsDirectory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void resultsOfEnterpriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (resultsOfEnterprise == null || resultsOfEnterprise.IsDisposed)
                {
                    resultsOfEnterprise = new ResultsOfEnterprise();
                }
                resultsOfEnterprise.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void TourComboBox_Leave(object sender, EventArgs e)
        {
            ComboBoxCheckValue.ComboBox_Leave(sender);
        }

        private void TravelAgentComboBox_Leave(object sender, EventArgs e)
        {
            ComboBoxCheckValue.ComboBox_Leave(sender);
        }

        private void ClientComboBox_Leave(object sender, EventArgs e)
        {
            ComboBoxCheckValue.ComboBox_Leave(sender);
        }
    }
}
