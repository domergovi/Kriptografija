namespace DigitalniPotpis
{
    partial class GlavniIzbornikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavniIzbornikForm));
            this.btnAsimetricno = new System.Windows.Forms.Button();
            this.btnSimetricno = new System.Windows.Forms.Button();
            this.btnDigitalniPotpis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAsimetricno
            // 
            this.btnAsimetricno.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAsimetricno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAsimetricno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsimetricno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAsimetricno.ForeColor = System.Drawing.Color.White;
            this.btnAsimetricno.Location = new System.Drawing.Point(87, 180);
            this.btnAsimetricno.Name = "btnAsimetricno";
            this.btnAsimetricno.Size = new System.Drawing.Size(358, 72);
            this.btnAsimetricno.TabIndex = 1;
            this.btnAsimetricno.Text = "ASIMETRIČNO KRIPTIRANJE";
            this.btnAsimetricno.UseVisualStyleBackColor = false;
            this.btnAsimetricno.Click += new System.EventHandler(this.btnAsimetricno_Click);
            // 
            // btnSimetricno
            // 
            this.btnSimetricno.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSimetricno.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSimetricno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSimetricno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimetricno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSimetricno.ForeColor = System.Drawing.Color.White;
            this.btnSimetricno.Location = new System.Drawing.Point(87, 102);
            this.btnSimetricno.Name = "btnSimetricno";
            this.btnSimetricno.Size = new System.Drawing.Size(358, 72);
            this.btnSimetricno.TabIndex = 0;
            this.btnSimetricno.Text = "SIMETRIČNO KRIPTIRANJE";
            this.btnSimetricno.UseVisualStyleBackColor = false;
            this.btnSimetricno.Click += new System.EventHandler(this.btnSimetricno_Click);
            // 
            // btnDigitalniPotpis
            // 
            this.btnDigitalniPotpis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDigitalniPotpis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDigitalniPotpis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDigitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDigitalniPotpis.ForeColor = System.Drawing.Color.White;
            this.btnDigitalniPotpis.Location = new System.Drawing.Point(87, 258);
            this.btnDigitalniPotpis.Name = "btnDigitalniPotpis";
            this.btnDigitalniPotpis.Size = new System.Drawing.Size(358, 72);
            this.btnDigitalniPotpis.TabIndex = 2;
            this.btnDigitalniPotpis.Text = "DIGITALNI POTPIS";
            this.btnDigitalniPotpis.UseVisualStyleBackColor = false;
            this.btnDigitalniPotpis.Click += new System.EventHandler(this.btnDigitalniPotpis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "GLAVNI IZBORNIK";
            // 
            // GlavniIzbornikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDigitalniPotpis);
            this.Controls.Add(this.btnAsimetricno);
            this.Controls.Add(this.btnSimetricno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavniIzbornikForm";
            this.Text = "KriptoApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsimetricno;
        private System.Windows.Forms.Button btnSimetricno;
        private System.Windows.Forms.Button btnDigitalniPotpis;
        private System.Windows.Forms.Label label1;
    }
}