namespace SN.Food.WF.Demo.ComConfig
{
    partial class FormComConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBScale = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDPrecision = new System.Windows.Forms.NumericUpDown();
            this.CBSplitChar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NUDNumLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnSwitch = new System.Windows.Forms.Button();
            this.PBStatus = new System.Windows.Forms.PictureBox();
            this.CBStopBits = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CBBaudRate = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CBCheckBits = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CBDataBits = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CBPort = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbShowWeigth = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnThread = new System.Windows.Forms.Button();
            this.lstMain = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumLength)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBStatus)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBScale);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NUDPrecision);
            this.groupBox1.Controls.Add(this.CBSplitChar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NUDNumLength);
            this.groupBox1.Location = new System.Drawing.Point(53, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "磅秤参数";
            // 
            // CBScale
            // 
            this.CBScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBScale.FormattingEnabled = true;
            this.CBScale.Items.AddRange(new object[] {
            "上海耀华",
            "梅特勒-托利多",
            "其他"});
            this.CBScale.Location = new System.Drawing.Point(523, 24);
            this.CBScale.Name = "CBScale";
            this.CBScale.Size = new System.Drawing.Size(114, 23);
            this.CBScale.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "称类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "分隔符：";
            // 
            // NUDPrecision
            // 
            this.NUDPrecision.Location = new System.Drawing.Point(362, 25);
            this.NUDPrecision.Name = "NUDPrecision";
            this.NUDPrecision.Size = new System.Drawing.Size(72, 25);
            this.NUDPrecision.TabIndex = 13;
            this.NUDPrecision.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CBSplitChar
            // 
            this.CBSplitChar.FormattingEnabled = true;
            this.CBSplitChar.Items.AddRange(new object[] {
            "+",
            "="});
            this.CBSplitChar.Location = new System.Drawing.Point(96, 24);
            this.CBSplitChar.Name = "CBSplitChar";
            this.CBSplitChar.Size = new System.Drawing.Size(41, 23);
            this.CBSplitChar.TabIndex = 9;
            this.CBSplitChar.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "系数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "长度：";
            // 
            // NUDNumLength
            // 
            this.NUDNumLength.Location = new System.Drawing.Point(214, 25);
            this.NUDNumLength.Name = "NUDNumLength";
            this.NUDNumLength.Size = new System.Drawing.Size(72, 25);
            this.NUDNumLength.TabIndex = 11;
            this.NUDNumLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnSwitch);
            this.groupBox5.Controls.Add(this.PBStatus);
            this.groupBox5.Controls.Add(this.CBStopBits);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.CBBaudRate);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.CBCheckBits);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.CBDataBits);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.CBPort);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(56, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(656, 108);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "端口属性";
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.Location = new System.Drawing.Point(487, 74);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.Size = new System.Drawing.Size(96, 26);
            this.BtnSwitch.TabIndex = 11;
            this.BtnSwitch.Text = "打开串口";
            this.BtnSwitch.UseVisualStyleBackColor = true;
            // 
            // PBStatus
            // 
            this.PBStatus.Location = new System.Drawing.Point(420, 77);
            this.PBStatus.Name = "PBStatus";
            this.PBStatus.Size = new System.Drawing.Size(50, 22);
            this.PBStatus.TabIndex = 10;
            this.PBStatus.TabStop = false;
            // 
            // CBStopBits
            // 
            this.CBStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStopBits.FormattingEnabled = true;
            this.CBStopBits.Items.AddRange(new object[] {
            "One-1-1",
            "Two-2-2",
            "OnePointFive-3-1.5"});
            this.CBStopBits.Location = new System.Drawing.Point(287, 77);
            this.CBStopBits.Name = "CBStopBits";
            this.CBStopBits.Size = new System.Drawing.Size(96, 23);
            this.CBStopBits.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(217, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "停止位：";
            // 
            // CBBaudRate
            // 
            this.CBBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBaudRate.FormattingEnabled = true;
            this.CBBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.CBBaudRate.Location = new System.Drawing.Point(85, 77);
            this.CBBaudRate.Name = "CBBaudRate";
            this.CBBaudRate.Size = new System.Drawing.Size(96, 23);
            this.CBBaudRate.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "波特率：";
            // 
            // CBCheckBits
            // 
            this.CBCheckBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCheckBits.FormattingEnabled = true;
            this.CBCheckBits.Items.AddRange(new object[] {
            "None-0-无",
            "Odd-1-奇",
            "Ecen-2-偶",
            "Mark-3-1",
            "Space-4-2"});
            this.CBCheckBits.Location = new System.Drawing.Point(487, 32);
            this.CBCheckBits.Name = "CBCheckBits";
            this.CBCheckBits.Size = new System.Drawing.Size(96, 23);
            this.CBCheckBits.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "校验位：";
            // 
            // CBDataBits
            // 
            this.CBDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDataBits.FormattingEnabled = true;
            this.CBDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.CBDataBits.Location = new System.Drawing.Point(287, 32);
            this.CBDataBits.Name = "CBDataBits";
            this.CBDataBits.Size = new System.Drawing.Size(96, 23);
            this.CBDataBits.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "数据位：";
            // 
            // CBPort
            // 
            this.CBPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPort.FormattingEnabled = true;
            this.CBPort.Items.AddRange(new object[] {
            "com1"});
            this.CBPort.Location = new System.Drawing.Point(85, 32);
            this.CBPort.Name = "CBPort";
            this.CBPort.Size = new System.Drawing.Size(96, 23);
            this.CBPort.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "串口号：";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tbShowWeigth);
            this.groupBox7.Location = new System.Drawing.Point(56, 277);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(656, 55);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "磅秤值";
            // 
            // tbShowWeigth
            // 
            this.tbShowWeigth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbShowWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShowWeigth.ForeColor = System.Drawing.Color.Blue;
            this.tbShowWeigth.Location = new System.Drawing.Point(3, 21);
            this.tbShowWeigth.Name = "tbShowWeigth";
            this.tbShowWeigth.Size = new System.Drawing.Size(650, 34);
            this.tbShowWeigth.TabIndex = 0;
            this.tbShowWeigth.Text = "0.00";
            this.tbShowWeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(53, 863);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(637, 863);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "结束";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(59, 361);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(650, 118);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(162, 863);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(75, 23);
            this.btnThread.TabIndex = 15;
            this.btnThread.Text = "多线程";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // lstMain
            // 
            this.lstMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstMain.HideSelection = false;
            this.lstMain.Location = new System.Drawing.Point(53, 503);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(656, 327);
            this.lstMain.TabIndex = 16;
            this.lstMain.UseCompatibleStateImageBehavior = false;
            this.lstMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "时间";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "重量";
            this.columnHeader2.Width = 120;
            // 
            // FormComConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 944);
            this.Controls.Add(this.lstMain);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormComConfig";
            this.Text = "FormComConfig";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmComConfig_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrecision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumLength)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBStatus)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBScale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NUDPrecision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUDNumLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBSplitChar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnSwitch;
        private System.Windows.Forms.PictureBox PBStatus;
        private System.Windows.Forms.ComboBox CBStopBits;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CBBaudRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CBCheckBits;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CBDataBits;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CBPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbShowWeigth;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.ListView lstMain;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}