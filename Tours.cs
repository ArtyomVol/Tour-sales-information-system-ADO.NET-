using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Tours : Form
    {
        HotelsDirectory hotelsDirectory;
        ToursListPerHotelName toursListPerHotelName;
        UnfinishedTours unfinishedTours;
        List<DataRow> deletedRows;

        public Tours()
        {
            InitializeComponent();
        }

        private void Tours_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Tours". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter.Fill(this.travelAgencyDataSet.Tours);
            deletedRows = new List<DataRow>();
            toursDataGridView.DataSource = toursBindingSource;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            toursBindingSource.MoveFirst();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            toursBindingSource.MoveLast();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            toursBindingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            toursBindingSource.MoveNext();
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                toursBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните предыдущую запись");
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            deletedRows.Add(((DataRowView)toursBindingSource.Current).Row);
            toursBindingSource.RemoveCurrent();
        }

        private void buttonSaveToBD_Click(object sender, EventArgs e)
        {
            try
            {
                DataTableActions.RemoveErrorText(travelAgencyDataSet.Tours);
                toursBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelAgencyDataSet);
            }
            catch (Exception exc)
            {
                if (exc.Message.Contains("Конфликт инструкции DELETE с ограничением REFERENCE " +
                    "\"FK__Sales__TourId__47DBAE45\". Конфликт произошел в базе данных \"TravelAgency\", таблица " +
                    "\"dbo.Sales\", column 'TourId'."))
                {
                    MessageBox.Show("Сохранение данных невозможно, т.к. была удалена запись с туром, " +
                        "которая используется в другой таблице. Удалённые записи, мешающие сохранению, будут восстановлены.");
                    Recoverer.RecoverDeletedRows(deletedRows, toursBindingSource,
                        tableAdapterManager, travelAgencyDataSet);
                    deletedRows = new List<DataRow>();
                }
                else if (exc.Message.Contains("Конфликт произошел в базе данных \"TravelAgency\", таблица " +
                    "\"dbo.Tours\", column 'Price'."))
                {
                    MessageBox.Show("Ошибка. Неверно введена цена тура. Цена тура должна быть больше 0.");
                }
                else if (exc.Message.Contains("Конфликт произошел в базе данных \"TravelAgency\", таблица " +
                    "\"dbo.Tours\", column 'BeginDate'."))
                {
                    DateTime date = DateTime.Now;
                    MessageBox.Show($"Ошибка. Неверно введена дата начала тура. Дата начала тура должна быть не раньше " +
                        $"01.01.2022 и не позже, чем текущая дата: {date.Day}.{date.Month}.{date.Year}");
                }
                else if (exc.Message.Contains("Конфликт произошел в базе данных \"TravelAgency\", таблица " +
                    "\"dbo.Tours\", column 'EndDate'."))
                {
                    DateTime date = DateTime.Now;
                    MessageBox.Show($"Ошибка. Неверно введена дата окончания тура. Дата окончания тура должна быть " +
                        $"не раньше 01.01.2022 и не позже, чем текущая дата: {date.Day}.{date.Month}.{date.Year}");
                }
                else if (exc.Message.Contains("Транзакция завершилась в триггере. Выполнение пакета прервано."))
                {
                    MessageBox.Show($"Ошибка. Дата начала тура должна быть раньше, чем дата окончания тура.");
                }
                else if (exc.Message.Contains("Не удается вставить повторяющийся ключ в объект \"dbo.Tours\"." +
                    " Повторяющееся значение ключа:"))
                {
                    MessageBox.Show($"Ошибка. Введено повторяющееся название отеля.");
                }
                else
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void buttonRejectChanges_Click(object sender, EventArgs e)
        {
            travelAgencyDataSet.Tables["Tours"].RejectChanges();
        }

        public void updateComboBox()
        {
            int selectId = Convert.ToInt32(comboBox1.SelectedValue);
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);
            List<int> possibleIds = new List<int>();
            foreach (DataRow row in travelAgencyDataSet.Hotels.Rows)
            {
                possibleIds.Add(Convert.ToInt32(row["HotelId"]));
            }
            if (possibleIds.Contains(selectId))
            {
                comboBox1.SelectedValue = selectId;
            }
            else
            {
                comboBox1.SelectedValue = possibleIds[0];
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
            toursDataGridView.Visible = tableViewToolStripMenuItem.Checked;
            textBoxesPanel.Visible = textBoxesViewToolStripMenuItem.Checked;
        }

        private void hotelsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (hotelsDirectory == null || hotelsDirectory.IsDisposed)
                {
                    hotelsDirectory = new HotelsDirectory();
                    hotelsDirectory.Owner = this;
                }
                hotelsDirectory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void toursByHotelNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (toursListPerHotelName == null || toursListPerHotelName.IsDisposed)
                {
                    toursListPerHotelName = new ToursListPerHotelName();
                }
                toursListPerHotelName.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void unfineshedToursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (unfinishedTours == null || unfinishedTours.IsDisposed)
                {
                    unfinishedTours = new UnfinishedTours();
                }
                unfinishedTours.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Tours_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (travelAgencyDataSet.Tours.GetChanges() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Внесённые изменения не сохраннены, всё равно закрыть?", "Внимание", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            if (!e.Cancel)
            {
                toursDataGridView.DataSource = null;
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(nameTextBox.Text, 50, e.KeyChar);
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = DataChecker.CheckStringForLengthAndCharIsNumberInKeyPressEvent(priceTextBox.Text, 6, e.KeyChar);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            ComboBoxCheckValue.ComboBox_Leave(sender);
        }

        private void Tours_FormClosed(object sender, FormClosedEventArgs e)
        {
            toursDataGridView.CurrentCell = null;
        }
    }
}
