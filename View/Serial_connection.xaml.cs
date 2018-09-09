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
using CoilGun_PC.Serial;

namespace CoilGun_PC.View
{
    /// <summary>
    /// Interakční logika pro Serial_connection.xaml
    /// </summary>
    public partial class Serial_connection : UserControl
    {
        SerialCommunication serial = new SerialCommunication();
        string port;
        int baudrate;
        public delegate void _delegate(string text);

        public Serial_connection()
        {
            InitializeComponent();
            Port_cb.ItemsSource = serial.FindPorts();
            Baud_cb.ItemsSource = serial.GetBaudrates();
        }

        public void UpdateText(string text)
        {
            this.Dispatcher.Invoke(() =>
            {
                Serial_text.Text += text;
                Serial_text.ScrollToEnd();
            });
        }

        private void port_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            port = e.AddedItems[0].ToString();

            _delegate del = UpdateText;
            serial.StartSerial(port, baudrate,del);
        }

        private void baud_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            baudrate = Convert.ToInt32(e.AddedItems[0]);

            _delegate del = UpdateText;
            serial.StartSerial(port, baudrate, del);
        }

        private void Port_cb_Open(object sender, EventArgs e)
        {
            Port_cb.ItemsSource = serial.FindPorts();
        }
    }
}
