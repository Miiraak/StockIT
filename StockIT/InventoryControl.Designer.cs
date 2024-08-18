namespace StockIT
{
    partial class InventoryControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ButtonCables = new Button();
            ButtonPeripherals = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(ButtonCables, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonPeripherals, 2, 1);
            tableLayoutPanel1.Controls.Add(button2, 3, 1);
            tableLayoutPanel1.Controls.Add(button3, 1, 2);
            tableLayoutPanel1.Controls.Add(button4, 2, 2);
            tableLayoutPanel1.Controls.Add(button5, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Size = new Size(902, 394);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ButtonCables
            // 
            ButtonCables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonCables.FlatAppearance.BorderSize = 0;
            ButtonCables.FlatStyle = FlatStyle.Flat;
            ButtonCables.Image = Properties.Resources.icons8_network_cable_96;
            ButtonCables.Location = new Point(13, 13);
            ButtonCables.Name = "ButtonCables";
            ButtonCables.Size = new Size(287, 181);
            ButtonCables.TabIndex = 0;
            ButtonCables.UseVisualStyleBackColor = true;
            // 
            // ButtonPeripherals
            // 
            ButtonPeripherals.Dock = DockStyle.Fill;
            ButtonPeripherals.FlatAppearance.BorderSize = 0;
            ButtonPeripherals.FlatStyle = FlatStyle.Flat;
            ButtonPeripherals.Image = Properties.Resources.icons8_keyboard_96;
            ButtonPeripherals.Location = new Point(306, 13);
            ButtonPeripherals.Name = "ButtonPeripherals";
            ButtonPeripherals.Size = new Size(288, 181);
            ButtonPeripherals.TabIndex = 1;
            ButtonPeripherals.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.icons8_nas_96;
            button2.Location = new Point(600, 13);
            button2.Name = "button2";
            button2.Size = new Size(288, 181);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.icons8_start_96;
            button3.Location = new Point(13, 200);
            button3.Name = "button3";
            button3.Size = new Size(287, 181);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.icons8_cd_collection_96;
            button4.Location = new Point(306, 200);
            button4.Name = "button4";
            button4.Size = new Size(288, 181);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.icons8_more_96;
            button5.Location = new Point(600, 200);
            button5.Name = "button5";
            button5.Size = new Size(288, 181);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "InventoryControl";
            Size = new Size(902, 394);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button ButtonCables;
        private Button ButtonPeripherals;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
