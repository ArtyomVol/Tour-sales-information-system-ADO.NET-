using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TravelAgentsDirectory : Form
    {
        bool formIsOpen;
        List<DataRow> deletedRows;

        public TravelAgentsDirectory()
        {
            InitializeComponent();
        }

        private void TravelAgentsDirectory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.TravelAgents". При необходимости она может быть перемещена или удалена.
            this.travelAgentsTableAdapter.Fill(this.travelAgencyDataSet.TravelAgents);
            formIsOpen = true;
            deletedRows = new List<DataRow>();
            birthDateDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void buttonRejectChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                DataTableActions.RemoveErrorText(travelAgencyDataSet.TravelAgents);
                travelAgentsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelAgencyDataSet);
                this.Close();
            }
            catch (Exception exc)
            {
                if (exc.Message.Contains("Конфликт инструкции DELETE с ограничением REFERENCE " +
                    "\"FK__Sales__TravelAge__48CFD27E\". Конфликт произошел в базе данных \"TravelAgency\", таблица " +
                    "\"dbo.Sales\", column 'TravelAgentId'."))
                {
                    MessageBox.Show("Сохранение данных невозможно, т.к. была удалена запись с турагентом, " +
                        "которая используется в другой таблице. Удалённые записи, мешающие сохранению, будут восстановлены.");
                    Recoverer.RecoverDeletedRows(deletedRows, travelAgentsBindingSource,
                        tableAdapterManager, travelAgencyDataSet);
                    deletedRows = new List<DataRow>();
                }
                else if (exc.Message.Contains("Конфликт произошел в базе данных \"TravelAgency\", " +
                    "таблица \"dbo.TravelAgents\", column 'PassportID'."))
                {
                    MessageBox.Show("Ошибка. Неверно введён номер паспорта. Номер паспорта должен состоять из " +
                        "2-ух латинских букв и 7-ми цифр.");
                }
                else if (exc.Message.Contains("Конфликт произошел в базе данных \"TravelAgency\", таблица " +
                    "\"dbo.TravelAgents\", column 'BirthDate'."))
                {
                    DateTime date = DateTime.Now;
                    MessageBox.Show($"Ошибка. Неверно введена дата рождения. Дата рождения должна быть не раньше " +
                        $"11.02.1904 и не позже, чем текущая дата: {date.Day}.{date.Month}.{date.Year}");
                }
                else if (exc.Message.Contains("Не удается вставить повторяющийся ключ в объект \"dbo.TravelAgents\"." +
                    " Повторяющееся значение ключа:"))
                {
                    MessageBox.Show($"Ошибка. Введено повторяющееся номер паспорта.");
                }
                else
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void TravelAgentsDirectory_FormClosed(object sender, FormClosedEventArgs e)
        {
            formIsOpen = false;
            Sales ownerForm = (Sales)Owner;
            ownerForm.updateTravelAgemtsComboBox();
            travelAgentsDataGridView.CurrentCell = null;
        }

        private void TravelAgentsDirectory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (travelAgencyDataSet.TravelAgents.GetChanges() != null && formIsOpen)
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
            deletedRows.Add(((DataRowView)travelAgentsBindingSource.Current).Row);
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
            travelAgentsDataGridView.Visible = tableViewToolStripMenuItem.Checked;
            textBoxesPanel.Visible = textBoxesViewToolStripMenuItem.Checked;
        }
        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(lastNameTextBox.Text, 20, e.KeyChar);
        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(lastNameTextBox.Text, 20, e.KeyChar);
        }

        private void patronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(lastNameTextBox.Text, 20, e.KeyChar);
        }

        private void passportIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(lastNameTextBox.Text, 9, e.KeyChar);
        }

        private void travelAgentsDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }
    }
}
