using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalniPotpis
{
    public partial class GlavniIzbornikForm : Form
    {
        public GlavniIzbornikForm()
        {
            InitializeComponent();
        }

        private void btnSimetricno_Click(object sender, EventArgs e)
        {
            SimetricnoKriptForma forma = new SimetricnoKriptForma();
            forma.ShowDialog();
        }

        private void btnAsimetricno_Click(object sender, EventArgs e)
        {
            AsimetricnoForm forma = new AsimetricnoForm();
            forma.ShowDialog();
        }

        private void btnDigitalniPotpis_Click(object sender, EventArgs e)
        {
            DigitalniPotpisForm forma = new DigitalniPotpisForm();
            forma.ShowDialog();
        }
    }
}
