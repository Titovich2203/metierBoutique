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
    public partial class Form1 : Form
    {
        MetiersBoutique.Service1Client service = new MetiersBoutique.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void Effacer()
        {
            txtDesignation.Text = string.Empty;
            txtCode.Text = string.Empty;
            dgCategorie.DataSource = service.getListeCategorie();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgCategorie.DataSource = service.getListeCategorie();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Categorie c = new Categorie();
            c.CodeCategorie = txtCode.Text;
            c.DesignationCategorie = txtDesignation.Text;
            service.addCategorie(c);
            Effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgCategorie.CurrentRow.Cells[1].Value.ToString();
            txtDesignation.Text = dgCategorie.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int idCategorie = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            Categorie c = service.getCategorieById(idCategorie);
            c.CodeCategorie = txtCode.Text;
            c.DesignationCategorie = txtDesignation.Text;
            service.updateCategorie(c);
            Effacer();
        }

        private void btnSuprprimer_Click(object sender, EventArgs e)
        {
            int idCategorie = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            service.deleteCategorie(idCategorie);
            Effacer();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
