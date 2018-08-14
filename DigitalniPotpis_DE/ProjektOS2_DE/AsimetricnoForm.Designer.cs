namespace DigitalniPotpis
{
    partial class AsimetricnoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsimetricnoForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIspisIzvorno = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUcitajDatotekuAsimetricno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRSAkript = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRSAdekript = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRSAkriptiraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUcitajPrivatniKljucDekriptiranje = new System.Windows.Forms.Button();
            this.btnAESdekript = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtIspisIzvorno);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(50, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 169);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IZVORNI TEKST";
            // 
            // txtIspisIzvorno
            // 
            this.txtIspisIzvorno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIspisIzvorno.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIspisIzvorno.ForeColor = System.Drawing.Color.White;
            this.txtIspisIzvorno.Location = new System.Drawing.Point(26, 34);
            this.txtIspisIzvorno.Multiline = true;
            this.txtIspisIzvorno.Name = "txtIspisIzvorno";
            this.txtIspisIzvorno.ReadOnly = true;
            this.txtIspisIzvorno.Size = new System.Drawing.Size(683, 110);
            this.txtIspisIzvorno.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnUcitajDatotekuAsimetricno);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(715, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(223, 121);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "UČITAVANJE TEKSTA";
            // 
            // btnUcitajDatotekuAsimetricno
            // 
            this.btnUcitajDatotekuAsimetricno.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajDatotekuAsimetricno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajDatotekuAsimetricno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUcitajDatotekuAsimetricno.ForeColor = System.Drawing.Color.White;
            this.btnUcitajDatotekuAsimetricno.Location = new System.Drawing.Point(24, 36);
            this.btnUcitajDatotekuAsimetricno.Name = "btnUcitajDatotekuAsimetricno";
            this.btnUcitajDatotekuAsimetricno.Size = new System.Drawing.Size(177, 63);
            this.btnUcitajDatotekuAsimetricno.TabIndex = 0;
            this.btnUcitajDatotekuAsimetricno.TabStop = false;
            this.btnUcitajDatotekuAsimetricno.Text = "ODABERI DATOTEKU!";
            this.btnUcitajDatotekuAsimetricno.UseVisualStyleBackColor = false;
            this.btnUcitajDatotekuAsimetricno.Click += new System.EventHandler(this.btnUcitajDatotekuAsimetricno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRSAkript);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRSAdekript);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(50, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 453);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KRIPTIRANJE I DEKRIPTIRANJE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(497, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "DEKRIPTIRANO:";
            // 
            // txtRSAkript
            // 
            this.txtRSAkript.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRSAkript.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRSAkript.ForeColor = System.Drawing.Color.White;
            this.txtRSAkript.Location = new System.Drawing.Point(26, 60);
            this.txtRSAkript.Multiline = true;
            this.txtRSAkript.Name = "txtRSAkript";
            this.txtRSAkript.ReadOnly = true;
            this.txtRSAkript.Size = new System.Drawing.Size(444, 229);
            this.txtRSAkript.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "KRIPTIRANO:";
            // 
            // txtRSAdekript
            // 
            this.txtRSAdekript.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRSAdekript.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRSAdekript.ForeColor = System.Drawing.Color.White;
            this.txtRSAdekript.Location = new System.Drawing.Point(501, 60);
            this.txtRSAdekript.Multiline = true;
            this.txtRSAdekript.Name = "txtRSAdekript";
            this.txtRSAdekript.ReadOnly = true;
            this.txtRSAdekript.Size = new System.Drawing.Size(437, 229);
            this.txtRSAdekript.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnRSAkriptiraj);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(26, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 124);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KRIPTIRANJE";
            // 
            // btnRSAkriptiraj
            // 
            this.btnRSAkriptiraj.BackColor = System.Drawing.Color.Firebrick;
            this.btnRSAkriptiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSAkriptiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRSAkriptiraj.ForeColor = System.Drawing.Color.White;
            this.btnRSAkriptiraj.Location = new System.Drawing.Point(16, 25);
            this.btnRSAkriptiraj.Name = "btnRSAkriptiraj";
            this.btnRSAkriptiraj.Size = new System.Drawing.Size(411, 82);
            this.btnRSAkriptiraj.TabIndex = 3;
            this.btnRSAkriptiraj.Text = "KRIPTIRAJ! (RSA)";
            this.btnRSAkriptiraj.UseVisualStyleBackColor = false;
            this.btnRSAkriptiraj.Click += new System.EventHandler(this.btnRSAkriptiraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, -39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "DEKRIPTIRANO:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnUcitajPrivatniKljucDekriptiranje);
            this.groupBox4.Controls.Add(this.btnAESdekript);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(501, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 124);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DEKRIPTIRANJE";
            // 
            // btnUcitajPrivatniKljucDekriptiranje
            // 
            this.btnUcitajPrivatniKljucDekriptiranje.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajPrivatniKljucDekriptiranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajPrivatniKljucDekriptiranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUcitajPrivatniKljucDekriptiranje.ForeColor = System.Drawing.Color.White;
            this.btnUcitajPrivatniKljucDekriptiranje.Location = new System.Drawing.Point(17, 25);
            this.btnUcitajPrivatniKljucDekriptiranje.Name = "btnUcitajPrivatniKljucDekriptiranje";
            this.btnUcitajPrivatniKljucDekriptiranje.Size = new System.Drawing.Size(398, 38);
            this.btnUcitajPrivatniKljucDekriptiranje.TabIndex = 14;
            this.btnUcitajPrivatniKljucDekriptiranje.Text = "PRIVATNI KLJUČ";
            this.btnUcitajPrivatniKljucDekriptiranje.UseVisualStyleBackColor = false;
            this.btnUcitajPrivatniKljucDekriptiranje.Click += new System.EventHandler(this.btnUcitajPrivatniKljucDekriptiranje_Click);
            // 
            // btnAESdekript
            // 
            this.btnAESdekript.BackColor = System.Drawing.Color.Firebrick;
            this.btnAESdekript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAESdekript.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAESdekript.ForeColor = System.Drawing.Color.White;
            this.btnAESdekript.Location = new System.Drawing.Point(17, 69);
            this.btnAESdekript.Name = "btnAESdekript";
            this.btnAESdekript.Size = new System.Drawing.Size(398, 38);
            this.btnAESdekript.TabIndex = 4;
            this.btnAESdekript.Text = "DEKRIPTIRAJ! (RSA)";
            this.btnAESdekript.UseVisualStyleBackColor = false;
            this.btnAESdekript.Click += new System.EventHandler(this.btnAESdekript_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(102, -60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 61);
            this.label1.TabIndex = 15;
            this.label1.Text = "SIMETRIČNO KRIPTIRANJE";
            // 
            // AsimetricnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 701);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AsimetricnoForm";
            this.Text = "KriptoApp";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIspisIzvorno;
        private System.Windows.Forms.Button btnUcitajDatotekuAsimetricno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRSAkript;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAESdekript;
        private System.Windows.Forms.Button btnRSAkriptiraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRSAdekript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUcitajPrivatniKljucDekriptiranje;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
    }
}