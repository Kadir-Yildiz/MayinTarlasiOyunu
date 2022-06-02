namespace MayinTarlasiOyunu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBayrakSayisi = new System.Windows.Forms.Label();
            this.btnYenidenBasla = new System.Windows.Forms.Button();
            this.lblSure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(270, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblBayrakSayisi);
            this.panel2.Location = new System.Drawing.Point(270, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblBayrakSayisi
            // 
            this.lblBayrakSayisi.AutoSize = true;
            this.lblBayrakSayisi.BackColor = System.Drawing.Color.Black;
            this.lblBayrakSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBayrakSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblBayrakSayisi.Location = new System.Drawing.Point(4, 4);
            this.lblBayrakSayisi.Name = "lblBayrakSayisi";
            this.lblBayrakSayisi.Size = new System.Drawing.Size(0, 39);
            this.lblBayrakSayisi.TabIndex = 0;
            // 
            // btnYenidenBasla
            // 
            this.btnYenidenBasla.BackColor = System.Drawing.Color.Gainsboro;
            this.btnYenidenBasla.Location = new System.Drawing.Point(539, 176);
            this.btnYenidenBasla.Name = "btnYenidenBasla";
            this.btnYenidenBasla.Size = new System.Drawing.Size(75, 23);
            this.btnYenidenBasla.TabIndex = 2;
            this.btnYenidenBasla.UseVisualStyleBackColor = false;
            this.btnYenidenBasla.Click += new System.EventHandler(this.btnYenidenBasla_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BackColor = System.Drawing.Color.Black;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.Red;
            this.lblSure.Location = new System.Drawing.Point(231, 182);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 39);
            this.lblSure.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 676);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.btnYenidenBasla);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYenidenBasla;
        private System.Windows.Forms.Label lblBayrakSayisi;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timer1;
    }
}

