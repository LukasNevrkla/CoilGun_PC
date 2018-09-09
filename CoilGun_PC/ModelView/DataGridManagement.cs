using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoilGun_PC.ModelView
{
    class DataGridManagement
    {
        public DataGrid dataGrid { get; set; }
        DataView _dataView = new DataView();
        DataTable _table = new DataTable();

        public DataGridManagement(DataGrid _dataGrid)
        {
            dataGrid = _dataGrid;
        }

        public void CreateDataGrid(string[] columns_names)
        {
            for (var c = 0; c < columns_names.Length; c++)
            {
                _table.Columns.Add(new DataColumn(columns_names[c]));
            }
        }

        public void AddToDataGrid(List<object[]> data)
        {
            foreach (object[] i in data)
            {
                var newRow = _table.NewRow();
                for (var c = 0; c < i.Length; c++)
                {
                    newRow[c] = i[c];
                }
                _table.Rows.Add(newRow);
            }

            _dataView = _table.DefaultView;
            dataGrid.DataContext = _dataView;
        }
    }
}
