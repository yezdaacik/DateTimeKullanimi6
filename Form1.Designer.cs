namespace DateTime_Kullanımı_6_815
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
            this.lblMiliSaniye = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblSonOdeme = new System.Windows.Forms.Label();
            this.lblBugun = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMiliSaniye
            // 
            this.lblMiliSaniye.AutoSize = true;
            this.lblMiliSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiliSaniye.Location = new System.Drawing.Point(33, 363);
            this.lblMiliSaniye.Name = "lblMiliSaniye";
            this.lblMiliSaniye.Size = new System.Drawing.Size(44, 16);
            this.lblMiliSaniye.TabIndex = 15;
            this.lblMiliSaniye.Text = "label7";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(33, 323);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(44, 16);
            this.lblSaniye.TabIndex = 14;
            this.lblSaniye.Text = "label6";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(33, 280);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(44, 16);
            this.lblDakika.TabIndex = 13;
            this.lblDakika.Text = "label5";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(33, 238);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(44, 16);
            this.lblSaat.TabIndex = 12;
            this.lblSaat.Text = "label4";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGun.Location = new System.Drawing.Point(33, 198);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(44, 16);
            this.lblGun.TabIndex = 11;
            this.lblGun.Text = "label3";
            // 
            // lblSonOdeme
            // 
            this.lblSonOdeme.AutoSize = true;
            this.lblSonOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonOdeme.Location = new System.Drawing.Point(33, 153);
            this.lblSonOdeme.Name = "lblSonOdeme";
            this.lblSonOdeme.Size = new System.Drawing.Size(44, 16);
            this.lblSonOdeme.TabIndex = 10;
            this.lblSonOdeme.Text = "label2";
            // 
            // lblBugun
            // 
            this.lblBugun.AutoSize = true;
            this.lblBugun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBugun.Location = new System.Drawing.Point(33, 114);
            this.lblBugun.Name = "lblBugun";
            this.lblBugun.Size = new System.Drawing.Size(44, 16);
            this.lblBugun.TabIndex = 9;
            this.lblBugun.Text = "label1";
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.Location = new System.Drawing.Point(36, 26);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(396, 53);
            this.btnGoster.TabIndex = 8;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 435);
            this.Controls.Add(this.lblMiliSaniye);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblSonOdeme);
            this.Controls.Add(this.lblBugun);
            this.Controls.Add(this.btnGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiliSaniye;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblSonOdeme;
        private System.Windows.Forms.Label lblBugun;
        private System.Windows.Forms.Button btnGoster;
    }
}

