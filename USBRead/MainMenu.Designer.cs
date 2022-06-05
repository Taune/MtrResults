namespace Brikkesjekk
{
    partial class MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.UsbPort_listBox = new System.Windows.Forms.ListBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Clock_lbl = new System.Windows.Forms.Label();
            this.SearchCard_btn = new System.Windows.Forms.Button();
            this.SearchCard_Txtbox = new System.Windows.Forms.TextBox();
            this.UsbRead_listBox = new System.Windows.Forms.ListBox();
            this.Ecard_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RefreshUsbPort_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.MtrTotalGridview = new System.Windows.Forms.DataGridView();
            this.folderLogfile_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStartMTR = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GetFolderButton = new System.Windows.Forms.Button();
            this.EcardGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MTR_read_led = new Brikkesjekk.LedBulb();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MtrTotalGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EcardGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsbPort_listBox
            // 
            this.UsbPort_listBox.BackColor = System.Drawing.SystemColors.Window;
            this.UsbPort_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsbPort_listBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbPort_listBox.FormattingEnabled = true;
            this.UsbPort_listBox.ItemHeight = 23;
            this.UsbPort_listBox.Location = new System.Drawing.Point(16, 22);
            this.UsbPort_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbPort_listBox.Name = "UsbPort_listBox";
            this.UsbPort_listBox.Size = new System.Drawing.Size(143, 115);
            this.UsbPort_listBox.Sorted = true;
            this.UsbPort_listBox.TabIndex = 2;
            this.UsbPort_listBox.SelectedIndexChanged += new System.EventHandler(this.UsbPort_listBox_SelectedIndexChanged);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(15, 10);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(213, 39);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "AVSLUTT PROGRAM";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Clock_lbl
            // 
            this.Clock_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clock_lbl.AutoSize = true;
            this.Clock_lbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Clock_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Clock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_lbl.ForeColor = System.Drawing.Color.White;
            this.Clock_lbl.Location = new System.Drawing.Point(1604, 18);
            this.Clock_lbl.Name = "Clock_lbl";
            this.Clock_lbl.Size = new System.Drawing.Size(129, 34);
            this.Clock_lbl.TabIndex = 9;
            this.Clock_lbl.Text = "00:00:00";
            // 
            // SearchCard_btn
            // 
            this.SearchCard_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchCard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchCard_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_btn.ForeColor = System.Drawing.Color.White;
            this.SearchCard_btn.Location = new System.Drawing.Point(270, 12);
            this.SearchCard_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCard_btn.Name = "SearchCard_btn";
            this.SearchCard_btn.Size = new System.Drawing.Size(231, 39);
            this.SearchCard_btn.TabIndex = 12;
            this.SearchCard_btn.Text = "SØK BRIKKE MANUELT";
            this.SearchCard_btn.UseVisualStyleBackColor = false;
            this.SearchCard_btn.Click += new System.EventHandler(this.SearchCard_btn_Click);
            // 
            // SearchCard_Txtbox
            // 
            this.SearchCard_Txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchCard_Txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchCard_Txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_Txtbox.Location = new System.Drawing.Point(507, 17);
            this.SearchCard_Txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCard_Txtbox.Name = "SearchCard_Txtbox";
            this.SearchCard_Txtbox.Size = new System.Drawing.Size(153, 30);
            this.SearchCard_Txtbox.TabIndex = 13;
            this.SearchCard_Txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchCard_Txtbox_KeyPress);
            // 
            // UsbRead_listBox
            // 
            this.UsbRead_listBox.BackColor = System.Drawing.SystemColors.Info;
            this.UsbRead_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsbRead_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbRead_listBox.FormattingEnabled = true;
            this.UsbRead_listBox.ItemHeight = 18;
            this.UsbRead_listBox.Location = new System.Drawing.Point(12, 423);
            this.UsbRead_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbRead_listBox.Name = "UsbRead_listBox";
            this.UsbRead_listBox.Size = new System.Drawing.Size(228, 306);
            this.UsbRead_listBox.TabIndex = 25;
            // 
            // Ecard_box
            // 
            this.Ecard_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ecard_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ecard_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard_box.Location = new System.Drawing.Point(1151, 122);
            this.Ecard_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ecard_box.Name = "Ecard_box";
            this.Ecard_box.ReadOnly = true;
            this.Ecard_box.Size = new System.Drawing.Size(219, 38);
            this.Ecard_box.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(799, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Resultat sist leste brikke";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UsbPort_listBox);
            this.groupBox2.Controls.Add(this.RefreshUsbPort_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(172, 194);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velg Port";
            // 
            // RefreshUsbPort_btn
            // 
            this.RefreshUsbPort_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.RefreshUsbPort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshUsbPort_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshUsbPort_btn.ForeColor = System.Drawing.Color.White;
            this.RefreshUsbPort_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshUsbPort_btn.Location = new System.Drawing.Point(16, 145);
            this.RefreshUsbPort_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshUsbPort_btn.Name = "RefreshUsbPort_btn";
            this.RefreshUsbPort_btn.Size = new System.Drawing.Size(141, 43);
            this.RefreshUsbPort_btn.TabIndex = 3;
            this.RefreshUsbPort_btn.Text = "OPPFRISK";
            this.RefreshUsbPort_btn.UseVisualStyleBackColor = false;
            this.RefreshUsbPort_btn.Click += new System.EventHandler(this.RefreshUsbPort_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Stopp kommunikasjon før Avslutt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1114, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 64);
            this.textBox1.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(976, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MtrTotalGridview
            // 
            this.MtrTotalGridview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MtrTotalGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MtrTotalGridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.MtrTotalGridview.Location = new System.Drawing.Point(270, 173);
            this.MtrTotalGridview.Name = "MtrTotalGridview";
            this.MtrTotalGridview.RowHeadersWidth = 51;
            this.MtrTotalGridview.RowTemplate.Height = 24;
            this.MtrTotalGridview.Size = new System.Drawing.Size(482, 559);
            this.MtrTotalGridview.TabIndex = 36;
            // 
            // folderLogfile_box
            // 
            this.folderLogfile_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderLogfile_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderLogfile_box.Location = new System.Drawing.Point(175, 801);
            this.folderLogfile_box.Margin = new System.Windows.Forms.Padding(5, 2, 3, 2);
            this.folderLogfile_box.Name = "folderLogfile_box";
            this.folderLogfile_box.Size = new System.Drawing.Size(245, 27);
            this.folderLogfile_box.TabIndex = 42;
            this.folderLogfile_box.Leave += new System.EventHandler(this.folderLogfile_box_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 800);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Katalog for log-fil";
            // 
            // btnStartMTR
            // 
            this.btnStartMTR.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStartMTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMTR.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMTR.ForeColor = System.Drawing.Color.White;
            this.btnStartMTR.Location = new System.Drawing.Point(35, 347);
            this.btnStartMTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartMTR.Name = "btnStartMTR";
            this.btnStartMTR.Size = new System.Drawing.Size(132, 39);
            this.btnStartMTR.TabIndex = 44;
            this.btnStartMTR.Text = "START MTR";
            this.btnStartMTR.UseVisualStyleBackColor = false;
            this.btnStartMTR.Click += new System.EventHandler(this.btnReadMTR_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.SystemColors.Highlight;
            this.version.Location = new System.Drawing.Point(497, 807);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(106, 17);
            this.version.TabIndex = 52;
            this.version.Text = "Ver 26.12.2021";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(713, 940);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(841, 10);
            this.progressBar1.TabIndex = 53;
            // 
            // GetFolderButton
            // 
            this.GetFolderButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.GetFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetFolderButton.ForeColor = System.Drawing.Color.White;
            this.GetFolderButton.Location = new System.Drawing.Point(439, 794);
            this.GetFolderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetFolderButton.Name = "GetFolderButton";
            this.GetFolderButton.Size = new System.Drawing.Size(53, 39);
            this.GetFolderButton.TabIndex = 54;
            this.GetFolderButton.Text = "...";
            this.GetFolderButton.UseVisualStyleBackColor = false;
            this.GetFolderButton.Click += new System.EventHandler(this.GetFolderButton_Click);
            // 
            // EcardGridView
            // 
            this.EcardGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.EcardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EcardGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.EcardGridView.Location = new System.Drawing.Point(800, 173);
            this.EcardGridView.Name = "EcardGridView";
            this.EcardGridView.RowHeadersWidth = 51;
            this.EcardGridView.RowTemplate.Height = 24;
            this.EcardGridView.Size = new System.Drawing.Size(634, 559);
            this.EcardGridView.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 32);
            this.label2.TabIndex = 64;
            this.label2.Text = "Resultat alle brikker";
            // 
            // MTR_read_led
            // 
            this.MTR_read_led.Color = System.Drawing.Color.Red;
            this.MTR_read_led.Location = new System.Drawing.Point(172, 349);
            this.MTR_read_led.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MTR_read_led.Name = "MTR_read_led";
            this.MTR_read_led.On = true;
            this.MTR_read_led.Size = new System.Drawing.Size(35, 34);
            this.MTR_read_led.TabIndex = 58;
            this.MTR_read_led.Text = "ledBulb1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1504, 846);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EcardGridView);
            this.Controls.Add(this.Ecard_box);
            this.Controls.Add(this.MtrTotalGridview);
            this.Controls.Add(this.MTR_read_led);
            this.Controls.Add(this.GetFolderButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.version);
            this.Controls.Add(this.btnStartMTR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.folderLogfile_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.UsbRead_listBox);
            this.Controls.Add(this.SearchCard_Txtbox);
            this.Controls.Add(this.SearchCard_btn);
            this.Controls.Add(this.Clock_lbl);
            this.Controls.Add(this.Close_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Brikkesjekk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MtrTotalGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EcardGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox UsbPort_listBox;
        private System.Windows.Forms.Button RefreshUsbPort_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label Clock_lbl;
        private System.Windows.Forms.Button SearchCard_btn;
        private System.Windows.Forms.ListBox UsbRead_listBox;
        private System.Windows.Forms.TextBox Ecard_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderLogfile_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStartMTR;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button GetFolderButton;
        public System.Windows.Forms.TextBox SearchCard_Txtbox;
        private LedBulb MTR_read_led;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView MtrTotalGridview;
        private System.Windows.Forms.DataGridView EcardGridView;
        private System.Windows.Forms.Label label2;
    }
}

