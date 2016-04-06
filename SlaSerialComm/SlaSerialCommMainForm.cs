﻿using System;
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
            rtbIncomingData.Text += ArrayComPortsNames[index] + "\r\n";
         }
         while (!((ArrayComPortsNames[index] == ComPortName) ||
                             (index == ArrayComPortsNames.GetUpperBound(0))));
      }
   }
}
