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
         this.button2 = new System.Windows.Forms.Button();
         this.rtbIncomingData = new System.Windows.Forms.TextBox();
         this.cboSerialPorts = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // btnSerialPorts
         // 
         this.btnSerialPorts.Location = new System.Drawing.Point(26, 12);
         this.btnSerialPorts.Name = "btnSerialPorts";
         this.btnSerialPorts.Size = new System.Drawing.Size(75, 23);
         this.btnSerialPorts.TabIndex = 0;
         this.btnSerialPorts.Text = "Serial Ports";
         this.btnSerialPorts.UseVisualStyleBackColor = true;
         this.btnSerialPorts.Click += new System.EventHandler(this.btnSerialPorts_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(26, 72);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 1;
         this.button2.Text = "button2";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // rtbIncomingData
         // 
         this.rtbIncomingData.Location = new System.Drawing.Point(12, 127);
         this.rtbIncomingData.Multiline = true;
         this.rtbIncomingData.Name = "rtbIncomingData";
         this.rtbIncomingData.Size = new System.Drawing.Size(513, 323);
         this.rtbIncomingData.TabIndex = 3;
         // 
         // cboSerialPorts
         // 
         this.cboSerialPorts.FormattingEnabled = true;
         this.cboSerialPorts.Location = new System.Drawing.Point(108, 13);
         this.cboSerialPorts.Name = "cboSerialPorts";
         this.cboSerialPorts.Size = new System.Drawing.Size(179, 21);
         this.cboSerialPorts.TabIndex = 4;
         // 
         // SlaSerialCommMainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(537, 462);
         this.Controls.Add(this.cboSerialPorts);
         this.Controls.Add(this.rtbIncomingData);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.btnSerialPorts);
         this.Name = "SlaSerialCommMainForm";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerialPorts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rtbIncomingData;
      private System.Windows.Forms.ComboBox cboSerialPorts;
   }
}

