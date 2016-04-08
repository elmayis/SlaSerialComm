namespace SlaSerialComm
{
    partial class SlaSerialCommMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.btnSerialPorts = new System.Windows.Forms.Button();
         this.btnConnect = new System.Windows.Forms.Button();
         this.rtbIncomingData = new System.Windows.Forms.TextBox();
         this.cboSerialPorts = new System.Windows.Forms.ComboBox();
         this.cboBaudRate = new System.Windows.Forms.ComboBox();
         this.cboDataBits = new System.Windows.Forms.ComboBox();
         this.cboStopBits = new System.Windows.Forms.ComboBox();
         this.cboParity = new System.Windows.Forms.ComboBox();
         this.cboHandshaking = new System.Windows.Forms.ComboBox();
         this.lblPortNumber = new System.Windows.Forms.Label();
         this.lblBaudRate = new System.Windows.Forms.Label();
         this.lblDataBits = new System.Windows.Forms.Label();
         this.lblStopBits = new System.Windows.Forms.Label();
         this.lblParity = new System.Windows.Forms.Label();
         this.lblHandshaking = new System.Windows.Forms.Label();
         this.btnLoadFile = new System.Windows.Forms.Button();
         this.btnDownload = new System.Windows.Forms.Button();
         this.btnDisconnect = new System.Windows.Forms.Button();
         this.tboCommands = new System.Windows.Forms.TextBox();
         this.btnSend = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // btnSerialPorts
         // 
         this.btnSerialPorts.Location = new System.Drawing.Point(284, 11);
         this.btnSerialPorts.Name = "btnSerialPorts";
         this.btnSerialPorts.Size = new System.Drawing.Size(75, 23);
         this.btnSerialPorts.TabIndex = 0;
         this.btnSerialPorts.Text = "Serial Ports";
         this.btnSerialPorts.UseVisualStyleBackColor = true;
         this.btnSerialPorts.Click += new System.EventHandler(this.btnSerialPorts_Click);
         // 
         // btnConnect
         // 
         this.btnConnect.Location = new System.Drawing.Point(284, 38);
         this.btnConnect.Name = "btnConnect";
         this.btnConnect.Size = new System.Drawing.Size(75, 23);
         this.btnConnect.TabIndex = 1;
         this.btnConnect.Text = "Connect";
         this.btnConnect.UseVisualStyleBackColor = true;
         this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
         // 
         // rtbIncomingData
         // 
         this.rtbIncomingData.AcceptsReturn = true;
         this.rtbIncomingData.AcceptsTab = true;
         this.rtbIncomingData.HideSelection = false;
         this.rtbIncomingData.Location = new System.Drawing.Point(12, 175);
         this.rtbIncomingData.Multiline = true;
         this.rtbIncomingData.Name = "rtbIncomingData";
         this.rtbIncomingData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.rtbIncomingData.Size = new System.Drawing.Size(513, 275);
         this.rtbIncomingData.TabIndex = 3;
         // 
         // cboSerialPorts
         // 
         this.cboSerialPorts.FormattingEnabled = true;
         this.cboSerialPorts.Location = new System.Drawing.Point(88, 13);
         this.cboSerialPorts.Name = "cboSerialPorts";
         this.cboSerialPorts.Size = new System.Drawing.Size(179, 21);
         this.cboSerialPorts.TabIndex = 4;
         // 
         // cboBaudRate
         // 
         this.cboBaudRate.FormattingEnabled = true;
         this.cboBaudRate.Location = new System.Drawing.Point(88, 40);
         this.cboBaudRate.Name = "cboBaudRate";
         this.cboBaudRate.Size = new System.Drawing.Size(179, 21);
         this.cboBaudRate.TabIndex = 5;
         // 
         // cboDataBits
         // 
         this.cboDataBits.FormattingEnabled = true;
         this.cboDataBits.Location = new System.Drawing.Point(88, 67);
         this.cboDataBits.Name = "cboDataBits";
         this.cboDataBits.Size = new System.Drawing.Size(179, 21);
         this.cboDataBits.TabIndex = 6;
         // 
         // cboStopBits
         // 
         this.cboStopBits.FormattingEnabled = true;
         this.cboStopBits.Location = new System.Drawing.Point(88, 94);
         this.cboStopBits.Name = "cboStopBits";
         this.cboStopBits.Size = new System.Drawing.Size(179, 21);
         this.cboStopBits.TabIndex = 7;
         // 
         // cboParity
         // 
         this.cboParity.FormattingEnabled = true;
         this.cboParity.Location = new System.Drawing.Point(88, 121);
         this.cboParity.Name = "cboParity";
         this.cboParity.Size = new System.Drawing.Size(179, 21);
         this.cboParity.TabIndex = 8;
         // 
         // cboHandshaking
         // 
         this.cboHandshaking.FormattingEnabled = true;
         this.cboHandshaking.Location = new System.Drawing.Point(88, 148);
         this.cboHandshaking.Name = "cboHandshaking";
         this.cboHandshaking.Size = new System.Drawing.Size(179, 21);
         this.cboHandshaking.TabIndex = 9;
         // 
         // lblPortNumber
         // 
         this.lblPortNumber.AutoSize = true;
         this.lblPortNumber.Location = new System.Drawing.Point(9, 17);
         this.lblPortNumber.Name = "lblPortNumber";
         this.lblPortNumber.Size = new System.Drawing.Size(67, 13);
         this.lblPortNumber.TabIndex = 10;
         this.lblPortNumber.Text = "Port number:";
         // 
         // lblBaudRate
         // 
         this.lblBaudRate.AutoSize = true;
         this.lblBaudRate.Location = new System.Drawing.Point(9, 44);
         this.lblBaudRate.Name = "lblBaudRate";
         this.lblBaudRate.Size = new System.Drawing.Size(56, 13);
         this.lblBaudRate.TabIndex = 11;
         this.lblBaudRate.Text = "Baud rate:";
         // 
         // lblDataBits
         // 
         this.lblDataBits.AutoSize = true;
         this.lblDataBits.Location = new System.Drawing.Point(9, 71);
         this.lblDataBits.Name = "lblDataBits";
         this.lblDataBits.Size = new System.Drawing.Size(52, 13);
         this.lblDataBits.TabIndex = 12;
         this.lblDataBits.Text = "Data bits:";
         // 
         // lblStopBits
         // 
         this.lblStopBits.AutoSize = true;
         this.lblStopBits.Location = new System.Drawing.Point(9, 98);
         this.lblStopBits.Name = "lblStopBits";
         this.lblStopBits.Size = new System.Drawing.Size(51, 13);
         this.lblStopBits.TabIndex = 13;
         this.lblStopBits.Text = "Stop bits:";
         // 
         // lblParity
         // 
         this.lblParity.AutoSize = true;
         this.lblParity.Location = new System.Drawing.Point(9, 125);
         this.lblParity.Name = "lblParity";
         this.lblParity.Size = new System.Drawing.Size(36, 13);
         this.lblParity.TabIndex = 14;
         this.lblParity.Text = "Parity:";
         // 
         // lblHandshaking
         // 
         this.lblHandshaking.AutoSize = true;
         this.lblHandshaking.Location = new System.Drawing.Point(9, 152);
         this.lblHandshaking.Name = "lblHandshaking";
         this.lblHandshaking.Size = new System.Drawing.Size(73, 13);
         this.lblHandshaking.TabIndex = 15;
         this.lblHandshaking.Text = "Handshaking:";
         // 
         // btnLoadFile
         // 
         this.btnLoadFile.Location = new System.Drawing.Point(450, 11);
         this.btnLoadFile.Name = "btnLoadFile";
         this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
         this.btnLoadFile.TabIndex = 16;
         this.btnLoadFile.Text = "Load File";
         this.btnLoadFile.UseVisualStyleBackColor = true;
         // 
         // btnDownload
         // 
         this.btnDownload.Location = new System.Drawing.Point(450, 38);
         this.btnDownload.Name = "btnDownload";
         this.btnDownload.Size = new System.Drawing.Size(75, 23);
         this.btnDownload.TabIndex = 17;
         this.btnDownload.Text = "Download";
         this.btnDownload.UseVisualStyleBackColor = true;
         // 
         // btnDisconnect
         // 
         this.btnDisconnect.Location = new System.Drawing.Point(284, 66);
         this.btnDisconnect.Name = "btnDisconnect";
         this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
         this.btnDisconnect.TabIndex = 18;
         this.btnDisconnect.Text = "Disconnect";
         this.btnDisconnect.UseVisualStyleBackColor = true;
         this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
         // 
         // tboCommands
         // 
         this.tboCommands.Location = new System.Drawing.Point(284, 121);
         this.tboCommands.Name = "tboCommands";
         this.tboCommands.Size = new System.Drawing.Size(241, 20);
         this.tboCommands.TabIndex = 19;
         // 
         // btnSend
         // 
         this.btnSend.Location = new System.Drawing.Point(284, 146);
         this.btnSend.Name = "btnSend";
         this.btnSend.Size = new System.Drawing.Size(75, 23);
         this.btnSend.TabIndex = 20;
         this.btnSend.Text = "Send";
         this.btnSend.UseVisualStyleBackColor = true;
         this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
         // 
         // SlaSerialCommMainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(537, 462);
         this.Controls.Add(this.btnSend);
         this.Controls.Add(this.tboCommands);
         this.Controls.Add(this.btnDisconnect);
         this.Controls.Add(this.btnDownload);
         this.Controls.Add(this.btnLoadFile);
         this.Controls.Add(this.lblHandshaking);
         this.Controls.Add(this.lblParity);
         this.Controls.Add(this.lblStopBits);
         this.Controls.Add(this.lblDataBits);
         this.Controls.Add(this.lblBaudRate);
         this.Controls.Add(this.lblPortNumber);
         this.Controls.Add(this.cboHandshaking);
         this.Controls.Add(this.cboParity);
         this.Controls.Add(this.cboStopBits);
         this.Controls.Add(this.cboDataBits);
         this.Controls.Add(this.cboBaudRate);
         this.Controls.Add(this.cboSerialPorts);
         this.Controls.Add(this.rtbIncomingData);
         this.Controls.Add(this.btnConnect);
         this.Controls.Add(this.btnSerialPorts);
         this.Name = "SlaSerialCommMainForm";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerialPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox rtbIncomingData;
      private System.Windows.Forms.ComboBox cboSerialPorts;
      private System.Windows.Forms.ComboBox cboBaudRate;
      private System.Windows.Forms.ComboBox cboStopBits;
      private System.Windows.Forms.ComboBox cboParity;
      private System.Windows.Forms.ComboBox cboHandshaking;
      private System.Windows.Forms.ComboBox cboDataBits;
      private System.Windows.Forms.Label lblPortNumber;
      private System.Windows.Forms.Label lblBaudRate;
      private System.Windows.Forms.Label lblDataBits;
      private System.Windows.Forms.Label lblStopBits;
      private System.Windows.Forms.Label lblParity;
      private System.Windows.Forms.Label lblHandshaking;
      private System.Windows.Forms.Button btnLoadFile;
      private System.Windows.Forms.Button btnDownload;
      private System.Windows.Forms.Button btnDisconnect;
      private System.Windows.Forms.TextBox tboCommands;
      private System.Windows.Forms.Button btnSend;
   }
}

