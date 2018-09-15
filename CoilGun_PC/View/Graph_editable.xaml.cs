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
using LiveCharts;

using LiveCharts.Defaults;//!!!!!!!!!!!!!!!!!!!!

using LiveCharts.Wpf;
using CoilGun_PC.SQL;
using CoilGun_PC.ModelView;

namespace CoilGun_PC.View
{
    /// <summary>
    /// Interakční logika pro Graph_editable.xaml
    /// </summary>
    public partial class Graph_editable : UserControl
    {
        List<Data_in_graph> graph_data_controll = new List<Data_in_graph>();
        GraphManagement graph = new GraphManagement();
        public static Graph_editable instance;

        public SeriesCollection SeriesCollection { get; set; }

        public Graph_editable()
        {
            InitializeComponent();
            instance = this;

            ChartValues<ObservablePoint> Points = new ChartValues<ObservablePoint>();

            graph.CreateLineSeries("XX");

            List<double> x_list = new List<double>();
            List<double> y_list = new List<double>();

            for (int i = 0; i < 50; i++)
            {
                x_list.Add(i);
                if (i%2==0)y_list.Add(50-i);
                else y_list.Add(1);
            }

            graph.SetDataInSerie(0, x_list, y_list);
            graph.AddDataToSerie(0, x_list, y_list);

            

            DataContext = graph;
        }

        public void SetDataFromDatabase(int x_comumn, int y_comumn)
        {
            List<object[]>data= SQL_commands.GetDataFromTB();

            List<double> x_list = new List<double>();
            List<double> y_list = new List<double>();

            foreach (object[] d in data)
            {
                x_list.Add(Retype(d[x_comumn]));
                y_list.Add(Retype(d[y_comumn]));
            }

            graph.SetDataInSerie(0, x_list, y_list);
        }

        private double Retype(object data)
        {
            if (data.GetType() == typeof(int)) return (int)data;
            else if (data.GetType() == typeof(double)) return (double)data;
            else MessageBox.Show("Tyto data nejsou číselného typu!!");

            return 0;
        }

        private void Add_data_Click(object sender, RoutedEventArgs e)
        {
            if (SQL_commands.Initialized)
            {
                AddData();
                //SetDataFromDatabase();
            }
            else
            {
                MessageBox.Show("Zatím není připojena žádná tabulka!!");
            }
        }

        private void AddData()
        {
            //get button//
            int index = StackPanel.Children.Count - 1;
            UIElement button = StackPanel.Children[index];

            Data_in_graph item = new Data_in_graph();

            List<object[]> itm_src = SQL_commands.ConnectTB();
            List<object> result = new List<object>();

            foreach (object[] o in itm_src) result.Add(o[0]);

            item.CB_x.ItemsSource = result;
            item.CB_y.ItemsSource = result;


            graph_data_controll.Add(item);

            item.Data_name_tb.Text = graph_data_controll.Count + ". data";
            StackPanel.Children.Add(item);

            StackPanel.Children.RemoveAt(index);
            StackPanel.Children.Add(button);
        }
    }
}
