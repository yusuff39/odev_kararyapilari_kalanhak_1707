﻿namespace Odev_KararYapilari_1707
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
            this.lblKalanHakkimiz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtMetinGirisAlani = new System.Windows.Forms.TextBox();
            this.lblRastgeleKarakterler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKalanHakkimiz
            // 
            this.lblKalanHakkimiz.AutoSize = true;
            this.lblKalanHakkimiz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblKalanHakkimiz.ForeColor = System.Drawing.Color.Maroon;
            this.lblKalanHakkimiz.Location = new System.Drawing.Point(269, 110);
            this.lblKalanHakkimiz.Name = "lblKalanHakkimiz";
            this.lblKalanHakkimiz.Size = new System.Drawing.Size(26, 25);
            this.lblKalanHakkimiz.TabIndex = 23;
            this.lblKalanHakkimiz.Text = "5";
            this.lblKalanHakkimiz.Click += new System.EventHandler(this.LblKalanHakkimiz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kalan Hatalı Giriş Hakkınız:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(201, 68);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(178, 32);
            this.btnGirisYap.TabIndex = 21;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // txtMetinGirisAlani
            // 
            this.txtMetinGirisAlani.Location = new System.Drawing.Point(20, 71);
            this.txtMetinGirisAlani.Name = "txtMetinGirisAlani";
            this.txtMetinGirisAlani.Size = new System.Drawing.Size(175, 22);
            this.txtMetinGirisAlani.TabIndex = 20;
            // 
            // lblRastgeleKarakterler
            // 
            this.lblRastgeleKarakterler.AutoSize = true;
            this.lblRastgeleKarakterler.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblRastgeleKarakterler.Location = new System.Drawing.Point(16, 39);
            this.lblRastgeleKarakterler.Name = "lblRastgeleKarakterler";
            this.lblRastgeleKarakterler.Size = new System.Drawing.Size(43, 23);
            this.lblRastgeleKarakterler.TabIndex = 19;
            this.lblRastgeleKarakterler.Text = "...";
            this.lblRastgeleKarakterler.Click += new System.EventHandler(this.LblRastgeleKarakterler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lütfen aşağıda görmüş karakterleri ilgili yazı alanına geçiriniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 173);
            this.Controls.Add(this.lblKalanHakkimiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtMetinGirisAlani);
            this.Controls.Add(this.lblRastgeleKarakterler);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalanHakkimiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtMetinGirisAlani;
        private System.Windows.Forms.Label lblRastgeleKarakterler;
        private System.Windows.Forms.Label label1;
    }
}

