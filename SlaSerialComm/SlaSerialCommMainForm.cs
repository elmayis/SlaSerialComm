using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlaSerialComm
{
   public partial class SlaSerialCommMainForm : Form
   {
      SerialPort ComPort = new SerialPort();

      public SlaSerialCommMainForm()
      {
         InitializeComponent();

         // Baud rate control
         //
         cboBaudRate.Items.Add(300);
         cboBaudRate.Items.Add(600);
         cboBaudRate.Items.Add(1200);
         cboBaudRate.Items.Add(2400);
         cboBaudRate.Items.Add(9600);
         cboBaudRate.Items.Add(14400);
         cboBaudRate.Items.Add(19200);
         cboBaudRate.Items.Add(38400);
         cboBaudRate.Items.Add(57600);
         cboBaudRate.Items.Add(115200);
         cboBaudRate.Items.Add(250000);
         cboBaudRate.Items.ToString();
         cboBaudRate.Text = cboBaudRate.Items[0].ToString();

         // Data bits control
         //
         cboDataBits.Items.Add(7);
         cboDataBits.Items.Add(8);
         cboDataBits.Text = cboDataBits.Items[0].ToString();

         // Stop bits control
         //
         cboStopBits.Items.Add("One");
         cboStopBits.Items.Add("OnePointFive");
         cboStopBits.Items.Add("Two");
         cboStopBits.Text = cboStopBits.Items[0].ToString();

         // Parity control
         //
         cboParity.Items.Add("None");
         cboParity.Items.Add("Even");
         cboParity.Items.Add("Mark");
         cboParity.Items.Add("Odd");
         cboParity.Items.Add("Space");
         cboParity.Text = cboParity.Items[0].ToString();

         //Handshake control
         //
         cboHandshaking.Items.Add("None");
         cboHandshaking.Items.Add("XOnXOff");
         cboHandshaking.Items.Add("RequestToSend");
         cboHandshaking.Items.Add("RequestToSendXOnXOff");
         cboHandshaking.Text = cboHandshaking.Items[0].ToString();

         btnConnect.Enabled = false;
         btnDisconnect.Enabled = false;
         btnDownload.Enabled = false;
      }

      private void btnSerialPorts_Click(object sender, EventArgs e)
      {
         string[] ArrayComPortsNames = null;

         ArrayComPortsNames = SerialPort.GetPortNames();
         if (0 != ArrayComPortsNames.GetLength(0))
         {
            string ComPortName = null;
            int index = -1;
            do
            {
               index += 1;
               cboSerialPorts.Items.Add(ArrayComPortsNames[index]);
               // Select the first entry added to the combo box
               //
               if (0 == index)
               {
                  cboSerialPorts.Text = ArrayComPortsNames[index];
               }
            }
            while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            btnConnect.Enabled = true;
         }
         else
         {
            btnConnect.Enabled = false;
         }
      }

      private void btnConnect_Click(object sender, EventArgs e)
      {
         ComPort.PortName = Convert.ToString(cboSerialPorts.Text);
         ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
         ComPort.DataBits = Convert.ToInt16(cboDataBits.Text);
         ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
         ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandshaking.Text);
         ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
         ComPort.Open();
         btnConnect.Enabled = false;
         btnDisconnect.Enabled = true;
         btnDownload.Enabled = true;
      }

      private void btnDisconnect_Click(object sender, EventArgs e)
      {
         ComPort.Close();
         btnConnect.Enabled = false;
         btnDisconnect.Enabled = false;
         btnDownload.Enabled = false;
      }
   }
}
