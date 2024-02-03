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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            lblFilm = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(305, 493);
            button6.Name = "button6";
            button6.Size = new Size(165, 48);
            button6.TabIndex = 14;
            button6.Text = "DURUM BİLGİSİ";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(398, 263);
            button5.Name = "button5";
            button5.Size = new Size(203, 168);
            button5.TabIndex = 13;
            button5.Text = "Harry Potter";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(181, 263);
            button4.Name = "button4";
            button4.Size = new Size(203, 168);
            button4.TabIndex = 12;
            button4.Text = "StarWars";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(398, 89);
            button3.Name = "button3";
            button3.Size = new Size(203, 168);
            button3.TabIndex = 11;
            button3.Text = "TheGodFather";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(181, 89);
            button2.Name = "button2";
            button2.Size = new Size(203, 168);
            button2.TabIndex = 10;
            button2.Text = "Esaretin Bedeli";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblFilm
            // 
            lblFilm.AutoSize = true;
            lblFilm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilm.Location = new Point(270, 37);
            lblFilm.Name = "lblFilm";
            lblFilm.Size = new Size(243, 28);
            lblFilm.TabIndex = 9;
            lblFilm.Text = "GÖSTERİMDEKİ FİLMLER";
            // 
            // button1
            // 
            button1.Location = new Point(304, 448);
            button1.Name = "button1";
            button1.Size = new Size(166, 29);
            button1.TabIndex = 8;
            button1.Text = "Personel Giris Ekranı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 579);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lblFilm);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label lblFilm;
        private Button button1;
    }
}