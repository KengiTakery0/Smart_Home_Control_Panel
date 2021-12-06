using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SmartHomeHub
{
    public partial class HubForm : Form
    {
      


        string ontext = "Вкл";
        string offtext = "Выкл";

        public SerialPort port;
        public string portName = "COM7"; 
        public HubForm()
        {
            InitializeComponent();
        }
        
        private void tgBathLightONOFF_CheckedChanged(object sender, EventArgs e)
        {

            if (tgBathLightONOFF.Checked)
            {
                label6.Text = ontext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("21");
                port.Close();

            }
            else
            {
                label6.Text = offtext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("20");
                port.Close();

            }
        }

        private void tbHallLightOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (tbHallLightOnOff.Checked)
            {
                label4.Text = ontext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("31");
                port.Close();
            }
            else
            {
                label4.Text = offtext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("30");
                port.Close();

            }
        }

        private void mainRoomLightOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (mainRoomLightOnOff.Checked)
            {
                label1.Text = ontext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("111");
                port.Close();

            }
            else
            {
                label1.Text = offtext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("110");
                port.Close();

            }
        }

        private void tgKitchenLightONOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (tgKitchenLightONOFF.Checked)
            {
                label5.Text = ontext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("121");
                port.Close();

            }
            else
            {
                label5.Text = offtext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("120");
                port.Close();

            }
        }

        private void TeapotOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (TeapotOnOff.Checked)
            { 
                label12.Text = ontext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("61");
                port.Close();

            }
            else
            {
                label12.Text = offtext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("60");
                port.Close();

            }
        }

        private void CondicionerOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (CondicionerOnOff.Checked)
            {
                label13.Text = ontext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("71");
                port.Close();

            }
            else
            {
                label13.Text = offtext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("70");
                port.Close();

            }
        }

        private void DishwasherOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (DishwasherOnOff.Checked)
            {
                label11.Text = ontext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("81");
                port.Close();

            }
            else
            {
                label11.Text = offtext;
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portName;
                port.Open();
                port.WriteLine("80");
                port.Close();

            }
        }

        private void HubForm_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
    
}
