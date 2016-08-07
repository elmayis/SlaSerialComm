using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SlaSerialComm
{
   public partial class SlaSerialCommMainForm : Form
   {
      public delegate void UpdateTextCallback(string text);
      //private uint m_uBaudRate = 0;
      //private uint m_uDataBits = 0;
      //private string m_sStopBits;



      Thread _readThread;
      SerialPort _serialPort = new SerialPort();
      bool _bContinue = true;
      string _SelectedFileName;
      private FileStream m_oFileStream;

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
         btnSend.Enabled = false;

         ReadFromRegistry();

         _readThread = new Thread(Read);
         _readThread.Start();
      }

      private void btnSerialPorts_Click(object sender, EventArgs e)
      {
         string[] Array_serialPortsNames = null;

         Array_serialPortsNames = SerialPort.GetPortNames();
         if (0 != Array_serialPortsNames.GetLength(0))
         {
            string _serialPortName = null;
            int index = -1;
            do
            {
               index += 1;
               cboSerialPorts.Items.Add(Array_serialPortsNames[index]);
               // Select the first entry added to the combo box
               //
               if (0 == index)
               {
                  cboSerialPorts.Text = Array_serialPortsNames[index];
               }
            }
            while (!((Array_serialPortsNames[index] == _serialPortName) || (index == Array_serialPortsNames.GetUpperBound(0))));
            btnConnect.Enabled = true;
         }
         else
         {
            btnConnect.Enabled = false;
         }
      }

      private void btnConnect_Click(object sender, EventArgs e)
      {
         // Arduino default is 8 bits, no parity, 1 stop bit
         //
         _serialPort.PortName = Convert.ToString(cboSerialPorts.Text);
         _serialPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
         _serialPort.DataBits = Convert.ToInt16(cboDataBits.Text);
         _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
         _serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandshaking.Text);
         _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
         try
         {
            _serialPort.Open();
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            btnDownload.Enabled = true;
            btnSend.Enabled = true;
         }
         catch
         {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnDownload.Enabled = false;
            btnSend.Enabled = false;
         }
      }

      private void btnDisconnect_Click(object sender, EventArgs e)
      {
         _serialPort.Close();
         btnConnect.Enabled = true;
         btnDisconnect.Enabled = false;
         btnDownload.Enabled = false;
         btnSend.Enabled = false;
      }

      public void Read()
      {
         while(_bContinue)
         {
            if (_serialPort.IsOpen)
            {
               try
               {
                  string message = _serialPort.ReadLine();
                  rtbIncomingData.BeginInvoke(new UpdateTextCallback(UpdateText),
                              new object[] { message });
               }
               catch (TimeoutException) { }
            }
         }
      }

      private void btnSend_Click(object sender, EventArgs e)
      {
         if(0 != tboCommands.Text.Length)
         {
            _serialPort.WriteLine(tboCommands.Text);
         }
      }

      private void UpdateText(string text)
      {
         rtbIncomingData.AppendText(text + "\r\n");
      }

      private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
      {
         _SelectedFileName = openFileDialog.FileName;
         UpdateText("File name selected is " + _SelectedFileName);
         m_oFileStream = File.OpenRead(_SelectedFileName);
         UpdateText("File size in bytes is " + m_oFileStream.Length);
         while (m_oFileStream.Position < m_oFileStream.Length)
         {
            UpdateText(m_oFileStream.ReadByte().ToString());
         }
         m_oFileStream.Close();
      }

      private void btnLoadFile_Click(object sender, EventArgs e)
      {
         openFileDialog.DefaultExt = ".ild";
         openFileDialog.Filter = "ILDA documents (.ild)|*.ild";
         openFileDialog.ShowDialog();
      }

      private void SlaSerialCommMainForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         _bContinue = false;
         _readThread.Join();
      }

      private void ReadFromRegistry()
      {
         RegistryKey oAppKey = GetAppSubKey();
         // Retrieve the baud rate from the registry
         //
         object oValue = oAppKey.GetValue("BaudRate", 250000);
         if(null != oValue)
         {
            int iIndex = cboBaudRate.FindString(oValue.ToString());
            if(-1 != iIndex)
            {
               cboBaudRate.SelectedIndex = iIndex;
            }
         }
         // Retrieve the data bits from the registy
         //
         oValue = oAppKey.GetValue("DataBits", 8);
         if (null != oValue)
         {
            int iIndex = cboDataBits.FindString(oValue.ToString());
            if (-1 != iIndex)
            {
               cboDataBits.SelectedIndex = iIndex;
            }
         }
         // Retrieve the stop bits from the registy
         //
         oValue = oAppKey.GetValue("StopBits", "One");
         if (null != oValue)
         {
            int iIndex = cboStopBits.FindString(oValue.ToString());
            if (-1 != iIndex)
            {
               cboStopBits.SelectedIndex = iIndex;
            }
         }
         // Retrieve the parity from the registy
         //
         oValue = oAppKey.GetValue("Parity", "None");
         if (null != oValue)
         {
            int iIndex = cboParity.FindString(oValue.ToString());
            if (-1 != iIndex)
            {
               cboParity.SelectedIndex = iIndex;
            }
         }
         // Retrieve the handshaking from the registy
         //
         oValue = oAppKey.GetValue("Handshaking", "None");
         if (null != oValue)
         {
            int iIndex = cboHandshaking.FindString(oValue.ToString());
            if (-1 != iIndex)
            {
               cboParity.SelectedIndex = iIndex;
            }
         }
      }

      /**
         Update the registry when the baud rate selection changes
      */
      private void cboBaudRate_SelectionChangeCommitted(object sender, EventArgs e)
      {
         RegistryKey oAppKey = GetAppSubKey();
         int iValue = Convert.ToInt32(cboBaudRate.SelectedItem.ToString());
         oAppKey.SetValue("BaudRate", iValue);
      }

      /**
         Update the registry when the data bits selection changes
      */
      private void cboDataBits_SelectionChangeCommitted(object sender, EventArgs e)
      {
         RegistryKey oAppKey = GetAppSubKey();
         int iValue = Convert.ToInt32(cboDataBits.SelectedItem.ToString());
         oAppKey.SetValue("DataBits", iValue);
      }

      /**
         Update the registry when the stop bits selection changes
      */
      private void cboStopBits_SelectionChangeCommitted(object sender, EventArgs e)
      {
         RegistryKey oAppKey = GetAppSubKey();
         int iValue = Convert.ToInt32(cboStopBits.SelectedItem.ToString());
         oAppKey.SetValue("StopBits", iValue);
      }

      /**
         Update the registry when the parity selection changes
      */
      private void cboParity_SelectionChangeCommitted(object sender, EventArgs e)
      {
         RegistryKey oAppKey = GetAppSubKey();
         int iValue = Convert.ToInt32(cboParity.SelectedItem.ToString());
         oAppKey.SetValue("Parity", iValue);
      }

      /**
         Update the registry when the handshaking selection changes
      */
      private void cboHandshaking_SelectionChangeCommitted(object sender, EventArgs e)
      {
         RegistryKey oAppKey = GetAppSubKey();
         int iValue = Convert.ToInt32(cboHandshaking.SelectedItem.ToString());
         oAppKey.SetValue("Parity", iValue);
      }

      /**
         @return the registry sub key for the application
      */
      private RegistryKey GetAppSubKey()
      {
         string sSubkey = "SOFTWARE\\" + Application.ProductName;
         RegistryKey oCurrentUserRk = Registry.CurrentUser;
         RegistryKey oAppKey = oCurrentUserRk.OpenSubKey(sSubkey, true);
         if (null == oAppKey)
         {
            oAppKey = oCurrentUserRk.CreateSubKey(sSubkey);
         }
         return oAppKey;
      }
   }
}
