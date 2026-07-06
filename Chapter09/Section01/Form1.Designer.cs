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
            btGet1.Text = "取得";
            btGet1.UseVisualStyleBackColor = true;
            btGet1.Click += btGet1_Click;
            // 
            // tbOut
            // 
            tbOut.Location = new Point(71, 99);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(100, 23);
            tbOut.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 593);
            Controls.Add(tbOut);
            Controls.Add(btGet1);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btGet1;
        private TextBox tbOut;
    }
}
