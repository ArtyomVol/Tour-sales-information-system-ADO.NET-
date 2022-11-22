using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClientsDirectory : Form
    {
        bool formIsOpen;
        List<DataRow> deletedRows;

        public ClientsDirectory()
        {
            InitializeComponent();
        }

        private void ClientsDirectory_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.travelAgencyDataSet.Clients);
            formIsOpen = true;
            deletedRows = new List<DataRow>();
            birthDateDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                DataTableActions.RemoveErrorText(travelAgencyDataSet.Clients);
                clientsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelAgencyDataSet);
                this.Close();
            }
            catch (Exception exc)
            {
                if (exc.Message.Contains("Конфликт инструкции DELETE с ограничением REFERENCE " +
                    "\"FK__Sales__ClientId__49C3F6B7\". Конфликт произошел в базе данных \"TravelAgency\", " +
                    "таблица \"dbo.Sales\", column 'ClientId'."))
                {
                    MessageBox.Show("Сохранение данных невозможно, т.к. была удалена запись с клиентом, " +
                        "которая используется в другой таблице. Удалённые записи, мешающие сохранению, будут восстановлены.");
                    Recoverer.RecoverDeletedRows(deletedRows, clientsBindingSource,
                        tableAdapterManager, travelAgencyDataSet);
                    deletedRows = new List<DataRow>();
                }
                else if (exc.Message.Contains("Конфликт произошел в базе данных \"TravelAgency\", " +
                    "таблица \"dbo.Clients\", column 'PassportID'."))
                {
                    MessageBox.Show("Ошибка. Неверно введён номер паспорта. Номер паспорта должен состоять из " +
                        "2-ух латинских букв и 7-ми цифр.");
                }
                else if (exc.Message.Contains("Конфликт произошел в базе данных \"TravelAgency\", таблица " +
                    "\"dbo.Clients\", column 'BirthDate'."))
                {
                    DateTime date = DateTime.Now;
                    MessageBox.Show($"Ошибка. Неверно введена дата рождения. Дата рождения должна быть не раньше " +
                        $"11.02.1904 и не позже, чем текущая дата: {date.Day}.{date.Month}.{date.Year}");
                }
                else if (exc.Message.Contains("Нарушено \"UQ_Clients_PassportID\" ограничения UNIQUE KEY. " +
                    "Не удается вставить повторяющийся ключ в объект \"dbo.Clients\"."))
                {
                    MessageBox.Show("Ошибка. Введён повторяющийся номер паспорта.");
                }
                else
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void buttonRejectChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientsDirectory_FormClosed(object sender, FormClosedEventArgs e)
        {
            formIsOpen = false;
            Sales ownerForm = (Sales)Owner;
            ownerForm.updateClientComboBox();
            clientsDataGridView.CurrentCell = null;
        }

        private void ClientsDirectory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (travelAgencyDataSet.Clients.GetChanges() != null && formIsOpen)
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
            clientsDataGridView.Visible = tableViewToolStripMenuItem.Checked;
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
            deletedRows.Add(((DataRowView)clientsBindingSource.Current).Row);
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int lastNameTextUpperBorder = 20;
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(lastNameTextBox.Text,
                lastNameTextUpperBorder, e.KeyChar);
        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int firstNameTextUpperBorder = 20;
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(firstNameTextBox.Text,
                firstNameTextUpperBorder, e.KeyChar);
        }

        private void patronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int patronymicTextUpperBorder = 20;
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(patronymicTextBox.Text,
                patronymicTextUpperBorder, e.KeyChar);
        }

        private void passportIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int passportIDLength = 9;
            e.Handled = DataChecker.CheckStringForLengthInKeyPressEvent(passportIDTextBox.Text,
                passportIDLength, e.KeyChar);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void clientsDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }
    }
}
