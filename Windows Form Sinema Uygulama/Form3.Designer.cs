namespace Windows_Form_Sinema_Uygulama
{
    partial class Form3
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
            button5 = new Button();
            biletIadeButton = new Button();
            biletSatButton = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.FORM1;
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(203, 417);
            button5.Name = "button5";
            button5.Size = new Size(383, 43);
            button5.TabIndex = 14;
            button5.Text = "Ana Sayfaya Geri Dön";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // biletIadeButton
            // 
            biletIadeButton.BackgroundImage = Properties.Resources._33;
            biletIadeButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            biletIadeButton.Location = new Point(401, 336);
            biletIadeButton.Name = "biletIadeButton";
            biletIadeButton.Size = new Size(185, 75);
            biletIadeButton.TabIndex = 11;
            biletIadeButton.Text = "BİLET İADE";
            biletIadeButton.UseVisualStyleBackColor = true;
            biletIadeButton.Click += biletIadeButton_Click;
            // 
            // biletSatButton
            // 
            biletSatButton.BackgroundImage = Properties.Resources._33;
            biletSatButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            biletSatButton.Location = new Point(197, 336);
            biletSatButton.Name = "biletSatButton";
            biletSatButton.Size = new Size(185, 75);
            biletSatButton.TabIndex = 10;
            biletSatButton.Text = "BİLET SAT";
            biletSatButton.UseVisualStyleBackColor = true;
            biletSatButton.Click += biletSatButton_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.FORM1;
            button1.Location = new Point(345, 292);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.BackgroundImage = Properties.Resources._33;
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(197, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 163);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "FİLM BİLGİLERİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._33;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 613);
            Controls.Add(button5);
            Controls.Add(biletIadeButton);
            Controls.Add(biletSatButton);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "FİLM İSLEMLERİ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Button biletIadeButton;
        private Button biletSatButton;
        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
    }
}