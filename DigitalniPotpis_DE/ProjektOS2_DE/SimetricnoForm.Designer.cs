namespace DigitalniPotpis
{
    partial class SimetricnoKriptForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimetricnoKriptForma));
            this.btnUcitajDatoteku = new System.Windows.Forms.Button();
            this.txtIspisIzvorno = new System.Windows.Forms.TextBox();
            this.btnAESkript = new System.Windows.Forms.Button();
            this.btnAESdekript = new System.Windows.Forms.Button();
            this.txtAESkript = new System.Windows.Forms.TextBox();
            this.txtAESdekript = new System.Windows.Forms.TextBox();
            this.btnGenerirajKljucSim = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUcitajIV = new System.Windows.Forms.Button();
            this.btnUcitajKljuc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUcitajDatoteku
            // 
            this.btnUcitajDatoteku.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajDatoteku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajDatoteku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUcitajDatoteku.ForeColor = System.Drawing.Color.White;
            this.btnUcitajDatoteku.Location = new System.Drawing.Point(15, 37);
            this.btnUcitajDatoteku.Name = "btnUcitajDatoteku";
            this.btnUcitajDatoteku.Size = new System.Drawing.Size(185, 63);
            this.btnUcitajDatoteku.TabIndex = 0;
            this.btnUcitajDatoteku.TabStop = false;
            this.btnUcitajDatoteku.Text = "ODABERI DATOTEKU!";
            this.btnUcitajDatoteku.UseVisualStyleBackColor = false;
            this.btnUcitajDatoteku.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIspisIzvorno
            // 
            this.txtIspisIzvorno.BackColor = System.Drawing.Color.Black;
            this.txtIspisIzvorno.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIspisIzvorno.ForeColor = System.Drawing.Color.White;
            this.txtIspisIzvorno.Location = new System.Drawing.Point(27, 34);
            this.txtIspisIzvorno.Multiline = true;
            this.txtIspisIzvorno.Name = "txtIspisIzvorno";
            this.txtIspisIzvorno.ReadOnly = true;
            this.txtIspisIzvorno.Size = new System.Drawing.Size(698, 109);
            this.txtIspisIzvorno.TabIndex = 2;
            // 
            // btnAESkript
            // 
            this.btnAESkript.BackColor = System.Drawing.Color.Firebrick;
            this.btnAESkript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAESkript.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAESkript.ForeColor = System.Drawing.Color.White;
            this.btnAESkript.Location = new System.Drawing.Point(227, 34);
            this.btnAESkript.Name = "btnAESkript";
            this.btnAESkript.Size = new System.Drawing.Size(200, 71);
            this.btnAESkript.TabIndex = 3;
            this.btnAESkript.Text = "KRIPTIRAJ! (AES)";
            this.btnAESkript.UseVisualStyleBackColor = false;
            this.btnAESkript.Click += new System.EventHandler(this.btnAESkript_Click);
            // 
            // btnAESdekript
            // 
            this.btnAESdekript.BackColor = System.Drawing.Color.Firebrick;
            this.btnAESdekript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAESdekript.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAESdekript.ForeColor = System.Drawing.Color.White;
            this.btnAESdekript.Location = new System.Drawing.Point(223, 30);
            this.btnAESdekript.Name = "btnAESdekript";
            this.btnAESdekript.Size = new System.Drawing.Size(200, 75);
            this.btnAESdekript.TabIndex = 4;
            this.btnAESdekript.Text = "DEKRIPTIRAJ! (AES)";
            this.btnAESdekript.UseVisualStyleBackColor = false;
            this.btnAESdekript.Click += new System.EventHandler(this.btnAESdekript_Click);
            // 
            // txtAESkript
            // 
            this.txtAESkript.BackColor = System.Drawing.Color.Black;
            this.txtAESkript.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAESkript.ForeColor = System.Drawing.Color.White;
            this.txtAESkript.Location = new System.Drawing.Point(27, 61);
            this.txtAESkript.Multiline = true;
            this.txtAESkript.Name = "txtAESkript";
            this.txtAESkript.ReadOnly = true;
            this.txtAESkript.Size = new System.Drawing.Size(454, 209);
            this.txtAESkript.TabIndex = 6;
            // 
            // txtAESdekript
            // 
            this.txtAESdekript.BackColor = System.Drawing.Color.Black;
            this.txtAESdekript.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAESdekript.ForeColor = System.Drawing.Color.White;
            this.txtAESdekript.Location = new System.Drawing.Point(508, 61);
            this.txtAESdekript.Multiline = true;
            this.txtAESdekript.Name = "txtAESdekript";
            this.txtAESdekript.ReadOnly = true;
            this.txtAESdekript.Size = new System.Drawing.Size(442, 209);
            this.txtAESdekript.TabIndex = 7;
            // 
            // btnGenerirajKljucSim
            // 
            this.btnGenerirajKljucSim.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerirajKljucSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerirajKljucSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerirajKljucSim.ForeColor = System.Drawing.Color.White;
            this.btnGenerirajKljucSim.Location = new System.Drawing.Point(21, 34);
            this.btnGenerirajKljucSim.Name = "btnGenerirajKljucSim";
            this.btnGenerirajKljucSim.Size = new System.Drawing.Size(200, 71);
            this.btnGenerirajKljucSim.TabIndex = 8;
            this.btnGenerirajKljucSim.Text = "GENERIRAJ KLJUČ I IV";
            this.btnGenerirajKljucSim.UseVisualStyleBackColor = false;
            this.btnGenerirajKljucSim.Click += new System.EventHandler(this.btnGenerirajKljucSim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "KRIPTIRANO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(504, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "DEKRIPTIRANO:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtAESkript);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAESdekript);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(34, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 429);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KRIPTIRANJE I DEKRIPTIRANJE";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnUcitajIV);
            this.groupBox4.Controls.Add(this.btnAESdekript);
            this.groupBox4.Controls.Add(this.btnUcitajKljuc);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(508, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 123);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DEKRIPTIRANJE";
            // 
            // btnUcitajIV
            // 
            this.btnUcitajIV.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUcitajIV.ForeColor = System.Drawing.Color.White;
            this.btnUcitajIV.Location = new System.Drawing.Point(21, 71);
            this.btnUcitajIV.Name = "btnUcitajIV";
            this.btnUcitajIV.Size = new System.Drawing.Size(196, 34);
            this.btnUcitajIV.TabIndex = 14;
            this.btnUcitajIV.Text = "IV";
            this.btnUcitajIV.UseVisualStyleBackColor = false;
            this.btnUcitajIV.Click += new System.EventHandler(this.btnUcitajIV_Click);
            // 
            // btnUcitajKljuc
            // 
            this.btnUcitajKljuc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajKljuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajKljuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUcitajKljuc.ForeColor = System.Drawing.Color.White;
            this.btnUcitajKljuc.Location = new System.Drawing.Point(21, 30);
            this.btnUcitajKljuc.Name = "btnUcitajKljuc";
            this.btnUcitajKljuc.Size = new System.Drawing.Size(196, 34);
            this.btnUcitajKljuc.TabIndex = 13;
            this.btnUcitajKljuc.Text = "KLJUČ";
            this.btnUcitajKljuc.UseVisualStyleBackColor = false;
            this.btnUcitajKljuc.Click += new System.EventHandler(this.btnUcitajKljuc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnAESkript);
            this.groupBox3.Controls.Add(this.btnGenerirajKljucSim);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(27, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 123);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KRIPTIRANJE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtIspisIzvorno);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(34, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 168);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IZVORNI TEKST";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnUcitajDatoteku);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(731, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(219, 118);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "UČITAVANJE TEKSTA";
            // 
            // SimetricnoKriptForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimetricnoKriptForma";
            this.Text = "KriptoApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajDatoteku;
        private System.Windows.Forms.TextBox txtIspisIzvorno;
        private System.Windows.Forms.Button btnAESkript;
        private System.Windows.Forms.Button btnAESdekript;
        private System.Windows.Forms.TextBox txtAESkript;
        private System.Windows.Forms.TextBox txtAESdekript;
        private System.Windows.Forms.Button btnGenerirajKljucSim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUcitajKljuc;
        private System.Windows.Forms.Button btnUcitajIV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

