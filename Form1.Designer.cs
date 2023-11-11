namespace U3_Practica_11
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(426, 208);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 0;
            button1.Text = "For";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(426, 247);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 1;
            button2.Text = "While";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(426, 286);
            button3.Name = "button3";
            button3.Size = new Size(94, 33);
            button3.TabIndex = 2;
            button3.Text = "Do, while";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(426, 325);
            button4.Name = "button4";
            button4.Size = new Size(94, 33);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.MintCream;
            listBox1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(24, 144);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 268);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.MintCream;
            listBox2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 22;
            listBox2.Location = new Point(238, 144);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(152, 268);
            listBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 106);
            label1.Name = "label1";
            label1.Size = new Size(27, 35);
            label1.TabIndex = 6;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(282, 106);
            label2.Name = "label2";
            label2.Size = new Size(58, 35);
            label2.TabIndex = 7;
            label2.Text = "f (x)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(71, 41);
            label3.Name = "label3";
            label3.Size = new Size(76, 35);
            label3.TabIndex = 8;
            label3.Text = "F(x) =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(153, 30);
            label4.Name = "label4";
            label4.Size = new Size(113, 35);
            label4.TabIndex = 9;
            label4.Text = "_______";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(196, 25);
            label5.Name = "label5";
            label5.Size = new Size(27, 35);
            label5.TabIndex = 10;
            label5.Text = "x";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(171, 63);
            label6.Name = "label6";
            label6.Size = new Size(76, 35);
            label6.TabIndex = 11;
            label6.Text = "1 + x²";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(588, 454);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}