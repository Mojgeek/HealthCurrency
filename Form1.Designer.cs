namespace WindowsFormsApplication1
{
    partial class Form1
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
            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comPortConnectBtn = new System.Windows.Forms.Button();
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.bluetoothLbl = new System.Windows.Forms.Label();
            this.serialConnectionState = new System.Windows.Forms.Label();
            this.scanPortsBtn = new System.Windows.Forms.Button();
            this.testSendSerial = new System.Windows.Forms.Button();
            this.testHash = new System.Windows.Forms.Button();
            this.testHashLbl = new System.Windows.Forms.Label();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.Label();
            this.mBox = new System.Windows.Forms.PictureBox();
            this.speedShow = new System.Windows.Forms.PictureBox();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comPortConnectBtn
            // 
            this.comPortConnectBtn.Location = new System.Drawing.Point(181, 250);
            this.comPortConnectBtn.Name = "comPortConnectBtn";
            this.comPortConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.comPortConnectBtn.TabIndex = 0;
            this.comPortConnectBtn.Text = "Connect";
            this.comPortConnectBtn.UseVisualStyleBackColor = true;
            this.comPortConnectBtn.Click += new System.EventHandler(this.comPortConnectBtn_Click);
            // 
            // comPorts
            // 
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Location = new System.Drawing.Point(161, 223);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(121, 21);
            this.comPorts.TabIndex = 1;
            // 
            // bluetoothLbl
            // 
            this.bluetoothLbl.AutoSize = true;
            this.bluetoothLbl.Location = new System.Drawing.Point(178, 197);
            this.bluetoothLbl.Name = "bluetoothLbl";
            this.bluetoothLbl.Size = new System.Drawing.Size(60, 13);
            this.bluetoothLbl.TabIndex = 2;
            this.bluetoothLbl.Text = "Serial Ports";
            // 
            // serialConnectionState
            // 
            this.serialConnectionState.AutoSize = true;
            this.serialConnectionState.Location = new System.Drawing.Point(262, 255);
            this.serialConnectionState.Name = "serialConnectionState";
            this.serialConnectionState.Size = new System.Drawing.Size(89, 13);
            this.serialConnectionState.TabIndex = 3;
            this.serialConnectionState.Text = "Connection State";
            // 
            // scanPortsBtn
            // 
            this.scanPortsBtn.Location = new System.Drawing.Point(292, 221);
            this.scanPortsBtn.Name = "scanPortsBtn";
            this.scanPortsBtn.Size = new System.Drawing.Size(75, 23);
            this.scanPortsBtn.TabIndex = 4;
            this.scanPortsBtn.Text = "Scan Ports";
            this.scanPortsBtn.UseVisualStyleBackColor = true;
            this.scanPortsBtn.Click += new System.EventHandler(this.scanPortsBtn_Click);
            // 
            // testSendSerial
            // 
            this.testSendSerial.Location = new System.Drawing.Point(207, 296);
            this.testSendSerial.Name = "testSendSerial";
            this.testSendSerial.Size = new System.Drawing.Size(75, 23);
            this.testSendSerial.TabIndex = 5;
            this.testSendSerial.Text = "Test Send";
            this.testSendSerial.UseVisualStyleBackColor = true;
            this.testSendSerial.Visible = false;
            this.testSendSerial.Click += new System.EventHandler(this.testSendSerial_Click);
            // 
            // testHashLbl
            // 
            this.testHashLbl.AutoSize = true;
            this.testHashLbl.Location = new System.Drawing.Point(285, 280);
            this.testHashLbl.Name = "testHashLbl";
            this.testHashLbl.Size = new System.Drawing.Size(32, 13);
            this.testHashLbl.TabIndex = 7;
            this.testHashLbl.Text = "Code";
            this.testHashLbl.Visible = false;
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLbl.Location = new System.Drawing.Point(9, 168);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(71, 20);
            this.currencyLbl.TabIndex = 8;
            this.currencyLbl.Text = "Fit Coins";
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currency.Location = new System.Drawing.Point(9, 188);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(18, 20);
            this.currency.TabIndex = 10;
            this.currency.Text = "0";
            // 
            // mBox
            // 
            this.mBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mBox.BackgroundImage")));
            this.mBox.InitialImage = null;
            this.mBox.Location = new System.Drawing.Point(13, 223);
            this.mBox.Name = "mBox";
            this.mBox.Size = new System.Drawing.Size(58, 51);
            this.mBox.TabIndex = 12;
            this.mBox.TabStop = false;
            // 
            // speedShow
            // 
            this.speedShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("speedShow.BackgroundImage")));
            this.speedShow.InitialImage = null;
            this.speedShow.Location = new System.Drawing.Point(22, 120);
            this.speedShow.Name = "speedShow";
            this.speedShow.Size = new System.Drawing.Size(49, 45);
            this.speedShow.TabIndex = 11;
            this.speedShow.TabStop = false;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPictureBox.BackgroundImage")));
            this.mainPictureBox.InitialImage = null;
            this.mainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(69, 102);
            this.mainPictureBox.TabIndex = 9;
            this.mainPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 333);
            this.Controls.Add(this.mBox);
            this.Controls.Add(this.speedShow);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.currencyLbl);
            this.Controls.Add(this.testHashLbl);
            this.Controls.Add(this.testHash);
            this.Controls.Add(this.testSendSerial);
            this.Controls.Add(this.scanPortsBtn);
            this.Controls.Add(this.serialConnectionState);
            this.Controls.Add(this.bluetoothLbl);
            this.Controls.Add(this.comPorts);
            this.Controls.Add(this.comPortConnectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button comPortConnectBtn;
        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.Label bluetoothLbl;
        public System.Windows.Forms.Label serialConnectionState;
        private System.Windows.Forms.Button scanPortsBtn;
        private System.Windows.Forms.Button testSendSerial;
        private System.Windows.Forms.Button testHash;
        private System.Windows.Forms.Label testHashLbl;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label currency;
        private System.Windows.Forms.PictureBox speedShow;
        private System.Windows.Forms.PictureBox mBox;
    }
}

