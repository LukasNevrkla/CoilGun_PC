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

namespace CoilGun_PC.View
{
    /// <summary>
    /// Interakční logika pro Data_in_graph.xaml
    /// </summary>
    public partial class Data_in_graph : UserControl
    {
        //public 
        private int[] indexes=new int [2];
   
        public Data_in_graph()
        {
            InitializeComponent();
        }

        private void CB_x_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indexes[0] = CB_x.Items.IndexOf(CB_x.SelectedItem);

            Call();
        }

        private void CB_y_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indexes[1] = CB_y.Items.IndexOf(CB_y.SelectedItem);

            Call();
        }

        private void Call()
        {
            if (indexes[0]>=0 && indexes[1] >=0) Graph_editable.instance.SetDataFromDatabase(indexes[0], indexes[1]);
        }
    }
}
