namespace Exercise01
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
            components = new System.ComponentModel.Container();
            btButton1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tbOut1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tbOut2 = new TextBox();
            button3 = new Button();
            tbOut3 = new TextBox();
            SuspendLayout();
            // 
            // btButton1
            // 
            btButton1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btButton1.Location = new Point(48, 36);
            btButton1.Name = "btButton1";
            btButton1.Size = new Size(266, 49);
            btButton1.TabIndex = 0;
            btButton1.Text = "①";
            btButton1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tbOut1
            // 
            tbOut1.Location = new Point(430, 62);
            tbOut1.Name = "tbOut1";
            tbOut1.Size = new Size(290, 23);
            tbOut1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(48, 36);
            button1.Name = "button1";
            button1.Size = new Size(266, 49);
            button1.TabIndex = 0;
            button1.Text = "①";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button2.Location = new Point(48, 138);
            button2.Name = "button2";
            button2.Size = new Size(266, 49);
            button2.TabIndex = 0;
            button2.Text = "②";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbOut2
            // 
            tbOut2.Location = new Point(430, 164);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(290, 23);
            tbOut2.TabIndex = 2;
            // 
            // button3
            // 
            button3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button3.Location = new Point(48, 239);
            button3.Name = "button3";
            button3.Size = new Size(266, 49);
            button3.TabIndex = 0;
            button3.Text = "③";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tbOut3
            // 
            tbOut3.Location = new Point(430, 265);
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(290, 23);
            tbOut3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(tbOut1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btButton1);
            Name = "Form1";
            Text = "問題９．１";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btButton1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox tbOut1;
        private Button button1;
        private Button button2;
        private TextBox tbOut2;
        private Button button3;
        private TextBox tbOut3;
    }
}
