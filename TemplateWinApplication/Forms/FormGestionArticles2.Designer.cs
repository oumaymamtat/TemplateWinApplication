namespace TemplateWinApplication
{
    partial class FormGestionArticles2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionArticles2));
            this.DGVArticles = new System.Windows.Forms.DataGridView();
            this.PanelEnteteGrille = new System.Windows.Forms.Panel();
            this.LbListeDesCategories = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelDetails = new System.Windows.Forms.Panel();
            this.PanelAjouterAnnuler = new System.Windows.Forms.Panel();
            this.BtnAnnulerAjout = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.PanelValiderAnnuler = new System.Windows.Forms.Panel();
            this.BtnAnnulerModification = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.PanelEdition = new System.Windows.Forms.Panel();
            this.TxtDateFabrication = new System.Windows.Forms.TextBox();
            this.LbMessageEdition = new System.Windows.Forms.Label();
            this.LbCategorie = new System.Windows.Forms.Label();
            this.LbDesignation = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.TxtCategorie = new System.Windows.Forms.TextBox();
            this.LbPrix = new System.Windows.Forms.Label();
            this.CmbCategorie = new System.Windows.Forms.ComboBox();
            this.TxtReference = new System.Windows.Forms.TextBox();
            this.LbReference = new System.Windows.Forms.Label();
            this.TxtDesignation = new System.Windows.Forms.TextBox();
            this.DTDateFabrication = new System.Windows.Forms.DateTimePicker();
            this.TxtPrix = new System.Windows.Forms.TextBox();
            this.ChkPromo = new System.Windows.Forms.CheckBox();
            this.ToolTipErrorsInfos = new System.Windows.Forms.ToolTip(this.components);
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelNouveauModifierSupprimer = new System.Windows.Forms.Panel();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).BeginInit();
            this.PanelEnteteGrille.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.PanelDetails.SuspendLayout();
            this.PanelAjouterAnnuler.SuspendLayout();
            this.PanelValiderAnnuler.SuspendLayout();
            this.PanelEdition.SuspendLayout();
            this.PanelNouveauModifierSupprimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVArticles
            // 
            this.DGVArticles.AllowUserToAddRows = false;
            this.DGVArticles.AllowUserToDeleteRows = false;
            this.DGVArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Designation});
            this.DGVArticles.Location = new System.Drawing.Point(10, 41);
            this.DGVArticles.MultiSelect = false;
            this.DGVArticles.Name = "DGVArticles";
            this.DGVArticles.ReadOnly = true;
            this.DGVArticles.RowHeadersVisible = false;
            this.DGVArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVArticles.Size = new System.Drawing.Size(205, 262);
            this.DGVArticles.TabIndex = 1;
            this.DGVArticles.SelectionChanged += new System.EventHandler(this.DGVArticles_SelectionChanged);
            // 
            // PanelEnteteGrille
            // 
            this.PanelEnteteGrille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.PanelEnteteGrille.Controls.Add(this.LbListeDesCategories);
            this.PanelEnteteGrille.Location = new System.Drawing.Point(0, 0);
            this.PanelEnteteGrille.Name = "PanelEnteteGrille";
            this.PanelEnteteGrille.Size = new System.Drawing.Size(999, 27);
            this.PanelEnteteGrille.TabIndex = 287;
            // 
            // LbListeDesCategories
            // 
            this.LbListeDesCategories.AutoSize = true;
            this.LbListeDesCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListeDesCategories.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LbListeDesCategories.Location = new System.Drawing.Point(11, 6);
            this.LbListeDesCategories.Name = "LbListeDesCategories";
            this.LbListeDesCategories.Size = new System.Drawing.Size(126, 16);
            this.LbListeDesCategories.TabIndex = 231;
            this.LbListeDesCategories.Text = "Liste des articles";
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelMain.Controls.Add(this.PanelValiderAnnuler);
            this.PanelMain.Controls.Add(this.PanelNouveauModifierSupprimer);
            this.PanelMain.Controls.Add(this.PanelAjouterAnnuler);
            this.PanelMain.Controls.Add(this.PanelEnteteGrille);
            this.PanelMain.Controls.Add(this.PanelDetails);
            this.PanelMain.Controls.Add(this.DGVArticles);
            this.PanelMain.Location = new System.Drawing.Point(28, 26);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1001, 330);
            this.PanelMain.TabIndex = 291;
            // 
            // PanelDetails
            // 
            this.PanelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelDetails.Controls.Add(this.PanelEdition);
            this.PanelDetails.Location = new System.Drawing.Point(235, 44);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(622, 259);
            this.PanelDetails.TabIndex = 291;
            // 
            // PanelAjouterAnnuler
            // 
            this.PanelAjouterAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.PanelAjouterAnnuler.Controls.Add(this.BtnAnnulerAjout);
            this.PanelAjouterAnnuler.Controls.Add(this.BtnAjouter);
            this.PanelAjouterAnnuler.Location = new System.Drawing.Point(863, 44);
            this.PanelAjouterAnnuler.Name = "PanelAjouterAnnuler";
            this.PanelAjouterAnnuler.Size = new System.Drawing.Size(122, 91);
            this.PanelAjouterAnnuler.TabIndex = 294;
            // 
            // BtnAnnulerAjout
            // 
            this.BtnAnnulerAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnulerAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnAnnulerAjout.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnulerAjout.Image")));
            this.BtnAnnulerAjout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnnulerAjout.Location = new System.Drawing.Point(5, 43);
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
            this.PanelValiderAnnuler.Location = new System.Drawing.Point(864, 45);
            this.PanelValiderAnnuler.Name = "PanelValiderAnnuler";
            this.PanelValiderAnnuler.Size = new System.Drawing.Size(122, 91);
            this.PanelValiderAnnuler.TabIndex = 292;
            // 
            // BtnAnnulerModification
            // 
            this.BtnAnnulerModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnulerModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerModification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnAnnulerModification.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnulerModification.Image")));
            this.BtnAnnulerModification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnnulerModification.Location = new System.Drawing.Point(5, 43);
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
            // PanelEdition
            // 
            this.PanelEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelEdition.Controls.Add(this.TxtDateFabrication);
            this.PanelEdition.Controls.Add(this.LbMessageEdition);
            this.PanelEdition.Controls.Add(this.LbCategorie);
            this.PanelEdition.Controls.Add(this.LbDesignation);
            this.PanelEdition.Controls.Add(this.LbDate);
            this.PanelEdition.Controls.Add(this.TxtCategorie);
            this.PanelEdition.Controls.Add(this.LbPrix);
            this.PanelEdition.Controls.Add(this.CmbCategorie);
            this.PanelEdition.Controls.Add(this.TxtReference);
            this.PanelEdition.Controls.Add(this.LbReference);
            this.PanelEdition.Controls.Add(this.TxtDesignation);
            this.PanelEdition.Controls.Add(this.DTDateFabrication);
            this.PanelEdition.Controls.Add(this.TxtPrix);
            this.PanelEdition.Controls.Add(this.ChkPromo);
            this.PanelEdition.Location = new System.Drawing.Point(41, 69);
            this.PanelEdition.Name = "PanelEdition";
            this.PanelEdition.Size = new System.Drawing.Size(547, 105);
            this.PanelEdition.TabIndex = 291;
            // 
            // TxtDateFabrication
            // 
            this.TxtDateFabrication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDateFabrication.Location = new System.Drawing.Point(108, 73);
            this.TxtDateFabrication.Name = "TxtDateFabrication";
            this.TxtDateFabrication.Size = new System.Drawing.Size(132, 20);
            this.TxtDateFabrication.TabIndex = 20;
            // 
            // LbMessageEdition
            // 
            this.LbMessageEdition.AutoSize = true;
            this.LbMessageEdition.Location = new System.Drawing.Point(3, 9);
            this.LbMessageEdition.Name = "LbMessageEdition";
            this.LbMessageEdition.Size = new System.Drawing.Size(0, 13);
            this.LbMessageEdition.TabIndex = 23;
            // 
            // LbCategorie
            // 
            this.LbCategorie.AutoSize = true;
            this.LbCategorie.Location = new System.Drawing.Point(204, 44);
            this.LbCategorie.Name = "LbCategorie";
            this.LbCategorie.Size = new System.Drawing.Size(52, 13);
            this.LbCategorie.TabIndex = 19;
            this.LbCategorie.Text = "Catégorie";
            // 
            // LbDesignation
            // 
            this.LbDesignation.AutoSize = true;
            this.LbDesignation.Location = new System.Drawing.Point(204, 18);
            this.LbDesignation.Name = "LbDesignation";
            this.LbDesignation.Size = new System.Drawing.Size(63, 13);
            this.LbDesignation.TabIndex = 6;
            this.LbDesignation.Text = "Désignation";
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Location = new System.Drawing.Point(22, 75);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(85, 13);
            this.LbDate.TabIndex = 8;
            this.LbDate.Text = "Date Fabrication";
            // 
            // TxtCategorie
            // 
            this.TxtCategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCategorie.Location = new System.Drawing.Point(267, 41);
            this.TxtCategorie.Name = "TxtCategorie";
            this.TxtCategorie.Size = new System.Drawing.Size(261, 20);
            this.TxtCategorie.TabIndex = 18;
            // 
            // LbPrix
            // 
            this.LbPrix.AutoSize = true;
            this.LbPrix.Location = new System.Drawing.Point(22, 44);
            this.LbPrix.Name = "LbPrix";
            this.LbPrix.Size = new System.Drawing.Size(24, 13);
            this.LbPrix.TabIndex = 7;
            this.LbPrix.Text = "Prix";
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
            this.CmbCategorie.Location = new System.Drawing.Point(267, 41);
            this.CmbCategorie.Name = "CmbCategorie";
            this.CmbCategorie.Size = new System.Drawing.Size(261, 21);
            this.CmbCategorie.TabIndex = 18;
            // 
            // TxtReference
            // 
            this.TxtReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReference.Location = new System.Drawing.Point(85, 15);
            this.TxtReference.Name = "TxtReference";
            this.TxtReference.Size = new System.Drawing.Size(100, 20);
            this.TxtReference.TabIndex = 0;
            // 
            // LbReference
            // 
            this.LbReference.AutoSize = true;
            this.LbReference.Location = new System.Drawing.Point(22, 18);
            this.LbReference.Name = "LbReference";
            this.LbReference.Size = new System.Drawing.Size(57, 13);
            this.LbReference.TabIndex = 5;
            this.LbReference.Text = "Réference";
            // 
            // TxtDesignation
            // 
            this.TxtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDesignation.Location = new System.Drawing.Point(267, 15);
            this.TxtDesignation.Name = "TxtDesignation";
            this.TxtDesignation.Size = new System.Drawing.Size(261, 20);
            this.TxtDesignation.TabIndex = 1;
            // 
            // DTDateFabrication
            // 
            this.DTDateFabrication.Location = new System.Drawing.Point(108, 73);
            this.DTDateFabrication.Name = "DTDateFabrication";
            this.DTDateFabrication.Size = new System.Drawing.Size(132, 20);
            this.DTDateFabrication.TabIndex = 4;
            // 
            // TxtPrix
            // 
            this.TxtPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrix.Location = new System.Drawing.Point(85, 41);
            this.TxtPrix.Name = "TxtPrix";
            this.TxtPrix.Size = new System.Drawing.Size(100, 20);
            this.TxtPrix.TabIndex = 2;
            // 
            // ChkPromo
            // 
            this.ChkPromo.AutoSize = true;
            this.ChkPromo.Location = new System.Drawing.Point(267, 74);
            this.ChkPromo.Name = "ChkPromo";
            this.ChkPromo.Size = new System.Drawing.Size(56, 17);
            this.ChkPromo.TabIndex = 3;
            this.ChkPromo.Text = "Promo";
            this.ChkPromo.UseVisualStyleBackColor = true;
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "Reference";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Reference.DefaultCellStyle = dataGridViewCellStyle5;
            this.Reference.HeaderText = "Référence";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "Designation";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Designation.DefaultCellStyle = dataGridViewCellStyle6;
            this.Designation.HeaderText = "Désignation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // PanelNouveauModifierSupprimer
            // 
            this.PanelNouveauModifierSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.PanelNouveauModifierSupprimer.Controls.Add(this.BtnNouveau);
            this.PanelNouveauModifierSupprimer.Controls.Add(this.BtnSupprimer);
            this.PanelNouveauModifierSupprimer.Controls.Add(this.BtnModifier);
            this.PanelNouveauModifierSupprimer.Location = new System.Drawing.Point(863, 44);
            this.PanelNouveauModifierSupprimer.Name = "PanelNouveauModifierSupprimer";
            this.PanelNouveauModifierSupprimer.Size = new System.Drawing.Size(124, 116);
            this.PanelNouveauModifierSupprimer.TabIndex = 295;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(56)))), ((int)(((byte)(84)))));
            this.BtnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("BtnSupprimer.Image")));
            this.BtnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupprimer.Location = new System.Drawing.Point(5, 80);
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
            this.BtnModifier.Location = new System.Drawing.Point(5, 46);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(111, 28);
            this.BtnModifier.TabIndex = 7;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // FormGestionArticles2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 391);
            this.Controls.Add(this.PanelMain);
            this.Name = "FormGestionArticles2";
            this.Text = "FormGestionArticles";
            this.Load += new System.EventHandler(this.FormGestionArticles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).EndInit();
            this.PanelEnteteGrille.ResumeLayout(false);
            this.PanelEnteteGrille.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelDetails.ResumeLayout(false);
            this.PanelAjouterAnnuler.ResumeLayout(false);
            this.PanelValiderAnnuler.ResumeLayout(false);
            this.PanelEdition.ResumeLayout(false);
            this.PanelEdition.PerformLayout();
            this.PanelNouveauModifierSupprimer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVArticles;
        private System.Windows.Forms.Panel PanelEnteteGrille;
        private System.Windows.Forms.Label LbListeDesCategories;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelDetails;
        private System.Windows.Forms.Panel PanelEdition;
        private System.Windows.Forms.TextBox TxtDateFabrication;
        private System.Windows.Forms.Label LbMessageEdition;
        private System.Windows.Forms.Label LbCategorie;
        private System.Windows.Forms.Label LbDesignation;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.TextBox TxtCategorie;
        private System.Windows.Forms.Label LbPrix;
        private System.Windows.Forms.ComboBox CmbCategorie;
        private System.Windows.Forms.TextBox TxtReference;
        private System.Windows.Forms.Label LbReference;
        private System.Windows.Forms.TextBox TxtDesignation;
        private System.Windows.Forms.DateTimePicker DTDateFabrication;
        private System.Windows.Forms.TextBox TxtPrix;
        private System.Windows.Forms.CheckBox ChkPromo;
        private System.Windows.Forms.Panel PanelAjouterAnnuler;
        private System.Windows.Forms.Button BtnAnnulerAjout;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Panel PanelValiderAnnuler;
        private System.Windows.Forms.Button BtnAnnulerModification;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.ToolTip ToolTipErrorsInfos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.Panel PanelNouveauModifierSupprimer;
        private System.Windows.Forms.Button BtnNouveau;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
    }
}