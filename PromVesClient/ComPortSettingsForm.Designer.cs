namespace PromVesClient
{
    partial class ComPortSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComPortSettingsForm));
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbHandshake = new ComboBox();
            cbStopBits = new ComboBox();
            cbParity = new ComboBox();
            cbDataBits = new ComboBox();
            cbBaudRate = new ComboBox();
            cbPortName = new ComboBox();
            btnSave = new Button();
            btnRestoreDefaults = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbHandshake);
            groupBox1.Controls.Add(cbStopBits);
            groupBox1.Controls.Add(cbParity);
            groupBox1.Controls.Add(cbDataBits);
            groupBox1.Controls.Add(cbBaudRate);
            groupBox1.Controls.Add(cbPortName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "COM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 182);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 17;
            label6.Text = "Handshake";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 153);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 16;
            label5.Text = "StopBits";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 121);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 15;
            label4.Text = "Parity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 95);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 14;
            label3.Text = "DataBits";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 66);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 13;
            label2.Text = "BaudRate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 37);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 12;
            label1.Text = "Port";
            // 
            // cbHandshake
            // 
            cbHandshake.FormattingEnabled = true;
            cbHandshake.Location = new Point(92, 179);
            cbHandshake.Name = "cbHandshake";
            cbHandshake.Size = new Size(135, 23);
            cbHandshake.TabIndex = 5;
            // 
            // cbStopBits
            // 
            cbStopBits.FormattingEnabled = true;
            cbStopBits.Location = new Point(92, 150);
            cbStopBits.Name = "cbStopBits";
            cbStopBits.Size = new Size(135, 23);
            cbStopBits.TabIndex = 4;
            // 
            // cbParity
            // 
            cbParity.FormattingEnabled = true;
            cbParity.Location = new Point(92, 121);
            cbParity.Name = "cbParity";
            cbParity.Size = new Size(135, 23);
            cbParity.TabIndex = 3;
            // 
            // cbDataBits
            // 
            cbDataBits.FormattingEnabled = true;
            cbDataBits.Location = new Point(92, 92);
            cbDataBits.Name = "cbDataBits";
            cbDataBits.Size = new Size(135, 23);
            cbDataBits.TabIndex = 2;
            // 
            // cbBaudRate
            // 
            cbBaudRate.FormattingEnabled = true;
            cbBaudRate.Location = new Point(92, 63);
            cbBaudRate.Name = "cbBaudRate";
            cbBaudRate.Size = new Size(135, 23);
            cbBaudRate.TabIndex = 1;
            // 
            // cbPortName
            // 
            cbPortName.FormattingEnabled = true;
            cbPortName.Location = new Point(92, 34);
            cbPortName.Name = "cbPortName";
            cbPortName.Size = new Size(135, 23);
            cbPortName.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(293, 66);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 39);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRestoreDefaults
            // 
            btnRestoreDefaults.Location = new Point(293, 153);
            btnRestoreDefaults.Name = "btnRestoreDefaults";
            btnRestoreDefaults.Size = new Size(146, 39);
            btnRestoreDefaults.TabIndex = 5;
            btnRestoreDefaults.Text = "По умолчанию";
            btnRestoreDefaults.UseVisualStyleBackColor = true;
            btnRestoreDefaults.Click += btnRestoreDefaults_Click;
            // 
            // ComPortSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 275);
            Controls.Add(btnRestoreDefaults);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ComPortSettingsForm";
            Text = "Настройка COM портов";
            Load += ComPortSettingsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbHandshake;
        private ComboBox cbStopBits;
        private ComboBox cbParity;
        private ComboBox cbDataBits;
        private ComboBox cbBaudRate;
        private ComboBox cbPortName;
        private Button btnSave;
        private Button btnRestoreDefaults;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}