using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace CoilGun_PC.Serial
{
    class SerialCommunication
    {
        SerialPort serial = new SerialPort();
        View.Serial_connection._delegate del;

        public void StartSerial(string port, int baud, View.Serial_connection._delegate _del)
        {
            serial.Close();

            if ((port != null) && (baud > 0))
            { 
                serial.PortName = port;
                serial.BaudRate = baud;
                serial.Handshake = Handshake.None;
                serial.Parity = Parity.None;
                serial.DataBits = 8;
                serial.StopBits = StopBits.One;
                serial.ReadTimeout = 200;
                serial.WriteTimeout = 50;

                serial.DataReceived += new SerialDataReceivedEventHandler(Recieve);
                serial.Open();
                del = _del;
            }
        }

        private void Recieve(object sender, SerialDataReceivedEventArgs e)
        {
             string recieved_data = serial.ReadExisting();

             del(recieved_data);
        }

        public string[] FindPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            return ports;
        }

        public int [] GetBaudrates()
        {
            int[] baud = { 300, 600, 1200, 2400, 9600, 14400, 19200, 38400, 57600, 115200 };
            return baud;
        }
    }
}
