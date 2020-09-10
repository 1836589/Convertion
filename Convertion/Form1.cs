using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertion
{
    public partial class frmConversion : Form
    {
        int m_ValeurConvertie;
        public frmConversion()
        {
            InitializeComponent();
            //m_ValeurConvertie = Convert.ToInt32(txtValeur.Text);

            
        }

        public string ConversionBinaire()
        {
            string Resultat = "";

            while (m_ValeurConvertie > 1)
            {
                int Restant = m_ValeurConvertie % 2;
                Resultat = Convert.ToString(Restant) + Resultat;
                m_ValeurConvertie /= 2;
            }
            Resultat = Convert.ToString(m_ValeurConvertie) + Resultat;

            return Resultat;
        }

        public string ConversionHexa()
        {

            int Valeur = m_ValeurConvertie;
            string Hexa = Valeur.ToString("X");

            return Hexa;
        }

        private void btnBinaire_Click(object sender, EventArgs e)
        {
            m_ValeurConvertie = Convert.ToInt32(txtValeur.Text);
            txtBinaire.Text = ConversionBinaire();
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            m_ValeurConvertie = Convert.ToInt32(txtValeur.Text);
            txtHexa.Text = ConversionHexa();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            m_ValeurConvertie = Convert.ToInt32(txtValeur.Text);
            txtDecimal.Text = m_ValeurConvertie.ToString();
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
