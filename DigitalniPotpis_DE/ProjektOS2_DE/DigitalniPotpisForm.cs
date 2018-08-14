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

namespace DigitalniPotpis
{
    public partial class DigitalniPotpisForm : Form
    {
        public DigitalniPotpisForm()
        {
            InitializeComponent();
        }

        string obicanTekst="",javniKljuc="",potpis="";
        byte[] sazetak,kreiraniPotpis;

        DigitalniPotpis objektDigitaniPotpis = new DigitalniPotpis();
        private void btnUcitajDatotekuDigitalniPotpis_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                obicanTekst = File.ReadAllText(datoteka);
            }
            txtIspisIzvorno.Text = obicanTekst;
        }

        private void btnIzracunajSazetak_Click(object sender, EventArgs e)
        {
            sazetak=objektDigitaniPotpis.IzracunajSazetak(obicanTekst);
            txtSazetak.Text = Convert.ToBase64String(sazetak);
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            try
            {
                if (objektDigitaniPotpis.Provjera(sazetak) == true)
                    MessageBox.Show("Potpis je ispravan!", "Obavijest!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Izvorni tekst ili potpis su izmijenjeni!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Nisu učitani svi parametri potrebni za provjeru!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUcitajJavniKljuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                javniKljuc = File.ReadAllText(datoteka);
            }
            try
            {
                objektDigitaniPotpis.ucitaniJavniKljuc = javniKljuc;
                MessageBox.Show("Javni ključ je učitan!", "Obavijest!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Pogreška pri učitavanju javnog ključa!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUcitajPotpis_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string datoteka = ofd.FileName;
                potpis = File.ReadAllText(datoteka);
            }
            try
            {
                txtPotpis.Text = potpis;
                objektDigitaniPotpis.potpis = Convert.FromBase64String(potpis);
                MessageBox.Show("Potpis je učitan!", "Obavijest!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Pogreška pri učitavanju potpisa!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPotpisiDokument_Click(object sender, EventArgs e)
        {
            try
            {
                kreiraniPotpis = objektDigitaniPotpis.Potpis(sazetak);
                txtPotpis.Text = Convert.ToBase64String(kreiraniPotpis);
            }
            catch
            {
                MessageBox.Show("Nisu učitani svi parametri za potpis!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


    }
}
