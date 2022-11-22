using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ToursDirectory : Form
    {
        HotelsDirectory hotelsDirectory;
        bool formIsOpen;
        List<DataRow> deletedRows;

        public ToursDirectory()
        {
            InitializeComponent();
        }

        private void ToursDirectory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.Tours". При необходимости она может быть перемещена или удалена.
            this.toursTableAdapter.Fill(this.travelAgencyDataSet.Tours);
            formIsOpen = true;
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
                DataTableActions.RemoveErrorText(travelAgencyDataSet.Tours);
                toursBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelAgencyDataSet);
                this.Close();
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

        public void updateComboBox()
        {
            string[] selectStringIds = new string[toursDataGridView.Rows.Count];
            for (int i = 0; i < selectStringIds.Length; i++)
            {
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)toursDataGridView.Rows[i].Cells[1];
                selectStringIds[i] = comboBoxCell.Value.ToString();
            }
            this.hotelsTableAdapter.Fill(this.travelAgencyDataSet.Hotels);

            List<string> possibleIds = new List<string>();
            foreach (DataRow row in travelAgencyDataSet.Hotels.Rows)
            {
                possibleIds.Add(row["HotelId"].ToString());
            }
            for (int i = 0; i < selectStringIds.Length; i++)
            {
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)toursDataGridView.Rows[i].Cells[1];
                if (possibleIds.Contains(selectStringIds[i]))
                {
                    comboBoxCell.Value = selectStringIds[i];
                }
                else
                {
                    comboBoxCell.Value = possibleIds[0];
                }
            }
        }

        private void ToursDirectory_FormClosed(object sender, FormClosedEventArgs e)
        {
            formIsOpen = false;
            Sales ownerForm = (Sales)Owner;
            ownerForm.updateTourComboBox();
            toursDataGridView.CurrentCell = null;
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

        private void ToursDirectory_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable dataTable = travelAgencyDataSet.Tours.GetChanges();
            if (dataTable != null && formIsOpen)
            {
                DialogResult dialogResult = MessageBox.Show("Внесённые изменения не сохраннены, всё равно закрыть?", "Внимание", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            deletedRows.Add(((DataRowView)toursBindingSource.Current).Row);
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void toursDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }
    }
}
