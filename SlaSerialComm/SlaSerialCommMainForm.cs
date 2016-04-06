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
         //get first item print in text
         cboBaudRate.Text = cboBaudRate.Items[0].ToString();

         //Data Bits
         cboDataBits.Items.Add(7);
         cboDataBits.Items.Add(8);
         //get the first item print it in the text 
         cboDataBits.Text = cboDataBits.Items[0].ToString();

         //Stop Bits
         cboStopBits.Items.Add("One");
         cboStopBits.Items.Add("OnePointFive");
         cboStopBits.Items.Add("Two");
         //get the first item print in the text
         cboStopBits.Text = cboStopBits.Items[0].ToString();

         //Parity 
         cboParity.Items.Add("None");
         cboParity.Items.Add("Even");
         cboParity.Items.Add("Mark");
         cboParity.Items.Add("Odd");
         cboParity.Items.Add("Space");

         //get the first item print in the text

         cboParity.Text = cboParity.Items[0].ToString();

         //Handshake
         cboHandshaking.Items.Add("None");
         cboHandshaking.Items.Add("XOnXOff");
         cboHandshaking.Items.Add("RequestToSend");
         cboHandshaking.Items.Add("RequestToSendXOnXOff");

         //get the first item print it in the text 
         cboHandshaking.Text = cboHandshaking.Items[0].ToString();
      }

      private void btnSerialPorts_Click(object sender, EventArgs e)
      {
         string[] ArrayComPortsNames = null;
         int index = -1;
         string ComPortName = null;

         ArrayComPortsNames = SerialPort.GetPortNames();
         do
         {
            index += 1;
            cboSerialPorts.Items.Add(ArrayComPortsNames[index]);
            // Select the first entry added to the combo box
            //
            if(0 == index)
            {
               cboSerialPorts.Text = ArrayComPortsNames[index];
            }
         }
         while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
      }
   }
}
