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
    public partial class FrmProduit : Form
    {
        OpenFileDialog op = new OpenFileDialog();
        private MetiersBoutique.Service1Client service = new MetiersBoutique.Service1Client();
        public FrmProduit()
        {
            InitializeComponent();
        }

        private void FrmProduit_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = service.getListeProduit();
            cbxCategorie.DataSource = service.getListeCategorie();
            cbxCategorie.ValueMember = "Id";
            cbxCategorie.DisplayMember = "DesignationCategorie";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.CodeProduit = txtCode.Text;
            p.DesignationProduit = txtDenomination.Text;
            p.IdCategorie = int.Parse(cbxCategorie.SelectedValue.ToString());
            p.Pu = double.Parse(nmcPu.Value.ToString());
            p.QuantiteQritique = int.Parse(nmcQteCritique.Value.ToString());
            p.Image = op.FileName.ToString();
            service.addProduit(p);
            viderChamps();
        }

        public void viderChamps()
        {
            txtCode.Text = String.Empty;
            txtDenomination.Text = String.Empty;
            nmcPu.Value = 0;
            nmcQteCritique.Value = 0;
            ptbImage.Image = null;
            txtCode.Focus();
            dgProduit.DataSource = service.getListeProduit();
            cbxCategorie.DataSource = service.getListeCategorie();
            cbxCategorie.ValueMember = "Id";
            cbxCategorie.DisplayMember = "DesignationCategorie";
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = service.getProduitById(id);
            p.CodeProduit = txtCode.Text;
            p.DesignationProduit = txtDenomination.Text;
            p.IdCategorie = int.Parse(cbxCategorie.SelectedValue.ToString());
            p.Pu = double.Parse(nmcPu.Value.ToString());
            p.QuantiteQritique = int.Parse(nmcQteCritique.Value.ToString());
            p.Image = op.FileName.ToString();
            service.updateProduit(p);
            viderChamps();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            service.deleteProduit(id);
            viderChamps();
        }

        private void btnChoix_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtDenomination.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
            nmcPu.Value = int.Parse(dgProduit.CurrentRow.Cells[4].Value.ToString());
            nmcQteCritique.Value = int.Parse(dgProduit.CurrentRow.Cells[3].Value.ToString());
            ptbImage.Image = new Bitmap(dgProduit.CurrentRow.Cells[5].Value.ToString());
            int idCat = int.Parse(dgProduit.CurrentRow.Cells[6].Value.ToString());
            cbxCategorie.SelectedItem = service.getCategorieById(idCat);
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Bitmap.FromFile(op.FileName);
                    ptbImage.Image = img;
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
