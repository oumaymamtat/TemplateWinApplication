namespace TemplateWinApplication
{
    partial class FormListeArticles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVArticles = new System.Windows.Forms.DataGridView();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFabrication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVArticles
            // 
            this.DGVArticles.AllowUserToAddRows = false;
            this.DGVArticles.AllowUserToDeleteRows = false;
            this.DGVArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reference,
            this.Designation,
            this.Categorie,
            this.Prix,
            this.DateFabrication,
            this.Promo});
            this.DGVArticles.Location = new System.Drawing.Point(27, 38);
            this.DGVArticles.Name = "DGVArticles";
            this.DGVArticles.ReadOnly = true;
            this.DGVArticles.RowHeadersVisible = false;
            this.DGVArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVArticles.Size = new System.Drawing.Size(653, 150);
            this.DGVArticles.TabIndex = 0;
            // 
            // Reference
            // 
            this.Reference.DataPropertyName = "Reference";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Reference.DefaultCellStyle = dataGridViewCellStyle6;
            this.Reference.HeaderText = "Référence";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "Designation";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Designation.DefaultCellStyle = dataGridViewCellStyle7;
            this.Designation.HeaderText = "Désignation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // Categorie
            // 
            this.Categorie.DataPropertyName = "Categorie";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Categorie.DefaultCellStyle = dataGridViewCellStyle8;
            this.Categorie.HeaderText = "Catégorie";
            this.Categorie.Name = "Categorie";
            this.Categorie.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "Prix";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Prix.DefaultCellStyle = dataGridViewCellStyle9;
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // DateFabrication
            // 
            this.DateFabrication.DataPropertyName = "DateFabrication";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateFabrication.DefaultCellStyle = dataGridViewCellStyle10;
            this.DateFabrication.FillWeight = 200F;
            this.DateFabrication.HeaderText = "Date de fabrication";
            this.DateFabrication.Name = "DateFabrication";
            this.DateFabrication.ReadOnly = true;
            this.DateFabrication.Width = 150;
            // 
            // Promo
            // 
            this.Promo.DataPropertyName = "Promo";
            this.Promo.HeaderText = "Promo";
            this.Promo.Name = "Promo";
            this.Promo.ReadOnly = true;
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.Location = new System.Drawing.Point(523, 194);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(75, 23);
            this.BtnNouveau.TabIndex = 1;
            this.BtnNouveau.Text = "Nouveau";
            this.BtnNouveau.UseVisualStyleBackColor = true;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // BtnDetails
            // 
            this.BtnDetails.Location = new System.Drawing.Point(604, 194);
            this.BtnDetails.Name = "BtnDetails";
            this.BtnDetails.Size = new System.Drawing.Size(75, 23);
            this.BtnDetails.TabIndex = 2;
            this.BtnDetails.Text = "Détails";
            this.BtnDetails.UseVisualStyleBackColor = true;
            this.BtnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // FormListeArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 232);
            this.Controls.Add(this.BtnDetails);
            this.Controls.Add(this.BtnNouveau);
            this.Controls.Add(this.DGVArticles);
            this.Name = "FormListeArticles";
            this.Text = "FormListeArticles";
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVArticles;
        private System.Windows.Forms.Button BtnNouveau;
        private System.Windows.Forms.Button BtnDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFabrication;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Promo;
    }
}