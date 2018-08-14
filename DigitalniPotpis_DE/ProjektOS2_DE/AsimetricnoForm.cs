using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalniPotpis
{
    public partial class AsimetricnoForm : Form
    {
        public AsimetricnoForm()
        {
            InitializeComponent();
        }
        
        string obicanTekst, privatniKljuc, ucitaniKriptiraniTekst="";

        AsimetricniKljuc objektAsimetricno = new AsimetricniKljuc();

        private void btnUcitajDatotekuAsimetricno_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                obicanTekst = File.ReadAllText(datoteka);
            }
            txtIspisIzvorno.Text = obicanTekst;
        }

        private void btnRSAkriptiraj_Click(object sender, EventArgs e)
        {
            try
            {
                string putanja = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Asimetricno\KriptiraniTekst.txt";

                string kriptiraniTekst = objektAsimetricno.Kriptiranje(obicanTekst);
                txtRSAkript.Text = kriptiraniTekst;
                objektAsimetricno.SpremiUDatoteku(putanja, kriptiraniTekst);
            }
            catch
            {
                MessageBox.Show("Greška pri kriptiranju datoteke!", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAESdekript_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                ucitaniKriptiraniTekst = File.ReadAllText(datoteka);
            }

            try
            {
                txtRSAdekript.Text= objektAsimetricno.Dekriptiranje(ucitaniKriptiraniTekst);
            }
            catch
            {
                MessageBox.Show("Greška pri dekriptiranju datoteke!","Pogreška!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnUcitajPrivatniKljucDekriptiranje_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                privatniKljuc = File.ReadAllText(datoteka);
            }
            try
            {
                objektAsimetricno.privatniKljuc = privatniKljuc;
                MessageBox.Show("Privatni ključ je učitan!", "Obavijest!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Pogreška pri učitavanju privatnog ključa!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
