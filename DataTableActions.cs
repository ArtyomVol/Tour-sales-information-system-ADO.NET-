using System.Data;

namespace WindowsFormsApp1
{
    class DataTableActions
    {
        public static void RemoveErrorText(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                row.ClearErrors();
            }
        }

        public static DataRow GetRowWithError(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row.HasErrors)
                {
                    return row;
                }
            }
            return null;
        }
    }
}
