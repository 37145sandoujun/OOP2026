namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rbToyota = new RadioButton();
            groupBox1 = new GroupBox();
            rbImport = new RadioButton();
            rbHonda = new RadioButton();
            rbOther = new RadioButton();
            rbSubaru = new RadioButton();
            rbNissan = new RadioButton();
            dtpDate = new DateTimePicker();
            cbAuthor = new ComboBox();
            dgvRecords = new DataGridView();
            label4 = new Label();
            cbCarName = new ComboBox();
            label5 = new Label();
            btNewInput = new Button();
            label6 = new Label();
            btOpenPicture = new Button();
            btDeletePicture = new Button();
            pbPicture = new PictureBox();
            btAddRecord = new Button();
            btDeleteRecord = new Button();
            btModifyRecode = new Button();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            終了ToolStripMenuItem1 = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            tbReport = new TextBox();
            statusStrip1 = new StatusStrip();
            tsslb = new ToolStripStatusLabel();
            tsslbMassage = new ToolStripStatusLabel();
            ofdPicFileOpen = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(58, 47);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(37, 102);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 1;
            label2.Text = "記録者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(42, 156);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 2;
            label3.Text = "メーカー";
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 17);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 3;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(142, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 53);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(281, 17);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(49, 19);
            rbImport.TabIndex = 6;
            rbImport.TabStop = true;
            rbImport.Text = "外車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(212, 17);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 5;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(336, 17);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 5;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(142, 17);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 5;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(74, 17);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 4;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(142, 47);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(287, 33);
            dtpDate.TabIndex = 5;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(148, 102);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(281, 29);
            cbAuthor.TabIndex = 6;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(141, 495);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(912, 229);
            dgvRecords.TabIndex = 7;
            dgvRecords.Click += dgvRecords_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(58, 239);
            label4.Name = "label4";
            label4.Size = new Size(55, 30);
            label4.TabIndex = 2;
            label4.Text = "車名";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(148, 239);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(281, 29);
            cbCarName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(39, 302);
            label5.Name = "label5";
            label5.Size = new Size(74, 30);
            label5.TabIndex = 2;
            label5.Text = "レポート";
            // 
            // btNewInput
            // 
            btNewInput.BackColor = SystemColors.ActiveCaption;
            btNewInput.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btNewInput.Location = new Point(455, 36);
            btNewInput.Name = "btNewInput";
            btNewInput.Size = new Size(111, 60);
            btNewInput.TabIndex = 8;
            btNewInput.Text = "新規入力";
            btNewInput.UseVisualStyleBackColor = false;
            btNewInput.Click += btNewInput_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(677, 57);
            label6.Name = "label6";
            label6.Size = new Size(55, 30);
            label6.TabIndex = 0;
            label6.Text = "画像";
            // 
            // btOpenPicture
            // 
            btOpenPicture.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btOpenPicture.Location = new Point(787, 45);
            btOpenPicture.Name = "btOpenPicture";
            btOpenPicture.Size = new Size(123, 59);
            btOpenPicture.TabIndex = 9;
            btOpenPicture.Text = "開く...";
            btOpenPicture.UseVisualStyleBackColor = true;
            btOpenPicture.Click += btOpenPicture_Click;
            // 
            // btDeletePicture
            // 
            btDeletePicture.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeletePicture.Location = new Point(940, 45);
            btDeletePicture.Name = "btDeletePicture";
            btDeletePicture.Size = new Size(113, 63);
            btDeletePicture.TabIndex = 10;
            btDeletePicture.Text = "削除";
            btDeletePicture.UseVisualStyleBackColor = true;
            btDeletePicture.Click += btDeletePicture_Click;
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(641, 133);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(412, 260);
            pbPicture.TabIndex = 11;
            pbPicture.TabStop = false;
            // 
            // btAddRecord
            // 
            btAddRecord.BackColor = Color.IndianRed;
            btAddRecord.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddRecord.Location = new Point(641, 399);
            btAddRecord.Name = "btAddRecord";
            btAddRecord.Size = new Size(123, 59);
            btAddRecord.TabIndex = 9;
            btAddRecord.Text = "追加";
            btAddRecord.UseVisualStyleBackColor = false;
            btAddRecord.Click += btAddRecord_Click;
            // 
            // btDeleteRecord
            // 
            btDeleteRecord.BackColor = Color.FromArgb(255, 255, 128);
            btDeleteRecord.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteRecord.Location = new Point(930, 399);
            btDeleteRecord.Name = "btDeleteRecord";
            btDeleteRecord.Size = new Size(123, 59);
            btDeleteRecord.TabIndex = 9;
            btDeleteRecord.Text = "削除";
            btDeleteRecord.UseVisualStyleBackColor = false;
            btDeleteRecord.Click += btDeleteRecord_Click;
            // 
            // btModifyRecode
            // 
            btModifyRecode.BackColor = Color.DarkOrange;
            btModifyRecode.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btModifyRecode.Location = new Point(787, 399);
            btModifyRecode.Name = "btModifyRecode";
            btModifyRecode.Size = new Size(123, 59);
            btModifyRecode.TabIndex = 9;
            btModifyRecode.Text = "修正";
            btModifyRecode.UseVisualStyleBackColor = false;
            btModifyRecode.Click += btModifyRecode_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(58, 495);
            label7.Name = "label7";
            label7.Size = new Size(55, 30);
            label7.TabIndex = 2;
            label7.Text = "一覧";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1148, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 保存ToolStripMenuItem, 色設定ToolStripMenuItem, toolStripSeparator1, 終了ToolStripMenuItem, toolStripSeparator2, 終了ToolStripMenuItem1 });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(83, 20);
            ファイルFToolStripMenuItem.Text = "ファイル（&F）";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(175, 22);
            保存ToolStripMenuItem.Text = "開く...";
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(175, 22);
            色設定ToolStripMenuItem.Text = "保存...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(172, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(175, 22);
            終了ToolStripMenuItem.Text = "色設定...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(172, 6);
            // 
            // 終了ToolStripMenuItem1
            // 
            終了ToolStripMenuItem1.Name = "終了ToolStripMenuItem1";
            終了ToolStripMenuItem1.Size = new Size(175, 22);
            終了ToolStripMenuItem1.Text = "終了(&X)         Alt+F4";
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(155, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて";
            // 
            // tbReport
            // 
            tbReport.Location = new Point(141, 302);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(448, 179);
            tbReport.TabIndex = 13;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslb, tsslbMassage });
            statusStrip1.Location = new Point(0, 714);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1148, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 14;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslb
            // 
            tsslb.Name = "tsslb";
            tsslb.Size = new Size(0, 17);
            // 
            // tsslbMassage
            // 
            tsslbMassage.Name = "tsslbMassage";
            tsslbMassage.Size = new Size(77, 17);
            tsslbMassage.Text = "tsslbMessage";
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 736);
            Controls.Add(statusStrip1);
            Controls.Add(tbReport);
            Controls.Add(pbPicture);
            Controls.Add(btDeletePicture);
            Controls.Add(btModifyRecode);
            Controls.Add(btDeleteRecord);
            Controls.Add(btAddRecord);
            Controls.Add(btOpenPicture);
            Controls.Add(btNewInput);
            Controls.Add(dgvRecords);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(dtpDate);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "Form1";
            Text = "X";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rbToyota;
        private GroupBox groupBox1;
        private RadioButton rbSubaru;
        private RadioButton rbNissan;
        private RadioButton rbImport;
        private DateTimePicker dtpDate;
        private ComboBox cbAuthor;
        private DataGridView dgvRecords;
        private Label label4;
        private ComboBox cbCarName;
        private Label label5;
        private Button btNewInput;
        private Label label6;
        private Button btOpenPicture;
        private Button btDeletePicture;
        private PictureBox pbPicture;
        private Button btAddRecord;
        private Button btDeleteRecord;
        private Button btModifyRecode;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 終了ToolStripMenuItem1;
        private TextBox tbReport;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private RadioButton rbHonda;
        private RadioButton rbOther;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslb;
        private ToolStripStatusLabel tsslbMassage;
        private OpenFileDialog ofdPicFileOpen;
    }
}
