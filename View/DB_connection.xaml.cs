using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CoilGun_PC.Model;
using CoilGun_PC.ModelView;
using CoilGun_PC.SQL;


namespace CoilGun_PC.View
{
    /// <summary>
    /// Interakční logika pro DB_connection.xaml
    /// </summary>
    public partial class DB_connection : UserControl
    {
        DB_connection_model model = new DB_connection_model();

        public DB_connection()
        {
            InitializeComponent();
            this.DataContext = model;

        }

        private void Connect_bt_Click(object sender, RoutedEventArgs e)
        {
            DataGridManagement data_grid = new DataGridManagement(Colums_dg);
            SQL_commands sql = new SQL_commands();

            sql.ConnectDB(DB_connection_model.DB_name);
            List<object[]> data_template = sql.ConnectTB(DB_connection_model.TB_name, DB_connection_model.DB_name);

            string[] columns_names = { "Jméno", "Datový typ" };

            data_grid.CreateDataGrid(columns_names);
            data_grid.AddToDataGrid(data_template);
        }
    }
}
