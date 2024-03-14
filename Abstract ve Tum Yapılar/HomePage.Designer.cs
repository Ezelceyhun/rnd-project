namespace Abstract_ve_Tum_Yapılar
{
    partial class HomePage
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
            button7 = new Button();
            panel1 = new Panel();
            logout_btn = new Button();
            login_btn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
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
            button1.Location = new Point(9, 42);
            button1.Name = "button1";
            button1.Size = new Size(87, 41);
            button1.TabIndex = 1;
            button1.Text = "Gitar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(102, 42);
            button2.Name = "button2";
            button2.Size = new Size(87, 41);
            button2.TabIndex = 2;
            button2.Text = "Bateri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(195, 42);
            button3.Name = "button3";
            button3.Size = new Size(100, 41);
            button3.TabIndex = 3;
            button3.Text = "Flüt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F);
            button4.Location = new Point(301, 42);
            button4.Name = "button4";
            button4.Size = new Size(92, 41);
            button4.TabIndex = 4;
            button4.Text = "Davul";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(3, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 330);
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
            listBox1.Size = new Size(384, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox2);
            groupBox2.Location = new Point(405, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 332);
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
            listBox2.Size = new Size(169, 304);
            listBox2.TabIndex = 0;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11F);
            button5.Location = new Point(598, 42);
            button5.Name = "button5";
            button5.Size = new Size(169, 41);
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
            groupBox3.Location = new Point(592, 92);
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
            label3.Location = new Point(6, 27);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 1;
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
            textBox1.Location = new Point(405, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 41);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 22);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 9;
            label2.Text = "Satın Alan Kişinin İsmi";
            // 
            // button7
            // 
            button7.Location = new Point(598, 379);
            button7.Name = "button7";
            button7.Size = new Size(169, 42);
            button7.TabIndex = 3;
            button7.Text = "Tüm Ürünleri Göster";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(12, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 433);
            panel1.TabIndex = 10;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.Transparent;
            logout_btn.BackgroundImage = Properties.Resources.logout_FILL0_wght400_GRAD0_opsz24;
            logout_btn.BackgroundImageLayout = ImageLayout.Stretch;
            logout_btn.Location = new Point(758, 12);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(36, 42);
            logout_btn.TabIndex = 12;
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Transparent;
            login_btn.BackgroundImage = Properties.Resources.outline_login_black_24dp;
            login_btn.BackgroundImageLayout = ImageLayout.Stretch;
            login_btn.Location = new Point(758, 12);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(36, 42);
            login_btn.TabIndex = 11;
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 506);
            Controls.Add(logout_btn);
            Controls.Add(login_btn);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button7;
        private Panel panel1;
        private Button login_btn;
        private Button logout_btn;
    }
}
