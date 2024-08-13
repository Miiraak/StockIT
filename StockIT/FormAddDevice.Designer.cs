namespace StockIT
{
    partial class FormAddDevice
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
            checkBoxKaspersky = new CheckBox();
            textBoxSite = new TextBox();
            textBoxIP = new TextBox();
            textBoxWorkstation = new TextBox();
            textBoxOffice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ButtonOK = new Button();
            label5 = new Label();
            textBoxUsername = new TextBox();
            label6 = new Label();
            comboBoxMicrosoftSuite = new ComboBox();
            checkBoxNewTeams = new CheckBox();
            comboBoxOSVersion = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            textBoxModel = new TextBox();
            textBoxServiceTag = new TextBox();
            label9 = new Label();
            checkBoxPasswordAdmin = new CheckBox();
            checkBoxAdobeUpdate = new CheckBox();
            checkBoxChromeUpdate = new CheckBox();
            checkBoxWindowsUpdate = new CheckBox();
            checkBoxVDI = new CheckBox();
            panel1 = new Panel();
            label10 = new Label();
            textBoxETH = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxKaspersky
            // 
            checkBoxKaspersky.AutoSize = true;
            checkBoxKaspersky.Location = new Point(100, 305);
            checkBoxKaspersky.Name = "checkBoxKaspersky";
            checkBoxKaspersky.RightToLeft = RightToLeft.Yes;
            checkBoxKaspersky.Size = new Size(86, 19);
            checkBoxKaspersky.TabIndex = 0;
            checkBoxKaspersky.TabStop = false;
            checkBoxKaspersky.Text = "? Kaspersky";
            checkBoxKaspersky.UseVisualStyleBackColor = true;
            // 
            // textBoxSite
            // 
            textBoxSite.Location = new Point(12, 34);
            textBoxSite.Name = "textBoxSite";
            textBoxSite.Size = new Size(206, 23);
            textBoxSite.TabIndex = 1;
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(12, 250);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(330, 23);
            textBoxIP.TabIndex = 6;
            // 
            // textBoxWorkstation
            // 
            textBoxWorkstation.Location = new Point(12, 88);
            textBoxWorkstation.Name = "textBoxWorkstation";
            textBoxWorkstation.Size = new Size(327, 23);
            textBoxWorkstation.TabIndex = 3;
            // 
            // textBoxOffice
            // 
            textBoxOffice.Location = new Point(239, 34);
            textBoxOffice.Name = "textBoxOffice";
            textBoxOffice.Size = new Size(100, 23);
            textBoxOffice.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Site :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 16);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Office :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 7;
            label3.Text = "Workstation :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 232);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 8;
            label4.Text = "IP :";
            // 
            // ButtonOK
            // 
            ButtonOK.Cursor = Cursors.Cross;
            ButtonOK.Location = new Point(449, 398);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(93, 41);
            ButtonOK.TabIndex = 11;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 288);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 10;
            label5.Text = "Username :";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(12, 306);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(326, 23);
            textBoxUsername.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 393);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 12;
            label6.Text = "Suite Microsoft :";
            // 
            // comboBoxMicrosoftSuite
            // 
            comboBoxMicrosoftSuite.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMicrosoftSuite.FormattingEnabled = true;
            comboBoxMicrosoftSuite.Items.AddRange(new object[] { "---", "Office 365", "Office 2021", "Office 2019", "Office 2016" });
            comboBoxMicrosoftSuite.Location = new Point(12, 411);
            comboBoxMicrosoftSuite.Name = "comboBoxMicrosoftSuite";
            comboBoxMicrosoftSuite.Size = new Size(204, 23);
            comboBoxMicrosoftSuite.TabIndex = 9;
            // 
            // checkBoxNewTeams
            // 
            checkBoxNewTeams.AutoSize = true;
            checkBoxNewTeams.Location = new Point(93, 264);
            checkBoxNewTeams.Name = "checkBoxNewTeams";
            checkBoxNewTeams.RightToLeft = RightToLeft.Yes;
            checkBoxNewTeams.Size = new Size(93, 19);
            checkBoxNewTeams.TabIndex = 15;
            checkBoxNewTeams.TabStop = false;
            checkBoxNewTeams.Text = "? New teams";
            checkBoxNewTeams.UseVisualStyleBackColor = true;
            // 
            // comboBoxOSVersion
            // 
            comboBoxOSVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOSVersion.FormattingEnabled = true;
            comboBoxOSVersion.Items.AddRange(new object[] { "---", "ArchLinux", "Debian", "Fedora", "KDE neon", "MacOS 10", "MacOS 11", "MacOS 12", "MacOS 13", "MacOS 14", "MacOS 15", "Manjaro", "Raspberry Pi OS", "RedHat", "SUSE", "Ubuntu", "Windows 7", "Windows 8", "Windows 10", "Windows 11", "Windows Server 2008", "Windows Server 2012", "Windows Server 2019", "Windows Server 2022" });
            comboBoxOSVersion.Location = new Point(227, 411);
            comboBoxOSVersion.Name = "comboBoxOSVersion";
            comboBoxOSVersion.Size = new Size(204, 23);
            comboBoxOSVersion.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 393);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 16;
            label7.Text = "OS version :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 125);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 18;
            label8.Text = "Model :";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(12, 143);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(326, 23);
            textBoxModel.TabIndex = 4;
            // 
            // textBoxServiceTag
            // 
            textBoxServiceTag.Location = new Point(12, 197);
            textBoxServiceTag.Name = "textBoxServiceTag";
            textBoxServiceTag.Size = new Size(326, 23);
            textBoxServiceTag.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 179);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 20;
            label9.Text = "Service Tag :";
            // 
            // checkBoxPasswordAdmin
            // 
            checkBoxPasswordAdmin.AutoSize = true;
            checkBoxPasswordAdmin.Location = new Point(6, 54);
            checkBoxPasswordAdmin.Name = "checkBoxPasswordAdmin";
            checkBoxPasswordAdmin.RightToLeft = RightToLeft.Yes;
            checkBoxPasswordAdmin.Size = new Size(180, 19);
            checkBoxPasswordAdmin.TabIndex = 22;
            checkBoxPasswordAdmin.TabStop = false;
            checkBoxPasswordAdmin.Text = "? Password Admin up to date";
            checkBoxPasswordAdmin.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdobeUpdate
            // 
            checkBoxAdobeUpdate.AutoSize = true;
            checkBoxAdobeUpdate.Location = new Point(60, 223);
            checkBoxAdobeUpdate.Name = "checkBoxAdobeUpdate";
            checkBoxAdobeUpdate.RightToLeft = RightToLeft.Yes;
            checkBoxAdobeUpdate.Size = new Size(126, 19);
            checkBoxAdobeUpdate.TabIndex = 23;
            checkBoxAdobeUpdate.TabStop = false;
            checkBoxAdobeUpdate.Text = "? Adobe up to date";
            checkBoxAdobeUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxChromeUpdate
            // 
            checkBoxChromeUpdate.AutoSize = true;
            checkBoxChromeUpdate.Location = new Point(52, 185);
            checkBoxChromeUpdate.Name = "checkBoxChromeUpdate";
            checkBoxChromeUpdate.RightToLeft = RightToLeft.Yes;
            checkBoxChromeUpdate.Size = new Size(134, 19);
            checkBoxChromeUpdate.TabIndex = 24;
            checkBoxChromeUpdate.TabStop = false;
            checkBoxChromeUpdate.Text = "? Chrome up to date";
            checkBoxChromeUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxWindowsUpdate
            // 
            checkBoxWindowsUpdate.AutoSize = true;
            checkBoxWindowsUpdate.Location = new Point(46, 140);
            checkBoxWindowsUpdate.Name = "checkBoxWindowsUpdate";
            checkBoxWindowsUpdate.RightToLeft = RightToLeft.Yes;
            checkBoxWindowsUpdate.Size = new Size(140, 19);
            checkBoxWindowsUpdate.TabIndex = 25;
            checkBoxWindowsUpdate.TabStop = false;
            checkBoxWindowsUpdate.Text = "? Windows up to date";
            checkBoxWindowsUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxVDI
            // 
            checkBoxVDI.AutoSize = true;
            checkBoxVDI.Location = new Point(77, 98);
            checkBoxVDI.Name = "checkBoxVDI";
            checkBoxVDI.RightToLeft = RightToLeft.Yes;
            checkBoxVDI.Size = new Size(109, 19);
            checkBoxVDI.TabIndex = 26;
            checkBoxVDI.TabStop = false;
            checkBoxVDI.Text = "? VDI up to date";
            checkBoxVDI.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(checkBoxVDI);
            panel1.Controls.Add(checkBoxKaspersky);
            panel1.Controls.Add(checkBoxWindowsUpdate);
            panel1.Controls.Add(checkBoxNewTeams);
            panel1.Controls.Add(checkBoxChromeUpdate);
            panel1.Controls.Add(checkBoxPasswordAdmin);
            panel1.Controls.Add(checkBoxAdobeUpdate);
            panel1.Location = new Point(348, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 369);
            panel1.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 4);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 0;
            label10.Text = "Applications :";
            // 
            // textBoxETH
            // 
            textBoxETH.Location = new Point(12, 357);
            textBoxETH.Name = "textBoxETH";
            textBoxETH.Size = new Size(326, 23);
            textBoxETH.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 339);
            label11.Name = "label11";
            label11.Size = new Size(82, 15);
            label11.TabIndex = 28;
            label11.Text = "Ethernet port :";
            // 
            // FormAddDevice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(555, 450);
            Controls.Add(textBoxETH);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(textBoxServiceTag);
            Controls.Add(label9);
            Controls.Add(textBoxModel);
            Controls.Add(label8);
            Controls.Add(comboBoxOSVersion);
            Controls.Add(label7);
            Controls.Add(comboBoxMicrosoftSuite);
            Controls.Add(label6);
            Controls.Add(textBoxUsername);
            Controls.Add(label5);
            Controls.Add(ButtonOK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxOffice);
            Controls.Add(textBoxWorkstation);
            Controls.Add(textBoxIP);
            Controls.Add(textBoxSite);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddDevice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add a Device";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxKaspersky;
        private TextBox textBoxSite;
        private TextBox textBoxIP;
        private TextBox textBoxWorkstation;
        private TextBox textBoxOffice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ButtonOK;
        private Label label5;
        private TextBox textBoxUsername;
        private Label label6;
        private ComboBox comboBoxMicrosoftSuite;
        private CheckBox checkBoxNewTeams;
        private ComboBox comboBoxOSVersion;
        private Label label7;
        private Label label8;
        private TextBox textBoxModel;
        private TextBox textBoxServiceTag;
        private Label label9;
        private CheckBox checkBoxPasswordAdmin;
        private CheckBox checkBoxAdobeUpdate;
        private CheckBox checkBoxChromeUpdate;
        private CheckBox checkBoxWindowsUpdate;
        private CheckBox checkBoxVDI;
        private Panel panel1;
        private Label label10;
        private TextBox textBoxETH;
        private Label label11;
    }
}