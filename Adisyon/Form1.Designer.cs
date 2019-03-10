namespace Adisyon
{
    partial class Form1
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
            this.checkBoxSimit = new System.Windows.Forms.CheckBox();
            this.checkBoxCay = new System.Windows.Forms.CheckBox();
            this.checkBoxGazoz = new System.Windows.Forms.CheckBox();
            this.checkBoxSoda = new System.Windows.Forms.CheckBox();
            this.checkBoxAyran = new System.Windows.Forms.CheckBox();
            this.checkBoxKola = new System.Windows.Forms.CheckBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtHesap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxSimit
            // 
            this.checkBoxSimit.AutoSize = true;
            this.checkBoxSimit.Location = new System.Drawing.Point(36, 34);
            this.checkBoxSimit.Name = "checkBoxSimit";
            this.checkBoxSimit.Size = new System.Drawing.Size(88, 17);
            this.checkBoxSimit.TabIndex = 0;
            this.checkBoxSimit.Text = "Simit (1.5 TL)";
            this.checkBoxSimit.UseVisualStyleBackColor = true;
            // 
            // checkBoxCay
            // 
            this.checkBoxCay.AutoSize = true;
            this.checkBoxCay.Location = new System.Drawing.Point(36, 72);
            this.checkBoxCay.Name = "checkBoxCay";
            this.checkBoxCay.Size = new System.Drawing.Size(81, 17);
            this.checkBoxCay.TabIndex = 1;
            this.checkBoxCay.Text = "Çay(1.5 TL)";
            this.checkBoxCay.UseVisualStyleBackColor = true;
            // 
            // checkBoxGazoz
            // 
            this.checkBoxGazoz.AutoSize = true;
            this.checkBoxGazoz.Location = new System.Drawing.Point(36, 105);
            this.checkBoxGazoz.Name = "checkBoxGazoz";
            this.checkBoxGazoz.Size = new System.Drawing.Size(93, 17);
            this.checkBoxGazoz.TabIndex = 2;
            this.checkBoxGazoz.Text = "Gazoz(1.5 TL)";
            this.checkBoxGazoz.UseVisualStyleBackColor = true;
            // 
            // checkBoxSoda
            // 
            this.checkBoxSoda.AutoSize = true;
            this.checkBoxSoda.Location = new System.Drawing.Point(36, 138);
            this.checkBoxSoda.Name = "checkBoxSoda";
            this.checkBoxSoda.Size = new System.Drawing.Size(79, 17);
            this.checkBoxSoda.TabIndex = 3;
            this.checkBoxSoda.Text = "Soda(1 TL)";
            this.checkBoxSoda.UseVisualStyleBackColor = true;
            // 
            // checkBoxAyran
            // 
            this.checkBoxAyran.AutoSize = true;
            this.checkBoxAyran.Location = new System.Drawing.Point(36, 171);
            this.checkBoxAyran.Name = "checkBoxAyran";
            this.checkBoxAyran.Size = new System.Drawing.Size(84, 17);
            this.checkBoxAyran.TabIndex = 4;
            this.checkBoxAyran.Text = "Ayran (2 TL)";
            this.checkBoxAyran.UseVisualStyleBackColor = true;
            // 
            // checkBoxKola
            // 
            this.checkBoxKola.AutoSize = true;
            this.checkBoxKola.Location = new System.Drawing.Point(36, 204);
            this.checkBoxKola.Name = "checkBoxKola";
            this.checkBoxKola.Size = new System.Drawing.Size(75, 17);
            this.checkBoxKola.TabIndex = 5;
            this.checkBoxKola.Text = "Kola(4 TL)";
            this.checkBoxKola.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(218, 138);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtHesap
            // 
            this.txtHesap.Location = new System.Drawing.Point(329, 140);
            this.txtHesap.Name = "txtHesap";
            this.txtHesap.Size = new System.Drawing.Size(75, 20);
            this.txtHesap.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 364);
            this.Controls.Add(this.txtHesap);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.checkBoxKola);
            this.Controls.Add(this.checkBoxAyran);
            this.Controls.Add(this.checkBoxSoda);
            this.Controls.Add(this.checkBoxGazoz);
            this.Controls.Add(this.checkBoxCay);
            this.Controls.Add(this.checkBoxSimit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSimit;
        private System.Windows.Forms.CheckBox checkBoxCay;
        private System.Windows.Forms.CheckBox checkBoxGazoz;
        private System.Windows.Forms.CheckBox checkBoxSoda;
        private System.Windows.Forms.CheckBox checkBoxAyran;
        private System.Windows.Forms.CheckBox checkBoxKola;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtHesap;
    }
}

