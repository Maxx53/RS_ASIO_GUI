namespace RS_ASIO_GUI
{
    partial class SettingControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.deviceCombo = new System.Windows.Forms.ComboBox();
            this.enableMasterCheck = new System.Windows.Forms.CheckBox();
            this.enableEndpointCheck = new System.Windows.Forms.CheckBox();
            this.volumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.channelNumeric = new System.Windows.Forms.NumericUpDown();
            this.channelPanel = new System.Windows.Forms.Panel();
            this.configButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DriverInfoLabel = new System.Windows.Forms.Label();
            this.InfoUpdTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelNumeric)).BeginInit();
            this.channelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Driver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "SoftwareMasterVolumePercent";
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Location = new System.Drawing.Point(59, 165);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(149, 45);
            this.volumeTrackBar.TabIndex = 9;
            this.volumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // deviceCombo
            // 
            this.deviceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceCombo.FormattingEnabled = true;
            this.deviceCombo.Items.AddRange(new object[] {
            "None"});
            this.deviceCombo.Location = new System.Drawing.Point(60, 12);
            this.deviceCombo.Name = "deviceCombo";
            this.deviceCombo.Size = new System.Drawing.Size(164, 21);
            this.deviceCombo.TabIndex = 8;
            this.deviceCombo.SelectedIndexChanged += new System.EventHandler(this.DeviceCombo_SelectedIndexChanged);
            // 
            // enableMasterCheck
            // 
            this.enableMasterCheck.AutoSize = true;
            this.enableMasterCheck.Location = new System.Drawing.Point(59, 117);
            this.enableMasterCheck.Name = "enableMasterCheck";
            this.enableMasterCheck.Size = new System.Drawing.Size(201, 17);
            this.enableMasterCheck.TabIndex = 7;
            this.enableMasterCheck.Text = "EnableSoftwareMasterVolumeControl";
            this.enableMasterCheck.UseVisualStyleBackColor = true;
            // 
            // enableEndpointCheck
            // 
            this.enableEndpointCheck.AutoSize = true;
            this.enableEndpointCheck.Location = new System.Drawing.Point(59, 94);
            this.enableEndpointCheck.Name = "enableEndpointCheck";
            this.enableEndpointCheck.Size = new System.Drawing.Size(211, 17);
            this.enableEndpointCheck.TabIndex = 6;
            this.enableEndpointCheck.Text = "EnableSoftwareEndpointVolumeControl";
            this.enableEndpointCheck.UseVisualStyleBackColor = true;
            // 
            // volumeNumeric
            // 
            this.volumeNumeric.Location = new System.Drawing.Point(215, 165);
            this.volumeNumeric.Name = "volumeNumeric";
            this.volumeNumeric.Size = new System.Drawing.Size(55, 20);
            this.volumeNumeric.TabIndex = 13;
            this.volumeNumeric.ValueChanged += new System.EventHandler(this.VolumeNumeric_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Channel";
            // 
            // channelNumeric
            // 
            this.channelNumeric.Location = new System.Drawing.Point(60, 6);
            this.channelNumeric.Name = "channelNumeric";
            this.channelNumeric.Size = new System.Drawing.Size(55, 20);
            this.channelNumeric.TabIndex = 13;
            // 
            // channelPanel
            // 
            this.channelPanel.Controls.Add(this.channelNumeric);
            this.channelPanel.Controls.Add(this.label3);
            this.channelPanel.Location = new System.Drawing.Point(0, 61);
            this.channelPanel.Name = "channelPanel";
            this.channelPanel.Size = new System.Drawing.Size(121, 32);
            this.channelPanel.TabIndex = 14;
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(230, 10);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(52, 23);
            this.configButton.TabIndex = 15;
            this.configButton.Text = "Config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Info";
            // 
            // DriverInfoLabel
            // 
            this.DriverInfoLabel.AutoSize = true;
            this.DriverInfoLabel.Location = new System.Drawing.Point(57, 43);
            this.DriverInfoLabel.Name = "DriverInfoLabel";
            this.DriverInfoLabel.Size = new System.Drawing.Size(33, 13);
            this.DriverInfoLabel.TabIndex = 17;
            this.DriverInfoLabel.Text = "None";
            // 
            // InfoUpdTimer
            // 
            this.InfoUpdTimer.Interval = 1000;
            this.InfoUpdTimer.Tick += new System.EventHandler(this.InfoUpdTimer_Tick);
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DriverInfoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.channelPanel);
            this.Controls.Add(this.volumeNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.deviceCombo);
            this.Controls.Add(this.enableMasterCheck);
            this.Controls.Add(this.enableEndpointCheck);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(285, 196);
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelNumeric)).EndInit();
            this.channelPanel.ResumeLayout(false);
            this.channelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.ComboBox deviceCombo;
        private System.Windows.Forms.CheckBox enableMasterCheck;
        private System.Windows.Forms.CheckBox enableEndpointCheck;
        private System.Windows.Forms.NumericUpDown volumeNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown channelNumeric;
        private System.Windows.Forms.Panel channelPanel;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DriverInfoLabel;
        private System.Windows.Forms.Timer InfoUpdTimer;
    }
}
