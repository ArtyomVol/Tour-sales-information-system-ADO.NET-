using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Hotels : Form
    {
        NotBadHotels notBadHotels;
        HotelsFromCountry hotelsFromCountry;
        List<DataRow> deletedRows;

        public Hotels()
        {
            InitializeComponent();
        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);
            deletedRows = new List<DataRow>();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.MoveFirst();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.MoveLast();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            hotelsBindingSource.MoveNext();
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                hotelsBindingSource.AddNew();
            }
            catch
            {
                MessageBox.Show("Заполните предыдущую запись");
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            deletedRows.Add(((DataRowView)hotelsBindingSource.Current).Row);
            hotelsBindingSource.RemoveCurrent();
        }

        private void buttonSaveToBD_Click(object sender, EventArgs e)
        {
            try
            {
                DataTableActions.RemoveErrorText(travelAgencyDataSet.Hotels);
                hotelsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelAgencyDataSet);
            }
            catch (Exception exc)
            {
                if (exc.Message.Contains("Конфликт инструкции DELETE с ограничением REFERENCE \"FK__Tours__HotelId__36B12243\"." +
                    " Конфликт произошел в базе данных \"TravelAgency\", таблица \"dbo.Tours\", column 'HotelId'."))
                {
                    MessageBox.Show("Сохранение данных невозможно, т.к. была удалена запись с отелем, " +
                        "которая используется в другой таблице. Удалённые записи, мешающие сохранению, будут восстановлены.");
                    Recoverer.RecoverDeletedRows(deletedRows, hotelsBindingSource,
                        tableAdapterManager, travelAgencyDataSet);
                    deletedRows = new List<DataRow>();
                }
                else if (exc.Message.Contains("Конфликт произошел в базе данных \"TravelAgency\", " +
                    "таблица \"dbo.Hotels\", column 'StarsRate'."))
                {
                    MessageBox.Show("Ошибка. Неверно введены \"Звёзды\". Они должны быть в пределе от 1 до 5.");
                }
                else if (exc.Message.Contains("Не удается вставить повторяющийся ключ в объект \"dbo.Hotels\". " +
                    "Повторяющееся значение ключа:"))
                {
                    MessageBox.Show("Ошибка. Введено повторяющееся название отеля.");
                }
                else
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void buttonRejectChanges_Click(object sender, EventArgs e)
        {
            travelAgencyDataSet.Tables["Hotels"].RejectChanges();
        }

        private void starsRateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int starsRateTextUpperBorder = 1;
            char first = '1';
            char last = '5';
            DataChecker.CheckStringForLengthAndCharInKeyPressEvent(starsRateTextBox.Text,
                starsRateTextUpperBorder, e.KeyChar, first, last);
        }

        private void ViewToolStripMenuItemClick()
        {
            tableViewToolStripMenuItem.Checked = !tableViewToolStripMenuItem.Checked;
            textBoxesViewToolStripMenuItem.Checked = !textBoxesViewToolStripMenuItem.Checked;
            hotelsDataGridView.Visible = tableViewToolStripMenuItem.Checked;
            textBoxesPanel.Visible = textBoxesViewToolStripMenuItem.Checked;
        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewToolStripMenuItemClick();
        }

        private void textBoxesViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewToolStripMenuItemClick();
        }

        private void notBadHotelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (notBadHotels == null || notBadHotels.IsDisposed)
                {
                    notBadHotels = new NotBadHotels();
                }
                notBadHotels.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void hotelsFromCountruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (hotelsFromCountry == null || hotelsFromCountry.IsDisposed)
                {
                    hotelsFromCountry = new HotelsFromCountry();
                }
                hotelsFromCountry.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Hotels_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (travelAgencyDataSet.Hotels.GetChanges() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Внесённые изменения не сохраннены, всё равно закрыть?", "Внимание", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void countryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int hotelCountryTextUpperBorder = 50;
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(countryTextBox.Text,
                hotelCountryTextUpperBorder, e.KeyChar);
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int hotelNameTextUpperBorder = 40;
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(nameTextBox.Text, 
                hotelNameTextUpperBorder, e.KeyChar);
        }

        private void Hotels_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotelsDataGridView.CurrentCell = null;
        }
    }
}
