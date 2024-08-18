namespace StockIT
{
    partial class DeviceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewDevice = new DataGridView();
            DeviceSite = new DataGridViewTextBoxColumn();
            DeviceRoom = new DataGridViewTextBoxColumn();
            DeviceName = new DataGridViewTextBoxColumn();
            DeviceModel = new DataGridViewTextBoxColumn();
            DeviceServiceTag = new DataGridViewTextBoxColumn();
            DeviceIP = new DataGridViewTextBoxColumn();
            DeviceETH = new DataGridViewTextBoxColumn();
            DeviceUsername = new DataGridViewTextBoxColumn();
            DeviceOfficeSuite = new DataGridViewTextBoxColumn();
            DeviceOS = new DataGridViewTextBoxColumn();
            DeviceAdmin = new DataGridViewCheckBoxColumn();
            DeviceVDI = new DataGridViewCheckBoxColumn();
            DeviceWinUpdate = new DataGridViewCheckBoxColumn();
            DeviceChrome = new DataGridViewCheckBoxColumn();
            DeviceAdobe = new DataGridViewCheckBoxColumn();
            DeviceTeams = new DataGridViewCheckBoxColumn();
            DeviceAV = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevice).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDevice
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDevice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDevice.Columns.AddRange(new DataGridViewColumn[] { DeviceSite, DeviceRoom, DeviceName, DeviceModel, DeviceServiceTag, DeviceIP, DeviceETH, DeviceUsername, DeviceOfficeSuite, DeviceOS, DeviceAdmin, DeviceVDI, DeviceWinUpdate, DeviceChrome, DeviceAdobe, DeviceTeams, DeviceAV });
            dataGridViewDevice.Dock = DockStyle.Fill;
            dataGridViewDevice.Location = new Point(0, 0);
            dataGridViewDevice.Name = "dataGridViewDevice";
            dataGridViewDevice.Size = new Size(902, 394);
            dataGridViewDevice.TabIndex = 0;
            dataGridViewDevice.CellValueChanged += dataGridViewDevice_CellValueChanged;
            dataGridViewDevice.RowsAdded += dataGridViewDevice_RowsAdded;
            dataGridViewDevice.RowsRemoved += dataGridViewDevice_RowsRemoved;
            // 
            // DeviceSite
            // 
            DeviceSite.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceSite.FillWeight = 20F;
            DeviceSite.HeaderText = "Site";
            DeviceSite.MinimumWidth = 100;
            DeviceSite.Name = "DeviceSite";
            // 
            // DeviceRoom
            // 
            DeviceRoom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceRoom.FillWeight = 10F;
            DeviceRoom.HeaderText = "Room";
            DeviceRoom.MinimumWidth = 50;
            DeviceRoom.Name = "DeviceRoom";
            // 
            // DeviceName
            // 
            DeviceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceName.FillWeight = 20F;
            DeviceName.HeaderText = "Workstation";
            DeviceName.MinimumWidth = 120;
            DeviceName.Name = "DeviceName";
            // 
            // DeviceModel
            // 
            DeviceModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceModel.FillWeight = 40F;
            DeviceModel.HeaderText = "Model";
            DeviceModel.MinimumWidth = 150;
            DeviceModel.Name = "DeviceModel";
            // 
            // DeviceServiceTag
            // 
            DeviceServiceTag.HeaderText = "Service Tag";
            DeviceServiceTag.MinimumWidth = 100;
            DeviceServiceTag.Name = "DeviceServiceTag";
            // 
            // DeviceIP
            // 
            DeviceIP.HeaderText = "IP";
            DeviceIP.MinimumWidth = 100;
            DeviceIP.Name = "DeviceIP";
            // 
            // DeviceETH
            // 
            DeviceETH.HeaderText = "ETH";
            DeviceETH.MinimumWidth = 70;
            DeviceETH.Name = "DeviceETH";
            DeviceETH.Width = 70;
            // 
            // DeviceUsername
            // 
            DeviceUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DeviceUsername.HeaderText = "Username";
            DeviceUsername.MinimumWidth = 100;
            DeviceUsername.Name = "DeviceUsername";
            // 
            // DeviceOfficeSuite
            // 
            DeviceOfficeSuite.HeaderText = "Office suite";
            DeviceOfficeSuite.MinimumWidth = 100;
            DeviceOfficeSuite.Name = "DeviceOfficeSuite";
            DeviceOfficeSuite.Resizable = DataGridViewTriState.True;
            DeviceOfficeSuite.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DeviceOS
            // 
            DeviceOS.HeaderText = "OS";
            DeviceOS.MinimumWidth = 120;
            DeviceOS.Name = "DeviceOS";
            DeviceOS.Resizable = DataGridViewTriState.True;
            DeviceOS.SortMode = DataGridViewColumnSortMode.NotSortable;
            DeviceOS.Width = 120;
            // 
            // DeviceAdmin
            // 
            DeviceAdmin.HeaderText = "Admin ?";
            DeviceAdmin.MinimumWidth = 70;
            DeviceAdmin.Name = "DeviceAdmin";
            DeviceAdmin.Width = 70;
            // 
            // DeviceVDI
            // 
            DeviceVDI.HeaderText = "VDI ?";
            DeviceVDI.MinimumWidth = 70;
            DeviceVDI.Name = "DeviceVDI";
            DeviceVDI.Width = 70;
            // 
            // DeviceWinUpdate
            // 
            DeviceWinUpdate.HeaderText = "Update ?";
            DeviceWinUpdate.MinimumWidth = 70;
            DeviceWinUpdate.Name = "DeviceWinUpdate";
            DeviceWinUpdate.Width = 70;
            // 
            // DeviceChrome
            // 
            DeviceChrome.HeaderText = "Chrome ?";
            DeviceChrome.MinimumWidth = 70;
            DeviceChrome.Name = "DeviceChrome";
            DeviceChrome.Resizable = DataGridViewTriState.True;
            DeviceChrome.SortMode = DataGridViewColumnSortMode.Automatic;
            DeviceChrome.Width = 70;
            // 
            // DeviceAdobe
            // 
            DeviceAdobe.HeaderText = "Adobe ?";
            DeviceAdobe.MinimumWidth = 70;
            DeviceAdobe.Name = "DeviceAdobe";
            DeviceAdobe.Width = 70;
            // 
            // DeviceTeams
            // 
            DeviceTeams.HeaderText = "Teams ?";
            DeviceTeams.MinimumWidth = 70;
            DeviceTeams.Name = "DeviceTeams";
            DeviceTeams.Width = 70;
            // 
            // DeviceAV
            // 
            DeviceAV.HeaderText = "Antivirus ?";
            DeviceAV.MinimumWidth = 75;
            DeviceAV.Name = "DeviceAV";
            DeviceAV.Width = 75;
            // 
            // DeviceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewDevice);
            Name = "DeviceControl";
            Size = new Size(902, 394);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevice).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewDevice;
        private DataGridViewTextBoxColumn DeviceSite;
        private DataGridViewTextBoxColumn DeviceRoom;
        private DataGridViewTextBoxColumn DeviceName;
        private DataGridViewTextBoxColumn DeviceModel;
        private DataGridViewTextBoxColumn DeviceServiceTag;
        private DataGridViewTextBoxColumn DeviceIP;
        private DataGridViewTextBoxColumn DeviceETH;
        private DataGridViewTextBoxColumn DeviceUsername;
        private DataGridViewTextBoxColumn DeviceOfficeSuite;
        private DataGridViewTextBoxColumn DeviceOS;
        private DataGridViewCheckBoxColumn DeviceAdmin;
        private DataGridViewCheckBoxColumn DeviceVDI;
        private DataGridViewCheckBoxColumn DeviceWinUpdate;
        private DataGridViewCheckBoxColumn DeviceChrome;
        private DataGridViewCheckBoxColumn DeviceAdobe;
        private DataGridViewCheckBoxColumn DeviceTeams;
        private DataGridViewCheckBoxColumn DeviceAV;
    }
}
