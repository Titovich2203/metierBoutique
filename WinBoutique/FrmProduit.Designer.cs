namespace WinBoutique
{
    partial class FrmProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoix = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.lblCritique = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmcPu = new System.Windows.Forms.NumericUpDown();
            this.txtDenomination = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmcQteCritique = new System.Windows.Forms.NumericUpDown();
            this.lblDenom = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCategorie = new System.Windows.Forms.ComboBox();
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQteCritique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "Image";
            // 
            // btnChoix
            // 
            this.btnChoix.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoix.Location = new System.Drawing.Point(752, 207);
            this.btnChoix.Name = "btnChoix";
            this.btnChoix.Size = new System.Drawing.Size(80, 28);
            this.btnChoix.TabIndex = 72;
            this.btnChoix.Text = "CHOISIR";
            this.btnChoix.UseVisualStyleBackColor = true;
            this.btnChoix.Click += new System.EventHandler(this.btnChoix_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(510, 541);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(95, 34);
            this.btnSupprimer.TabIndex = 71;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(324, 541);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(86, 34);
            this.btnModifier.TabIndex = 70;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(136, 541);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(76, 34);
            this.btnAjouter.TabIndex = 69;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnParcourir
            // 
            this.btnParcourir.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParcourir.Location = new System.Drawing.Point(245, 472);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(76, 30);
            this.btnParcourir.TabIndex = 68;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // ptbImage
            // 
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImage.Location = new System.Drawing.Point(40, 409);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(178, 93);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 67;
            this.ptbImage.TabStop = false;
            // 
            // lblCritique
            // 
            this.lblCritique.AutoSize = true;
            this.lblCritique.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCritique.Location = new System.Drawing.Point(521, 411);
            this.lblCritique.Name = "lblCritique";
            this.lblCritique.Size = new System.Drawing.Size(130, 19);
            this.lblCritique.TabIndex = 66;
            this.lblCritique.Text = "QUANTITE CRITIQUE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-152, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "IMAGE";
            // 
            // nmcPu
            // 
            this.nmcPu.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcPu.Location = new System.Drawing.Point(524, 331);
            this.nmcPu.Name = "nmcPu";
            this.nmcPu.Size = new System.Drawing.Size(308, 26);
            this.nmcPu.TabIndex = 64;
            // 
            // txtDenomination
            // 
            this.txtDenomination.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDenomination.Location = new System.Drawing.Point(524, 255);
            this.txtDenomination.Multiline = true;
            this.txtDenomination.Name = "txtDenomination";
            this.txtDenomination.Size = new System.Drawing.Size(311, 28);
            this.txtDenomination.TabIndex = 63;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(40, 255);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(281, 28);
            this.txtCode.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(521, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 61;
            this.label5.Text = "PRIX UNITAIRE";
            // 
            // nmcQteCritique
            // 
            this.nmcQteCritique.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcQteCritique.Location = new System.Drawing.Point(524, 436);
            this.nmcQteCritique.Name = "nmcQteCritique";
            this.nmcQteCritique.Size = new System.Drawing.Size(311, 26);
            this.nmcQteCritique.TabIndex = 60;
            // 
            // lblDenom
            // 
            this.lblDenom.AutoSize = true;
            this.lblDenom.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenom.Location = new System.Drawing.Point(524, 235);
            this.lblDenom.Name = "lblDenom";
            this.lblDenom.Size = new System.Drawing.Size(109, 19);
            this.lblDenom.TabIndex = 59;
            this.lblDenom.Text = "DENOMINATION";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(38, 228);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(47, 19);
            this.lblCode.TabIndex = 58;
            this.lblCode.Text = "CODE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "CATEGORIE";
            // 
            // cbxCategorie
            // 
            this.cbxCategorie.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategorie.FormattingEnabled = true;
            this.cbxCategorie.Location = new System.Drawing.Point(37, 330);
            this.cbxCategorie.Name = "cbxCategorie";
            this.cbxCategorie.Size = new System.Drawing.Size(281, 27);
            this.cbxCategorie.TabIndex = 56;
            // 
            // dgProduit
            // 
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(34, 12);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.Size = new System.Drawing.Size(798, 189);
            this.dgProduit.TabIndex = 55;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Brandon Grotesque Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(675, 541);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(88, 32);
            this.btnQuitter.TabIndex = 74;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 591);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChoix);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnParcourir);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.lblCritique);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmcPu);
            this.Controls.Add(this.txtDenomination);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmcQteCritique);
            this.Controls.Add(this.lblDenom);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCategorie);
            this.Controls.Add(this.dgProduit);
            this.Name = "FrmProduit";
            this.Text = "FrmProduit";
            this.Load += new System.EventHandler(this.FrmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcQteCritique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChoix;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.Label lblCritique;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmcPu;
        private System.Windows.Forms.TextBox txtDenomination;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmcQteCritique;
        private System.Windows.Forms.Label lblDenom;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCategorie;
        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.Button btnQuitter;
    }
}