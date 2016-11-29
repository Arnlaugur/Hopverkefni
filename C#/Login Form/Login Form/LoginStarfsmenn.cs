﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class LoginStarfsmenn : Form
    {
<<<<<<< HEAD
        string Notandi = null;
        string mætting = null;
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public LoginStarfsmenn(string xnafn ,string xNotandi)
=======
        string nafn = null;
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public LoginStarfsmenn(string xnafn, string xNotandi)
>>>>>>> Vegur-Bjarki
        {
            InitializeComponent();
            mætting = gagnagrunnur.mæting(Notandi);
            if (mætting == "0")
            {
                btSkráSemMættur.Text = "Skrá sem mættur";
            }
            else if (mætting == "1")
            {
                btSkráSemMættur.Text = "Útskrá";
            }
            try
            {
                Notandi = xNotandi;
                gagnagrunnur.TengingVidGagnagrunn();
                nafn = xnafn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btSkráSemVeikur_Click(object sender, EventArgs e)
        {
            
            if ( btSkráSemVeikur.Text == "Skrá sem veikur")
            {
                btSkráSemVeikur.Text = "Skrá úr veikindum";

            }
            else if (btSkráSemVeikur.Text == "Skrá úr veikindum")
            {
                btSkráSemVeikur.Text = "Skrá sem veikur";
                
            }
        }

        private void btSkráIFrí_Click(object sender, EventArgs e)
        {
            if (btSkráIFrí.Text == "Skrá í frí")
            {
                btSkráIFrí.Text = "Srká úr fríi";
                
            }
            else if (btSkráIFrí.Text == "Srká úr fríi")
            {
                btSkráIFrí.Text = "Skrá í frí";
                
            }
        }
        
        private void btSkráSemMættur_Click(object sender, EventArgs e)
        {
            
            if (btSkráSemMættur.Text == "Skrá sem mættur")
            {
                btSkráSemMættur.Text = "Útskrá";
                gagnagrunnur.Innskra(Notandi);
            }
            else if (btSkráSemMættur.Text == "Útskrá")
            {
                btSkráSemMættur.Text = "Skrá sem mættur";
                gagnagrunnur.Utskra(Notandi);
            }
        }

        private void LoginStarfsmenn_Load(object sender, EventArgs e)
        {
            labelVelkominn.Text = "Velkomin/n " + nafn;
            labelMotd.Text = "Motd: " + gagnagrunnur.Motd2();
        }
    }
}
