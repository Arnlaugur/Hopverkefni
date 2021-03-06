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
    public partial class RadaStarfsmann : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public RadaStarfsmann()
        {          
            InitializeComponent();
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /*
         ====================================== 
                     bt_Raða_Click:
         Leyfir yfirmann að ráða nýjan starfsmann
         ef ýtt er á takkan
         ======================================
        */
        private void bt_Raða_Click(object sender, EventArgs e)
        {
            List<string> linur = new List<string>();
            linur.Add(tb_Nafn.Text);
            string notandanafn = null;
            foreach (string lin in linur)
            {               
                string[] linaUrLista = lin.Split(' ');
                string nafn1 = "";
                string nafn2 = "";
                nafn1 = linaUrLista[0];
                if (tb_Nafn.Text.Contains(' '))
                {
                    nafn2 = linaUrLista[1];
                }
                if (nafn2 == "")
                {
                    if (nafn1.Count() >= 6)
                    {
                        notandanafn = nafn1.Substring(0, 6);
                    }
                    else if (nafn1.Count() == 5)
                    {
                        notandanafn = nafn1 + "1";
                    }
                    else if (nafn1.Count() == 4)
                    {
                        notandanafn = nafn1 + "10";
                    }
                    else if (nafn1.Count() == 3)
                    {
                        notandanafn = nafn1 + "100";
                    }                 
                }
                else if (nafn2.Count() <= 3)
                {
                    notandanafn = nafn1.Substring(0, 3) + nafn2 + "1";
                }
                else
                {
                    notandanafn = nafn1.Substring(0, 3) + nafn2.Substring(0, 3);
                }           
            }
           
            gagnagrunnur.SettInnSqlToflu(tb_Nafn.Text , tb_Simi.Text , tb_Email.Text , tb_Hlutverk.Text , notandanafn);     
        }
    }
}
