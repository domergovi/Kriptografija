using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DigitalniPotpis
{
    public partial class SimetricnoKriptForma : Form
    {
        public SimetricnoKriptForma()
        {
            InitializeComponent();
        }
        RijndaelManaged objektKripto = new RijndaelManaged();
        SimetricniKljuc objektSim = new SimetricniKljuc();

        string obicanTekst = "";
        byte[] simKljuc,IV;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                obicanTekst = File.ReadAllText(datoteka);
            }
            txtIspisIzvorno.Text = obicanTekst;
        }

        private void btnGenerirajKljucSim_Click(object sender, EventArgs e)
        {

            string putanjaKljuc = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Simetricno\Tajni_kljuc.txt";
            string putanjaIV = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Simetricno\IV.txt";

            simKljuc = objektKripto.Key;
            IV = objektKripto.IV;
            objektKripto.KeySize = 256;

            objektSim.kljuc = simKljuc;
            objektSim.IV = IV;

            objektSim.SpremiUDatoteku(putanjaKljuc, objektSim.kljuc);
            objektSim.SpremiUDatoteku(putanjaIV, objektSim.IV);

            MessageBox.Show("Tajni ključ i IV su generirani!","Obavijest!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAESdekript_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                obicanTekst = File.ReadAllText(datoteka);
            }

            try
            {
                string normalanTekst = objektSim.Dekriptiraj(Convert.FromBase64String(obicanTekst));
                txtAESdekript.Text = normalanTekst;
            }
            catch
            {
                MessageBox.Show("Učitana datoteka se ne može dekriptirati!","Upozorenje!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnUcitajKljuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                obicanTekst = File.ReadAllText(datoteka);
            }
            try
            {
                objektSim.kljuc = Convert.FromBase64String(obicanTekst);
                MessageBox.Show("Tajni ključ je učitan!", "Obavijest!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Pogreška pri učitavanju tajnog ključa!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUcitajIV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                obicanTekst = File.ReadAllText(datoteka);
            }

            try
            {
                objektSim.IV = Convert.FromBase64String(obicanTekst);
                MessageBox.Show("IV je učitan!", "Obavijest!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Pogreška pri učitavanju IV-a!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAESkript_Click(object sender, EventArgs e)
        {
            byte [] kriptiraniTekst = objektSim.Kriptiraj(obicanTekst);
            txtAESkript.Text = Convert.ToBase64String(kriptiraniTekst);

            string putanja = @"C:\Users\Domagoj\Desktop\OS2-Projekt\Simetricno\KriptiraniTekst.txt";
            objektSim.SpremiUDatoteku(putanja,kriptiraniTekst);
        }

    }
}
