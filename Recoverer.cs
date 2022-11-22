using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.TravelAgencyDataSetTableAdapters;

namespace WindowsFormsApp1
{
    class Recoverer
    {
        public static void RecoverDeletedRows(List<DataRow> deletedRows, BindingSource bindingSource,
            TableAdapterManager tableAdapterManager, TravelAgencyDataSet travelAgencyDataSet)
        {
            foreach (var row in deletedRows)
            {
                try
                {
                    row.RejectChanges();
                }
                catch { }
            }
            foreach (var row in deletedRows)
            {
                row.Delete();
                bindingSource.EndEdit();
                try
                {
                    tableAdapterManager.UpdateAll(travelAgencyDataSet);
                }
                catch
                {
                    row.RejectChanges();
                }
            }
            bindingSource.EndEdit();
            tableAdapterManager.UpdateAll(travelAgencyDataSet);
        }
    }
}
