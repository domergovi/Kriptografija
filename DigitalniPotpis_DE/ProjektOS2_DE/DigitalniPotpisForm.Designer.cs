namespace DigitalniPotpis
{
    partial class DigitalniPotpisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitalniPotpisForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIspisIzvorno = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUcitajDatotekuDigitalniPotpis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzracunajSazetak = new System.Windows.Forms.Button();
            this.txtSazetak = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnProvjeri = new System.Windows.Forms.Button();
            this.btnUcitajJavniKljuc = new System.Windows.Forms.Button();
            this.btnUcitajPotpis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPotpis = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPotpisiDokument = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(31, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 169);
            this.groupBox2.TabIndex = 19;
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
            this.groupBox5.Controls.Add(this.btnUcitajDatotekuDigitalniPotpis);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(715, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(223, 121);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "UČITAVANJE TEKSTA";
            // 
            // btnUcitajDatotekuDigitalniPotpis
            // 
            this.btnUcitajDatotekuDigitalniPotpis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajDatotekuDigitalniPotpis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajDatotekuDigitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUcitajDatotekuDigitalniPotpis.ForeColor = System.Drawing.Color.White;
            this.btnUcitajDatotekuDigitalniPotpis.Location = new System.Drawing.Point(24, 36);
            this.btnUcitajDatotekuDigitalniPotpis.Name = "btnUcitajDatotekuDigitalniPotpis";
            this.btnUcitajDatotekuDigitalniPotpis.Size = new System.Drawing.Size(177, 63);
            this.btnUcitajDatotekuDigitalniPotpis.TabIndex = 0;
            this.btnUcitajDatotekuDigitalniPotpis.TabStop = false;
            this.btnUcitajDatotekuDigitalniPotpis.Text = "ODABERI DATOTEKU!";
            this.btnUcitajDatotekuDigitalniPotpis.UseVisualStyleBackColor = false;
            this.btnUcitajDatotekuDigitalniPotpis.Click += new System.EventHandler(this.btnUcitajDatotekuDigitalniPotpis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnIzracunajSazetak);
            this.groupBox1.Controls.Add(this.txtSazetak);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 97);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAŽETAK";
            // 
            // btnIzracunajSazetak
            // 
            this.btnIzracunajSazetak.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIzracunajSazetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzracunajSazetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnIzracunajSazetak.ForeColor = System.Drawing.Color.White;
            this.btnIzracunajSazetak.Location = new System.Drawing.Point(739, 25);
            this.btnIzracunajSazetak.Name = "btnIzracunajSazetak";
            this.btnIzracunajSazetak.Size = new System.Drawing.Size(177, 54);
            this.btnIzracunajSazetak.TabIndex = 0;
            this.btnIzracunajSazetak.TabStop = false;
            this.btnIzracunajSazetak.Text = "IZRAČUNAJ I SPREMI!";
            this.btnIzracunajSazetak.UseVisualStyleBackColor = false;
            this.btnIzracunajSazetak.Click += new System.EventHandler(this.btnIzracunajSazetak_Click);
            // 
            // txtSazetak
            // 
            this.txtSazetak.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSazetak.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSazetak.ForeColor = System.Drawing.Color.White;
            this.txtSazetak.Location = new System.Drawing.Point(26, 37);
            this.txtSazetak.Multiline = true;
            this.txtSazetak.Name = "txtSazetak";
            this.txtSazetak.ReadOnly = true;
            this.txtSazetak.Size = new System.Drawing.Size(683, 31);
            this.txtSazetak.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPotpis);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(31, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(967, 316);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DIGITALNI POTPIS I PROVJERA";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnProvjeri);
            this.groupBox6.Controls.Add(this.btnUcitajJavniKljuc);
            this.groupBox6.Controls.Add(this.btnUcitajPotpis);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(327, 184);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(611, 101);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PROVJERA";
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.BackColor = System.Drawing.Color.Firebrick;
            this.btnProvjeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvjeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnProvjeri.ForeColor = System.Drawing.Color.White;
            this.btnProvjeri.Location = new System.Drawing.Point(412, 29);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(177, 54);
            this.btnProvjeri.TabIndex = 2;
            this.btnProvjeri.TabStop = false;
            this.btnProvjeri.Text = "PROVJERI!";
            this.btnProvjeri.UseVisualStyleBackColor = false;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // btnUcitajJavniKljuc
            // 
            this.btnUcitajJavniKljuc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajJavniKljuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajJavniKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUcitajJavniKljuc.ForeColor = System.Drawing.Color.White;
            this.btnUcitajJavniKljuc.Location = new System.Drawing.Point(216, 29);
            this.btnUcitajJavniKljuc.Name = "btnUcitajJavniKljuc";
            this.btnUcitajJavniKljuc.Size = new System.Drawing.Size(180, 54);
            this.btnUcitajJavniKljuc.TabIndex = 1;
            this.btnUcitajJavniKljuc.TabStop = false;
            this.btnUcitajJavniKljuc.Text = "UČITAJ JAVNI KLJUČ!";
            this.btnUcitajJavniKljuc.UseVisualStyleBackColor = false;
            this.btnUcitajJavniKljuc.Click += new System.EventHandler(this.btnUcitajJavniKljuc_Click);
            // 
            // btnUcitajPotpis
            // 
            this.btnUcitajPotpis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajPotpis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUcitajPotpis.ForeColor = System.Drawing.Color.White;
            this.btnUcitajPotpis.Location = new System.Drawing.Point(20, 29);
            this.btnUcitajPotpis.Name = "btnUcitajPotpis";
            this.btnUcitajPotpis.Size = new System.Drawing.Size(177, 54);
            this.btnUcitajPotpis.TabIndex = 0;
            this.btnUcitajPotpis.TabStop = false;
            this.btnUcitajPotpis.Text = "UČITAJ POTPIS!";
            this.btnUcitajPotpis.UseVisualStyleBackColor = false;
            this.btnUcitajPotpis.Click += new System.EventHandler(this.btnUcitajPotpis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "POTPIS:";
            // 
            // txtPotpis
            // 
            this.txtPotpis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPotpis.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPotpis.ForeColor = System.Drawing.Color.White;
            this.txtPotpis.Location = new System.Drawing.Point(26, 59);
            this.txtPotpis.Multiline = true;
            this.txtPotpis.Name = "txtPotpis";
            this.txtPotpis.ReadOnly = true;
            this.txtPotpis.Size = new System.Drawing.Size(912, 119);
            this.txtPotpis.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnPotpisiDokument);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(26, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(266, 101);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "POTPISIVANJE";
            // 
            // btnPotpisiDokument
            // 
            this.btnPotpisiDokument.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPotpisiDokument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotpisiDokument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPotpisiDokument.ForeColor = System.Drawing.Color.White;
            this.btnPotpisiDokument.Location = new System.Drawing.Point(18, 29);
            this.btnPotpisiDokument.Name = "btnPotpisiDokument";
            this.btnPotpisiDokument.Size = new System.Drawing.Size(230, 54);
            this.btnPotpisiDokument.TabIndex = 0;
            this.btnPotpisiDokument.TabStop = false;
            this.btnPotpisiDokument.Text = "POTPIŠI!";
            this.btnPotpisiDokument.UseVisualStyleBackColor = false;
            this.btnPotpisiDokument.Click += new System.EventHandler(this.btnPotpisiDokument_Click);
            // 
            // DigitalniPotpisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 676);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DigitalniPotpisForm";
            this.Text = "DigitalniPotpisForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIspisIzvorno;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnUcitajDatotekuDigitalniPotpis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzracunajSazetak;
        private System.Windows.Forms.TextBox txtSazetak;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPotpis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPotpisiDokument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUcitajPotpis;
        private System.Windows.Forms.Button btnUcitajJavniKljuc;
        private System.Windows.Forms.Button btnProvjeri;
    }
}