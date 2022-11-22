using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TravelAgents : Form
    {
        TravelAgentsListWithMaxSalesCountPerMonth travelAgentsListWithMaxSalesCountPerMonth;
        List<DataRow> deletedRows;

        public TravelAgents()
        {
            InitializeComponent();
        }

        private void TravelAgents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travelAgencyDataSet.TravelAgents". При необходимости она может быть перемещена или удалена.
            this.travelAgentsTableAdapter.Fill(this.travelAgencyDataSet.TravelAgents);
            deletedRows = new List<DataRow>();
            birthDateDateTimePicker.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            travelAgentsBindingSource.MoveFirst();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            travelAgentsBindingSource.MoveLast();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            travelAgentsBindingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            travelAgentsBindingSource.MoveNext();
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                travelAgentsBindingSource.AddNew();
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните предыдущую запись");
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            deletedRows.Add(((DataRowView)travelAgentsBindingSource.Current).Row);
            travelAgentsBindingSource.RemoveCurrent();
        }

        private void buttonSaveToBD_Click(object sender, EventArgs e)
        {
            try
            {
                DataTableActions.RemoveErrorText(travelAgencyDataSet.TravelAgents);
                travelAgentsBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(travelAgencyDataSet);
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

        private void buttonRejectChanges_Click(object sender, EventArgs e)
        {
            travelAgencyDataSet.Tables["TravelAgents"].RejectChanges();
        }

        private void ViewToolStripMenuItemClick()
        {
            tableViewToolStripMenuItem.Checked = !tableViewToolStripMenuItem.Checked;
            textBoxesViewToolStripMenuItem.Checked = !textBoxesViewToolStripMenuItem.Checked;
            travelAgentsDataGridView.Visible = tableViewToolStripMenuItem.Checked;
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

        private void TravelAgents_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (travelAgencyDataSet.TravelAgents.GetChanges() != null)
            {
                DialogResult dialogResult = MessageBox.Show("Внесённые изменения не сохраннены, всё равно закрыть?", "Внимание", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void travelAgentsWithMaxSalesCountPerMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (travelAgentsListWithMaxSalesCountPerMonth == null || travelAgentsListWithMaxSalesCountPerMonth.IsDisposed)
                {
                    travelAgentsListWithMaxSalesCountPerMonth = new TravelAgentsListWithMaxSalesCountPerMonth();
                }
                travelAgentsListWithMaxSalesCountPerMonth.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
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

        private void TravelAgents_FormClosed(object sender, FormClosedEventArgs e)
        {
            travelAgentsDataGridView.CurrentCell = null;
        }
    }
}
