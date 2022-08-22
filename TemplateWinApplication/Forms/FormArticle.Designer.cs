namespace TemplateWinApplication
{
    partial class FormArticle
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticle));
            this.TxtReference = new System.Windows.Forms.TextBox();
            this.TxtDesignation = new System.Windows.Forms.TextBox();
            this.TxtPrix = new System.Windows.Forms.TextBox();
            this.ChkPromo = new System.Windows.Forms.CheckBox();
            this.DTDateFabrication = new System.Windows.Forms.DateTimePicker();
            this.LbReference = new System.Windows.Forms.Label();
            this.LbDesignation = new System.Windows.Forms.Label();
            this.LbPrix = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.TxtDateFabrication = new System.Windows.Forms.TextBox();
            this.LbCategorie = new System.Windows.Forms.Label();
            this.CmbCategorie = new System.Windows.Forms.ComboBox();
            this.TxtCategorie = new System.Windows.Forms.TextBox();
            this.PanelNouveauModifierSupprimer = new System.Windows.Forms.Panel();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.PanelAjouterAnnuler = new System.Windows.Forms.Panel();
            this.BtnAnnulerAjout = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.PanelValiderAnnuler = new System.Windows.Forms.Panel();
            this.BtnAnnulerModification = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.ToolTipErrorsInfos = new System.Windows.Forms.ToolTip(this.components);
            this.PanelMain.SuspendLayout();
            this.PanelNouveauModifierSupprimer.SuspendLayout();
            this.PanelAjouterAnnuler.SuspendLayout();
            this.PanelValiderAnnuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtReference
            // 
            this.TxtReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReference.Location = new System.Drawing.Point(87, 19);
            this.TxtReference.Name = "TxtReference";
            this.TxtReference.Size = new System.Drawing.Size(100, 20);
            this.TxtReference.TabIndex = 0;
            // 
            // TxtDesignation
            // 
            this.TxtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDesignation.Location = new System.Drawing.Point(87, 45);
            this.TxtDesignation.Name = "TxtDesignation";
            this.TxtDesignation.Size = new System.Drawing.Size(261, 20);
            this.TxtDesignation.TabIndex = 1;
            // 
            // TxtPrix
            // 
            this.TxtPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrix.Location = new System.Drawing.Point(87, 74);
            this.TxtPrix.Name = "TxtPrix";
            this.TxtPrix.Size = new System.Drawing.Size(100, 20);
            this.TxtPrix.TabIndex = 2;
            // 
            // ChkPromo
            // 
            this.ChkPromo.AutoSize = true;
            this.ChkPromo.Location = new System.Drawing.Point(258, 106);
            this.ChkPromo.Name = "ChkPromo";
            this.ChkPromo.Size = new System.Drawing.Size(56, 17);
            this.ChkPromo.TabIndex = 3;
            this.ChkPromo.Text = "Promo";
            this.ChkPromo.UseVisualStyleBackColor = true;
            // 
            // DTDateFabrication
            // 
            this.DTDateFabrication.Location = new System.Drawing.Point(110, 105);
            this.DTDateFabrication.Name = "DTDateFabrication";
            this.DTDateFabrication.Size = new System.Drawing.Size(132, 20);
            this.DTDateFabrication.TabIndex = 4;
            // 
            // LbReference
            // 
            this.LbReference.AutoSize = true;
            this.LbReference.Location = new System.Drawing.Point(24, 22);
            this.LbReference.Name = "LbReference";
            this.LbReference.Size = new System.Drawing.Size(57, 13);
            this.LbReference.TabIndex = 5;
            this.LbReference.Text = "Réference";
            // 
            // LbDesignation
            // 
            this.LbDesignation.AutoSize = true;
            this.LbDesignation.Location = new System.Drawing.Point(24, 48);
            this.LbDesignation.Name = "LbDesignation";
            this.LbDesignation.Size = new System.Drawing.Size(63, 13);
            this.LbDesignation.TabIndex = 6;
            this.LbDesignation.Text = "Désignation";
            // 
            // LbPrix
            // 
            this.LbPrix.AutoSize = true;
            this.LbPrix.Location = new System.Drawing.Point(24, 77);
            this.LbPrix.Name = "LbPrix";
            this.LbPrix.Size = new System.Drawing.Size(24, 13);
            this.LbPrix.TabIndex = 7;
            this.LbPrix.Text = "Prix";
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Location = new System.Drawing.Point(24, 106);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(85, 13);
            this.LbDate.TabIndex = 8;
            this.LbDate.Text = "Date Fabrication";
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Controls.Add(this.TxtDateFabrication);
            this.PanelMain.Controls.Add(this.LbCategorie);
            this.PanelMain.Controls.Add(this.LbDate);
            this.PanelMain.Controls.Add(this.LbPrix);
            this.PanelMain.Controls.Add(this.LbDesignation);
            this.PanelMain.Controls.Add(this.LbReference);
            this.PanelMain.Controls.Add(this.DTDateFabrication);
            this.PanelMain.Controls.Add(this.ChkPromo);
            this.PanelMain.Controls.Add(this.TxtPrix);
            this.PanelMain.Controls.Add(this.TxtDesignation);
            this.PanelMain.Controls.Add(this.TxtReference);
            this.PanelMain.Controls.Add(this.CmbCategorie);
            this.PanelMain.Controls.Add(this.TxtCategorie);
            this.PanelMain.Location = new System.Drawing.Point(38, 12);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(372, 145);
            this.PanelMain.TabIndex = 9;
            // 
            // TxtDateFabrication
            // 
            this.TxtDateFabrication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDateFabrication.Location = new System.Drawing.Point(110, 105);
            this.TxtDateFabrication.Name = "TxtDateFabrication";
            this.TxtDateFabrication.Size = new System.Drawing.Size(132, 20);
            this.TxtDateFabrication.TabIndex = 20;
            // 
            // LbCategorie
            // 
            this.LbCategorie.AutoSize = true;
            this.LbCategorie.Location = new System.Drawing.Point(190, 77);
            this.LbCategorie.Name = "LbCategorie";
            this.LbCategorie.Size = new System.Drawing.Size(52, 13);
            this.LbCategorie.TabIndex = 19;
            this.LbCategorie.Text = "Catégorie";
            // 
            // CmbCategorie
            // 
            this.CmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbCategorie.FormattingEnabled = true;
            this.CmbCategorie.Items.AddRange(new object[] {
            "Meubles",
            "Consommables",
            "Matériels"});
            this.CmbCategorie.Location = new System.Drawing.Point(243, 73);
            this.CmbCategorie.Name = "CmbCategorie";
            this.CmbCategorie.Size = new System.Drawing.Size(105, 21);
            this.CmbCategorie.TabIndex = 18;
            // 
            // TxtCategorie
            // 
            this.TxtCategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCategorie.Location = new System.Drawing.Point(243, 74);
            this.TxtCategorie.Name = "TxtCategorie";
            this.TxtCategorie.Size = new System.Drawing.Size(105, 20);
            this.TxtCategorie.TabIndex = 18;
            // 
            // PanelNouveauModifierSupprimer
            // 
            this.PanelNouveauModifierSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.PanelNouveauModifierSupprimer.Controls.Add(this.BtnSupprimer);
            this.PanelNouveauModifierSupprimer.Controls.Add(this.BtnNouveau);
            this.PanelNouveauModifierSupprimer.Controls.Add(this.BtnModifier);
            this.PanelNouveauModifierSupprimer.Location = new System.Drawing.Point(45, 153);
            this.PanelNouveauModifierSupprimer.Name = "PanelNouveauModifierSupprimer";
            this.PanelNouveauModifierSupprimer.Size = new System.Drawing.Size(359, 50);
            this.PanelNouveauModifierSupprimer.TabIndex = 15;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimer.Image")));
            this.BtnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupprimer.Location = new System.Drawing.Point(239, 9);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(111, 28);
            this.BtnSupprimer.TabIndex = 8;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNouveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("BtnNouveau.Image")));
            this.BtnNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNouveau.Location = new System.Drawing.Point(5, 9);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(111, 28);
            this.BtnNouveau.TabIndex = 6;
            this.BtnNouveau.Text = "Nouveau";
            this.BtnNouveau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNouveau.UseVisualStyleBackColor = true;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnModifier.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.Image")));
            this.BtnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModifier.Location = new System.Drawing.Point(122, 9);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(111, 28);
            this.BtnModifier.TabIndex = 7;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // PanelAjouterAnnuler
            // 
            this.PanelAjouterAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.PanelAjouterAnnuler.Controls.Add(this.BtnAnnulerAjout);
            this.PanelAjouterAnnuler.Controls.Add(this.BtnAjouter);
            this.PanelAjouterAnnuler.Location = new System.Drawing.Point(114, 153);
            this.PanelAjouterAnnuler.Name = "PanelAjouterAnnuler";
            this.PanelAjouterAnnuler.Size = new System.Drawing.Size(240, 51);
            this.PanelAjouterAnnuler.TabIndex = 17;
            // 
            // BtnAnnulerAjout
            // 
            this.BtnAnnulerAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnulerAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnAnnulerAjout.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnulerAjout.Image")));
            this.BtnAnnulerAjout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnnulerAjout.Location = new System.Drawing.Point(122, 9);
            this.BtnAnnulerAjout.Name = "BtnAnnulerAjout";
            this.BtnAnnulerAjout.Size = new System.Drawing.Size(111, 28);
            this.BtnAnnulerAjout.TabIndex = 7;
            this.BtnAnnulerAjout.Text = "Annuler";
            this.BtnAnnulerAjout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnnulerAjout.UseVisualStyleBackColor = true;
            this.BtnAnnulerAjout.Click += new System.EventHandler(this.BtnAnnulerAjout_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("BtnAjouter.Image")));
            this.BtnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjouter.Location = new System.Drawing.Point(5, 9);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(111, 28);
            this.BtnAjouter.TabIndex = 6;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // PanelValiderAnnuler
            // 
            this.PanelValiderAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.PanelValiderAnnuler.Controls.Add(this.BtnAnnulerModification);
            this.PanelValiderAnnuler.Controls.Add(this.BtnValider);
            this.PanelValiderAnnuler.Location = new System.Drawing.Point(114, 155);
            this.PanelValiderAnnuler.Name = "PanelValiderAnnuler";
            this.PanelValiderAnnuler.Size = new System.Drawing.Size(240, 49);
            this.PanelValiderAnnuler.TabIndex = 6;
            // 
            // BtnAnnulerModification
            // 
            this.BtnAnnulerModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnulerModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerModification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnAnnulerModification.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnulerModification.Image")));
            this.BtnAnnulerModification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnnulerModification.Location = new System.Drawing.Point(122, 9);
            this.BtnAnnulerModification.Name = "BtnAnnulerModification";
            this.BtnAnnulerModification.Size = new System.Drawing.Size(111, 28);
            this.BtnAnnulerModification.TabIndex = 7;
            this.BtnAnnulerModification.Text = "Annuler";
            this.BtnAnnulerModification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAnnulerModification.UseVisualStyleBackColor = true;
            this.BtnAnnulerModification.Click += new System.EventHandler(this.BtnAnnulerModification_Click);
            // 
            // BtnValider
            // 
            this.BtnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnValider.Image = ((System.Drawing.Image)(resources.GetObject("BtnValider.Image")));
            this.BtnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnValider.Location = new System.Drawing.Point(5, 9);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(111, 28);
            this.BtnValider.TabIndex = 6;
            this.BtnValider.Text = "Valider";
            this.BtnValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // FormArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 216);
            this.Controls.Add(this.PanelNouveauModifierSupprimer);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelAjouterAnnuler);
            this.Controls.Add(this.PanelValiderAnnuler);
            this.Name = "FormArticle";
            this.Text = "Article";
            this.Load += new System.EventHandler(this.FormArticle_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelNouveauModifierSupprimer.ResumeLayout(false);
            this.PanelAjouterAnnuler.ResumeLayout(false);
            this.PanelValiderAnnuler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtReference;
        private System.Windows.Forms.TextBox TxtDesignation;
        private System.Windows.Forms.TextBox TxtPrix;
        private System.Windows.Forms.CheckBox ChkPromo;
        private System.Windows.Forms.DateTimePicker DTDateFabrication;
        private System.Windows.Forms.Label LbReference;
        private System.Windows.Forms.Label LbDesignation;
        private System.Windows.Forms.Label LbPrix;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.ComboBox CmbCategorie;
        private System.Windows.Forms.TextBox TxtCategorie;
        private System.Windows.Forms.Label LbCategorie;
        private System.Windows.Forms.Panel PanelNouveauModifierSupprimer;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnNouveau;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Panel PanelAjouterAnnuler;
        private System.Windows.Forms.Button BtnAnnulerAjout;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Panel PanelValiderAnnuler;
        private System.Windows.Forms.Button BtnAnnulerModification;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.TextBox TxtDateFabrication;
        private System.Windows.Forms.ToolTip ToolTipErrorsInfos;
    }
}

