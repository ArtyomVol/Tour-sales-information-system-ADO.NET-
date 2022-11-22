using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HotelsDirectory : Form
    {
        bool formIsOpen;
        bool dataChangedAndSaved;
        List<DataRow> deletedRows;

        public HotelsDirectory()
        {
            InitializeComponent();
        }

        private void HotelsDirectory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);
            formIsOpen = true;
            dataChangedAndSaved = false;
            deletedRows = new List<DataRow>();
        }

        private void buttonRejectChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                DataTableActions.RemoveErrorText(travelAgencyDataSet.Hotels);
                if (travelAgencyDataSet.Hotels.GetChanges() != null)
                {
                    dataChangedAndSaved = true;
                }
                hotelsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelAgencyDataSet);
                this.Close();
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

        private void HotelsDirectory_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dataChangedAndSaved)
            {
                formIsOpen = false;
                try
                {
                    Tours ownerForm = (Tours)Owner;
                    ownerForm.updateComboBox();
                }
                catch
                {
                    formIsOpen = false;
                    ToursDirectory ownerForm = (ToursDirectory)Owner;
                    ownerForm.updateComboBox();
                }
            }
            hotelsDataGridView.CurrentCell = null;
        }

        private void HotelsDirectory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (travelAgencyDataSet.Hotels.GetChanges() != null && formIsOpen)
            {
                DialogResult dialogResult = MessageBox.Show("Внесённые изменения не сохраннены, всё равно закрыть?", "Внимание", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
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

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            deletedRows.Add(((DataRowView)hotelsBindingSource.Current).Row);
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

        private void starsRateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int starsRateTextUpperBorder = 1;
            char first = '1';
            char last = '5';
            e.Handled = DataChecker.CheckStringForLengthAndCharInKeyPressEvent(starsRateTextBox.Text,
                starsRateTextUpperBorder, e.KeyChar, first, last);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void hotelsDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }
    }
}
