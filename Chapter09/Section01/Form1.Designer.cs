namespace Section01
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
            dtpDate = new DateTimePicker();
            btGet1 = new Button();
            tbOut = new TextBox();
            label1 = new Label();
            numDay = new NumericUpDown();
            btBirthCalc = new Button();
            dtpDate2 = new DateTimePicker();
            label2 = new Label();
            tbOut3 = new TextBox();
            tbOut2 = new TextBox();
            tbOut4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numDay).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(21, 27);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 36);
            dtpDate.TabIndex = 0;
            // 
            // btGet1
            // 
            btGet1.Location = new Point(245, 39);
            btGet1.Name = "btGet1";
            btGet1.Size = new Size(75, 23);
            btGet1.TabIndex = 1;
            btGet1.Text = "計算";
            btGet1.UseVisualStyleBackColor = true;
            btGet1.Click += btGet1_Click;
            // 
            // tbOut
            // 
            tbOut.Location = new Point(368, 39);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(100, 23);
            tbOut.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(286, 170);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 3;
            label1.Text = "日後";
            // 
            // numDay
            // 
            numDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numDay.Location = new Point(160, 162);
            numDay.Name = "numDay";
            numDay.Size = new Size(120, 39);
            numDay.TabIndex = 4;
            // 
            // btBirthCalc
            // 
            btBirthCalc.Location = new Point(245, 97);
            btBirthCalc.Name = "btBirthCalc";
            btBirthCalc.Size = new Size(75, 23);
            btBirthCalc.TabIndex = 5;
            btBirthCalc.Text = "計算";
            btBirthCalc.UseVisualStyleBackColor = true;
            btBirthCalc.Click += btBirthCalc_Click;
            // 
            // dtpDate2
            // 
            dtpDate2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate2.Location = new Point(21, 97);
            dtpDate2.Name = "dtpDate2";
            dtpDate2.Size = new Size(200, 36);
            dtpDate2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 78);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 6;
            label2.Text = "生年月日";
            // 
            // tbOut3
            // 
            tbOut3.Location = new Point(513, 98);
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(100, 23);
            tbOut3.TabIndex = 7;
            // 
            // tbOut2
            // 
            tbOut2.Location = new Point(368, 98);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(100, 23);
            tbOut2.TabIndex = 8;
            // 
            // tbOut4
            // 
            tbOut4.Location = new Point(675, 97);
            tbOut4.Multiline = true;
            tbOut4.Name = "tbOut4";
            tbOut4.Size = new Size(274, 86);
            tbOut4.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 593);
            Controls.Add(tbOut2);
            Controls.Add(tbOut4);
            Controls.Add(tbOut3);
            Controls.Add(label2);
            Controls.Add(btBirthCalc);
            Controls.Add(numDay);
            Controls.Add(label1);
            Controls.Add(tbOut);
            Controls.Add(dtpDate2);
            Controls.Add(btGet1);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btGet1;
        private TextBox tbOut;
        private Label label1;
        private NumericUpDown numDay;
        private Button btBirthCalc;
        private DateTimePicker dtpDate2;
        private Label label2;
        private TextBox tbOut3;
        private TextBox tbOut2;
        private TextBox tbOut4;
    }
}
