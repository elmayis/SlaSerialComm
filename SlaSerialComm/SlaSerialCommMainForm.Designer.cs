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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rtbIncomingData = new System.Windows.Forms.TextBox();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(117, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 17);
            this.listBox1.TabIndex = 2;
            // 
            // rtbIncomingData
            // 
            this.rtbIncomingData.Location = new System.Drawing.Point(12, 127);
            this.rtbIncomingData.Multiline = true;
            this.rtbIncomingData.Name = "rtbIncomingData";
            this.rtbIncomingData.Size = new System.Drawing.Size(513, 323);
            this.rtbIncomingData.TabIndex = 3;
            // 
            // SlaSerialCommMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 462);
            this.Controls.Add(this.rtbIncomingData);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox rtbIncomingData;
    }
}

