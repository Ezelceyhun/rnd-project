namespace Abstract_ve_Tum_Yapılar
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            listBox2 = new ListBox();
            button5 = new Button();
            groupBox3 = new GroupBox();
            button6 = new Button();
            label3 = new Label();
            listBox3 = new ListBox();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(197, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(12, 82);
            button1.Name = "button1";
            button1.Size = new Size(113, 41);
            button1.TabIndex = 1;
            button1.Text = "Gitar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(131, 82);
            button2.Name = "button2";
            button2.Size = new Size(113, 41);
            button2.TabIndex = 2;
            button2.Text = "Bateri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(250, 82);
            button3.Name = "button3";
            button3.Size = new Size(113, 41);
            button3.TabIndex = 3;
            button3.Text = "Flüt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(369, 82);
            button4.Name = "button4";
            button4.Size = new Size(113, 41);
            button4.TabIndex = 4;
            button4.Text = "Davul";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 295);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eklenenler";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(384, 264);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox2);
            groupBox2.Location = new Point(414, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 295);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ara Toplam";
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Control;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(6, 26);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(169, 264);
            listBox2.TabIndex = 0;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11F);
            button5.Location = new Point(665, 82);
            button5.Name = "button5";
            button5.Size = new Size(107, 41);
            button5.TabIndex = 7;
            button5.Text = "Satın Al";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(listBox3);
            groupBox3.Location = new Point(601, 132);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(181, 287);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Toplam";
            // 
            // button6
            // 
            button6.Location = new Point(6, 252);
            button6.Name = "button6";
            button6.Size = new Size(169, 29);
            button6.TabIndex = 2;
            button6.Text = "Temizle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // listBox3
            // 
            listBox3.BackColor = SystemColors.Control;
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(6, 62);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(169, 184);
            listBox3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(488, 82);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 41);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 59);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 9;
            label2.Text = "Satın Alan Kişinin İsmi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 439);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(groupBox3);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button5;
        private GroupBox groupBox3;
        private ListBox listBox3;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button6;
    }
}
