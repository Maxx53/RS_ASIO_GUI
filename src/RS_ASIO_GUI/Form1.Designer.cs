namespace RS_ASIO_GUI
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.asioCheck = new System.Windows.Forms.CheckBox();
            this.wasapiCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bufferSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.buffInfoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bufferModeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.runRsButton = new System.Windows.Forms.Button();
            this.Input1Control = new RS_ASIO_GUI.SettingControl();
            this.Input0Control = new RS_ASIO_GUI.SettingControl();
            this.OutputControl = new RS_ASIO_GUI.SettingControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bufferSizeNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.asioCheck);
            this.groupBox1.Controls.Add(this.wasapiCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // asioCheck
            // 
            this.asioCheck.AutoSize = true;
            this.asioCheck.Location = new System.Drawing.Point(23, 51);
            this.asioCheck.Name = "asioCheck";
            this.asioCheck.Size = new System.Drawing.Size(79, 17);
            this.asioCheck.TabIndex = 0;
            this.asioCheck.Text = "EnableAsio";
            this.asioCheck.UseVisualStyleBackColor = true;
            // 
            // wasapiCheck
            // 
            this.wasapiCheck.AutoSize = true;
            this.wasapiCheck.Location = new System.Drawing.Point(23, 24);
            this.wasapiCheck.Name = "wasapiCheck";
            this.wasapiCheck.Size = new System.Drawing.Size(95, 17);
            this.wasapiCheck.TabIndex = 0;
            this.wasapiCheck.Text = "EnableWasapi";
            this.wasapiCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bufferSizeNumeric);
            this.groupBox2.Controls.Add(this.buffInfoLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bufferModeCombo);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ASIO";
            // 
            // bufferSizeNumeric
            // 
            this.bufferSizeNumeric.Location = new System.Drawing.Point(106, 89);
            this.bufferSizeNumeric.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.bufferSizeNumeric.Name = "bufferSizeNumeric";
            this.bufferSizeNumeric.Size = new System.Drawing.Size(120, 20);
            this.bufferSizeNumeric.TabIndex = 2;
            // 
            // buffInfoLabel
            // 
            this.buffInfoLabel.Location = new System.Drawing.Point(102, 50);
            this.buffInfoLabel.Name = "buffInfoLabel";
            this.buffInfoLabel.Size = new System.Drawing.Size(187, 36);
            this.buffInfoLabel.TabIndex = 1;
            this.buffInfoLabel.Text = "Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CustomBufferSize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BufferSizeMode";
            // 
            // bufferModeCombo
            // 
            this.bufferModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bufferModeCombo.FormattingEnabled = true;
            this.bufferModeCombo.Items.AddRange(new object[] {
            "driver",
            "host",
            "custom"});
            this.bufferModeCombo.Location = new System.Drawing.Point(105, 26);
            this.bufferModeCombo.Name = "bufferModeCombo";
            this.bufferModeCombo.Size = new System.Drawing.Size(121, 21);
            this.bufferModeCombo.TabIndex = 0;
            this.bufferModeCombo.SelectedIndexChanged += new System.EventHandler(this.BufferModeCombo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OutputControl);
            this.groupBox3.Location = new System.Drawing.Point(324, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 204);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asio.Output";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Input0Control);
            this.groupBox4.Location = new System.Drawing.Point(12, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(295, 201);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Asio.Input.0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Input1Control);
            this.groupBox5.Location = new System.Drawing.Point(324, 222);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(295, 201);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Asio.Input.1";
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkButton.Location = new System.Drawing.Point(463, 429);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(544, 429);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // runRsButton
            // 
            this.runRsButton.Location = new System.Drawing.Point(12, 429);
            this.runRsButton.Name = "runRsButton";
            this.runRsButton.Size = new System.Drawing.Size(96, 23);
            this.runRsButton.TabIndex = 5;
            this.runRsButton.Text = "Run Rocksmith";
            this.runRsButton.UseVisualStyleBackColor = true;
            this.runRsButton.Click += new System.EventHandler(this.RunRsButton_Click);
            // 
            // Input1Control
            // 
            this.Input1Control.Location = new System.Drawing.Point(6, 19);
            this.Input1Control.Name = "Input1Control";
            this.Input1Control.Size = new System.Drawing.Size(285, 175);
            this.Input1Control.TabIndex = 0;
            this.Input1Control.Tag = "Asio.Input.1";
            // 
            // Input0Control
            // 
            this.Input0Control.Location = new System.Drawing.Point(4, 20);
            this.Input0Control.Name = "Input0Control";
            this.Input0Control.Size = new System.Drawing.Size(285, 175);
            this.Input0Control.TabIndex = 0;
            this.Input0Control.Tag = "Asio.Input.0";
            // 
            // OutputControl
            // 
            this.OutputControl.Location = new System.Drawing.Point(4, 19);
            this.OutputControl.Name = "OutputControl";
            this.OutputControl.Size = new System.Drawing.Size(285, 175);
            this.OutputControl.TabIndex = 0;
            this.OutputControl.Tag = "Asio.Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 460);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.runRsButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RS_ASIO_GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bufferSizeNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox asioCheck;
        private System.Windows.Forms.CheckBox wasapiCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown bufferSizeNumeric;
        private System.Windows.Forms.Label buffInfoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bufferModeCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private SettingControl OutputControl;
        private SettingControl Input0Control;
        private SettingControl Input1Control;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button runRsButton;
    }
}

