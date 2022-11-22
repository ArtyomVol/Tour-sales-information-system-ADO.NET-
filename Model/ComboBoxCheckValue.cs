using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ComboBoxCheckValue
    {
        public static void ComboBox_Leave(object sender)
        {
            ComboBox comboBox = (ComboBox)sender;
            bool isExistData = false;
            string selectedString = comboBox.Text.ToString().ToLower();
            foreach (DataRowView item in comboBox.Items)
            {
                if (item.Row[comboBox.DisplayMember].ToString().ToLower() == selectedString)
                {
                    comboBox.Text = item.Row[comboBox.DisplayMember].ToString();
                    isExistData = true;
                    return;
                }
            }
            if (!isExistData)
            {
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
