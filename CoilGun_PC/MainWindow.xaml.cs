using System;
using System.Collections.Generic;
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
using CoilGun_PC.SQL;

namespace CoilGun_PC
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SQL_commands sql = new SQL_commands();
            sql.ConnectDB("DB1");

            List<string> list = new List<string>();
            list.Add("[ID] [int] IDENTITY(1,1) NOT NULL");
            list.Add("[Name0][int] NULL");
            list.Add("[Name1][nchar](50) NULL");
            list.Add("[Name2][nchar](50) NULL");

            sql.CreateTB("tb", "DB1", list);

            object[] data = { 45, "ADSa", "SdaD" };

            sql.AddData("tb", "DB1", data);
        }
    }
}
