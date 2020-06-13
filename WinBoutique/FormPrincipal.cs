using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetierBoutique.Model;

namespace WinBoutique
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(150, 40);
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            var myControl = new UserControlAccueil();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myControl);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir quitter ? ", 
                    "CRITICAL WARNING",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCategorie.Height;
            SidePanel.Top = btnCategorie.Top;
            var myControl = new UserControlCategorie();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myControl);
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnProduit.Height;
            SidePanel.Top = btnProduit.Top;
            var myControl = new UserControlProduit();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myControl);
        }

        private void btnLivraison_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnLivraison.Height;
            SidePanel.Top = btnLivraison.Top;
            var myControl = new UserControlAccueil();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myControl);
        }

        private void btnAppro_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAppro.Height;
            SidePanel.Top = btnAppro.Top;
            var myControl = new UserControlAccueil();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myControl);
        }

        private void btnPayement_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPayement.Height;
            SidePanel.Top = btnPayement.Top;
            var myControl = new UserControlAccueil();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myControl);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnUser.Height;
            SidePanel.Top = btnUser.Top;
            var myControl = new UserControlAccueil();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myControl);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            var myControl = new UserControlAccueil();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(myControl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
