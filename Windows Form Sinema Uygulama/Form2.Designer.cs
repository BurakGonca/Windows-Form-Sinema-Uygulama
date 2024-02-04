namespace Windows_Form_Sinema_Uygulama
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            durumBilgisiButton = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            lblFilm = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // durumBilgisiButton
            // 
            durumBilgisiButton.BackgroundImage = Properties.Resources._33;
            durumBilgisiButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            durumBilgisiButton.Location = new Point(398, 359);
            durumBilgisiButton.Name = "durumBilgisiButton";
            durumBilgisiButton.Size = new Size(203, 49);
            durumBilgisiButton.TabIndex = 14;
            durumBilgisiButton.Text = "Durum Bilgisi";
            durumBilgisiButton.UseVisualStyleBackColor = true;
            durumBilgisiButton.Click += durumBilgisiButton_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(398, 211);
            button5.Name = "button5";
            button5.Size = new Size(138, 133);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(246, 211);
            button4.Name = "button4";
            button4.Size = new Size(138, 133);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(398, 64);
            button3.Name = "button3";
            button3.Size = new Size(138, 133);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(246, 64);
            button2.Name = "button2";
            button2.Size = new Size(138, 133);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblFilm
            // 
            lblFilm.AutoSize = true;
            lblFilm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilm.Location = new Point(270, 27);
            lblFilm.Name = "lblFilm";
            lblFilm.Size = new Size(243, 28);
            lblFilm.TabIndex = 9;
            lblFilm.Text = "GÖSTERİMDEKİ FİLMLER";
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.BackgroundImage = Properties.Resources.FORM1;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(181, 359);
            button1.Name = "button1";
            button1.Size = new Size(203, 49);
            button1.TabIndex = 8;
            button1.Text = "Personel Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.BackgroundImage = Properties.Resources.FORM1;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(181, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 147);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "GÜNCEL DURUM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 76);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 76);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(279, 48);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Toplam Ciro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(44, 48);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 0;
            label1.Text = "Toplam Satılan Bilet Adeti";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 608);
            Controls.Add(groupBox1);
            Controls.Add(durumBilgisiButton);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lblFilm);
            Controls.Add(button1);
            Name = "Form2";
            Text = "ANA SAYFA";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button durumBilgisiButton;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label lblFilm;
        private Button button1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}