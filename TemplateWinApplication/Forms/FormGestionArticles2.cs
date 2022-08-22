using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyUtilities;
using System.Data.SqlServerCe;

namespace TemplateWinApplication
{
    public partial class FormGestionArticles2 : Form
    {
         /********************************************************************************************************
     ********************************************************************************************************
     *
     *                                             Attributs & Constructors
     * 
     ********************************************************************************************************
     ********************************************************************************************************/

        #region Attributes & Constructors
        
        Article CurrentArticle;
        Article NewArticle;
        ArticlesList Articles;
        UseModes CurrentUseMode;
        List<ErrorCtrlMsg> FrmErrorCtrls;
        Control[] ConsultationModeDependentControls;
        Control[] AddEditModeDependentControls;

        private void InitForm()
        {
            InitializeComponent();
            this.FrmErrorCtrls = new List<ErrorCtrlMsg>();
            AddEditModeDependentControls = new Control[] { this.CmbCategorie, this.DTDateFabrication };
            ConsultationModeDependentControls = new Control[] { this.TxtCategorie, this.TxtDateFabrication };
        }
        
        public FormGestionArticles2()
        {           
            try
            {
                InitForm();
                this.NewArticle = new Article(); 
                this.CurrentArticle = new Article();               
                this.BindDataToDGVArticles();
                this.SetUseMode(UseModes.Consultation);
            }
            catch (MyException MyEx)
            {
                MessageBox.Show(MyEx.MyExceptionMessage, "GA : " + MyEx.MyExceptionTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #endregion
      

        /********************************************************************************************************
        ********************************************************************************************************
        *
        *                                             Utilities Methods
        * 
        ********************************************************************************************************
        ********************************************************************************************************/

        #region Utilities Methods

        private void InitializeStartPosition()
        {
            //this.Location = new Point((this.Parent.ClientSize.Width - this.Width) / 2, 50);           
        }

        private void SetModeToReadOnly(bool Value)
        {
            // Cacher les combobox            
            TextBox[] ParamControls = { 
                                        this.TxtReference,
                                        this.TxtDesignation,
                                        this.TxtCategorie,
                                        this.TxtPrix,
                                        this.TxtDateFabrication,                                                                               
                                      };
            AppearanceHandler.SetReadOnlyAppearance(ParamControls, Value);

            this.ChkPromo.AutoCheck = !Value;
        }

        private void SetUseMode(UseModes ParamUseMode)
        {
            this.CurrentUseMode = ParamUseMode;
            this.SuspendLayout();

            switch (this.CurrentUseMode)
            {
                case UseModes.AddingNew:
                    {
                        this.Text = "GA : Gestion des articles - Ajout d'un nouvel article";
                        this.PanelDetails.Visible = true;
                        
                        this.TxtReference.Focus();
                        AppearanceHandler.HideControls(ConsultationModeDependentControls);
                        AppearanceHandler.ShowControls(AddEditModeDependentControls);
                        this.PanelNouveauModifierSupprimer.Visible = false;
                        this.PanelAjouterAnnuler.Visible = true;
                        this.PanelValiderAnnuler.Visible = false;

                        this.DGVArticles.Enabled = false;
                        this.SetModeToReadOnly(false);
                        this.ResetControls();
                        this.CmbCategorie.SelectedIndex = 0;
                        break;
                    }

                case UseModes.Consultation:
                    {
                        this.Text = "GA : Gestion des articles - Consultation";
                        this.PanelDetails.Visible = true;
                                         

                        AppearanceHandler.HideControls(AddEditModeDependentControls);
                        AppearanceHandler.ShowControls(ConsultationModeDependentControls);
                        this.PanelNouveauModifierSupprimer.Visible = true;
                        this.PanelAjouterAnnuler.Visible = false;
                        this.PanelValiderAnnuler.Visible = false;

                        this.DGVArticles.Enabled = true;
                        this.SetModeToReadOnly(true);
                        break;
                    }

                case UseModes.Modification:
                    {

                        this.Text = "GA : Gestion des articles - Modification";
                        this.PanelDetails.Visible = true;
                      
                        this.TxtReference.Focus();
                        AppearanceHandler.HideControls(ConsultationModeDependentControls);
                        AppearanceHandler.ShowControls(AddEditModeDependentControls);
                        this.PanelNouveauModifierSupprimer.Visible = false;
                        this.PanelAjouterAnnuler.Visible = false;
                        this.PanelValiderAnnuler.Visible = true;

                        this.DGVArticles.Enabled = false;
                        this.SetModeToReadOnly(false);
                        break;
                    }
            }
            this.ResumeLayout();
        }

        private void ResetControls()
        {
            this.TxtReference.Clear();
            this.TxtDesignation.Clear();
            this.TxtPrix.Clear();
        }

        private Article GetDataFromInterface()
        {
            Article a = new Article();

            a.Reference = Convert.ToInt32(this.TxtReference.Text.Trim());
            a.Designation = this.TxtDesignation.Text.Trim();
            a.Categorie = this.CmbCategorie.Text.Trim();

            // Pour les champs qui acceptent la valeur nulle
            if (this.TxtPrix.Text != "")
                a.Prix = Convert.ToSingle(this.TxtPrix.Text.Trim());
            else
                a.Prix = null;

            a.DateFabrication = this.DTDateFabrication.Value.Date;
            a.Promo = this.ChkPromo.Checked;

            return a;
        }

        private void BindDataToInterface(Article pa)
        {
            this.TxtReference.Text = pa.Reference.ToString();
            this.TxtDesignation.Text = pa.Designation;
            this.CmbCategorie.Text = this.TxtCategorie.Text = pa.Categorie;

            if (pa.Prix == null)
                this.TxtPrix.Text = "";
            else
                this.TxtPrix.Text = pa.Prix.ToString();

            if (pa.DateFabrication != null)
            {
                this.DTDateFabrication.Value = pa.DateFabrication;
                this.TxtDateFabrication.Text = pa.DateFabrication.ToShortDateString();
            }
            else
                this.TxtDateFabrication.Text = "";

            this.ChkPromo.Checked = pa.Promo;
        }

        /*******************************************************************************************************
        *  Fonctions utilitaires pour la gestion de la grille 
        *******************************************************************************************************/

        private DataRow GetSelectedDataRowFromDGVArticles()
        {            
            if (this.Articles.dt != null && this.DGVArticles.SelectedRows.Count != 0)
            {
                if (this.DGVArticles.SelectedRows.Count > 0)
                {
                    // Recherche de la ligne sélectionnée dans la grille ainsi que la valeur de l'identifiant
                    string CurrentRowId = this.DGVArticles.SelectedRows[0].Cells["Reference"].Value.ToString();
                    // Recherche de la ligne qui lui correspond dans la DataTable
                    DataRow[] SelectionResult = null;

                    // Il faut penser à traiter le cas des caractères spéciaux dans la chaine représentant
                    // la requête passée au Select
                    // CurrentRowId.Replace("'", "\'");  
                    SelectionResult = this.Articles.dt.Select("Reference = " + CurrentRowId + "");

                    // Renvoi du premier élément du tableau de DataRow qui est renvoyé par la méthode Select
                    if (SelectionResult != null && SelectionResult.Length != 0)
                        return SelectionResult[0];
                    else
                        return null;
                }
                else
                {
                    return null;
                }
            }
            else
                return null;
        }
        private void BindDataToDGVArticles()
        {
            this.Articles = BLArticle.GetAll();
            if (this.Articles != null)
            {
                this.DGVArticles.AutoGenerateColumns = false;
                this.DGVArticles.DataSource = this.Articles.dt;
                //this.DGVArticles.ClearSelection();
               
            }
        }
        #endregion     
        /********************************************************************************************************
         ********************************************************************************************************
         *
         *                                        Data Validation Methods
         * 
         ********************************************************************************************************
         ********************************************************************************************************/

        #region Data Validation Methods
        private void FormatData()
        {
            this.TxtPrix.Text = this.TxtPrix.Text.Replace('.', ',');
        }
        private void ValidateData()
        {
            int NbErrors = 0;
            string ErrorMsg;

            this.FrmErrorCtrls.Clear();

            // Champ : Référence
            // La saisie est obligatoire           
            if (this.TxtReference.Text == "") // si le champ n'est pas saisi
            {
                NbErrors++;
                ErrorMsg = "La saisie d'une valeur est obligatoire pour ce champ";
                this.FrmErrorCtrls.Add(new ErrorCtrlMsg(this.TxtReference, ErrorMsg));
            }
            else // La valeur saisie doit être numérique 
            {
                if ((this.TxtReference.Text != "") && DataFormatValidation.IsInteger(this.TxtReference.Text) == false)
                {
                    NbErrors++;
                    ErrorMsg = "La valeur saisie doit être de type numérique entier";
                    this.FrmErrorCtrls.Add(new ErrorCtrlMsg(this.TxtReference, ErrorMsg));
                }
            }

            // Champ : Prix            
            // La saisie n'est pas obligatoire. Mais ce qui est saisi doit être de type réel
            if ((this.TxtPrix.Text != "") && DataFormatValidation.IsFloat(this.TxtPrix.Text) == false)
            {
                NbErrors++;
                ErrorMsg = "La valeur saisie doit être de type réel";
                this.FrmErrorCtrls.Add(new ErrorCtrlMsg(this.TxtPrix, ErrorMsg));
            }


            // Levée d'une exception en cas d'erreurs dans la saisie
            if (NbErrors > 0)
                throw new DataValidationException("\t!!! ERREUR DE SAISIE DE DONNEES!!! \nVeuillez vérifier la saisie des champs marqués en rouge");
        }
        #endregion

        /********************************************************************************************************
         ********************************************************************************************************
         *
         *                                             Events
         * 
         ********************************************************************************************************
         ********************************************************************************************************/

        #region Events

        // Events du formulaire
        private void FormGestionArticles_Load(object sender, EventArgs e)
        {
            this.InitializeStartPosition();
            if (this.Articles != null && this.DGVArticles.RowCount > 0)
            {
                this.DGVArticles.Rows[0].Selected = true;
            }
            this.ActiveControl = this.DGVArticles;
        }
        
        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            this.SetUseMode(UseModes.AddingNew);
            AppearanceHandler.ResetInitialAppearance(this.FrmErrorCtrls, this.ToolTipErrorsInfos);
            this.TxtReference.Focus();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (this.DGVArticles.RowCount != 0) // Si la grille est non vide
            {
                if (this.DGVArticles.SelectedRows.Count > 0)
                {
                    this.SetUseMode(UseModes.Modification);
                    AppearanceHandler.ResetInitialAppearance(this.FrmErrorCtrls, this.ToolTipErrorsInfos);
                }
                else
                    MessageBox.Show("Aucun article n'est séléctionné", " Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Si la grille est vide
            {
                MessageBox.Show("Il n'y a aucun article à modifier", " Modification impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.TxtReference.Focus();
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {              
                if (this.DGVArticles.RowCount != 0) // Si la grille est non vide
                {
                    if (this.DGVArticles.SelectedRows.Count > 0) // S'il y a des lignes sélectionnées
                    {
                        int CurrentSelectedRowIndex = this.DGVArticles.SelectedRows[0].Index;
                        string DeleteParcoursMsg = "Vous êtes sur le point de supprimer un article.";
                        DeleteParcoursMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
                        DialogResult DelDecision;
                        DelDecision = MessageBox.Show(DeleteParcoursMsg, "Suppression d'un article", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (DelDecision == DialogResult.OK)
                        {
                            //int SelectedRowId = Convert.ToInt32(this.DGVArticles.SelectedRows[0].Cells["Reference"].Value.ToString());                           
                            BLArticle.Delete(this.CurrentArticle.Reference );                            
                            this.SetUseMode(UseModes.Consultation);
                            this.BindDataToDGVArticles();
                            int NbDGVRows = this.DGVArticles.RowCount;
                            if (NbDGVRows == 1)
                            {
                                GridUtilities.SelectRowFromDGVByIndex(this.DGVArticles, 0);                                
                            }
                            else
                            {
                                GridUtilities.SelectRowFromDGVByIndex(this.DGVArticles, CurrentSelectedRowIndex>=NbDGVRows ? NbDGVRows-1 : CurrentSelectedRowIndex );
                            }
                        }
                    }
                    else
                        MessageBox.Show("Aucun article n'est sélectionné");
                }
                else
                    MessageBox.Show("Il n'y a aucun article à supprimer");
        }
        catch (MyException MyEx)
        {
            MessageBox.Show(MyEx.MyExceptionMessage, "GA : " + MyEx.MyExceptionTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                AppearanceHandler.ResetInitialAppearance(this.FrmErrorCtrls, this.ToolTipErrorsInfos);
                this.FormatData();
                this.ValidateData(); //DataValidationException                

                // Insertion des informations sur l'article
                this.NewArticle = this.GetDataFromInterface();
                BLArticle.AddNew(this.NewArticle);
                //this.CurrentArticle = this.NewArticle;
                this.SetUseMode(UseModes.Consultation);
                this.BindDataToDGVArticles();
                
            }
            catch (DataValidationException Ex) // Erreur dans la saisie de données
            {
                MessageBox.Show(Ex.ExceptionMessage, "GA : Erreur dans la saisie des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppearanceHandler.SetErrorAppearance(this.FrmErrorCtrls, this.ToolTipErrorsInfos);
            }
            catch (MyException MyEx) // Autre erreur d'accès aux données par exemple
            {
                MessageBox.Show(MyEx.MyExceptionMessage, "GA : " + MyEx.MyExceptionTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void BtnAnnulerAjout_Click(object sender, EventArgs e)
        {            
            this.SetUseMode(UseModes.Consultation);
            if (this.CurrentArticle != null)
                this.BindDataToInterface(this.CurrentArticle);
            this.DGVArticles.Focus();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {
                AppearanceHandler.ResetInitialAppearance(this.FrmErrorCtrls, this.ToolTipErrorsInfos);
                this.FormatData();
                this.ValidateData();

                // Mise à jour des données sur l'article
                this.NewArticle = this.GetDataFromInterface();
                BLArticle.Update(this.CurrentArticle, this.NewArticle);
                //this.CurrentArticle = this.NewArticle;

                // Mise à jour de la grille
                this.BindDataToDGVArticles();
                this.SetUseMode(UseModes.Consultation);

                // Mise à jour de l'affichage des détails                
                GridUtilities.SelectRowFromDGVByValue(this.DGVArticles, "Reference", this.NewArticle.Reference.ToString());
                this.BindDataToInterface(this.NewArticle);
               
            }
            catch (DataValidationException Ex) // Erreur dans la saisie de données
            {
                MessageBox.Show(Ex.ExceptionMessage, "GA : Erreur dans la saisie des données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppearanceHandler.SetErrorAppearance(this.FrmErrorCtrls, this.ToolTipErrorsInfos);
            }
            catch (MyException MyEx) // Autre erreur d'accès aux données par exemple
            {
                MessageBox.Show(MyEx.MyExceptionMessage, "GA : " + MyEx.MyExceptionTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAnnulerModification_Click(object sender, EventArgs e)
        {
            this.SetUseMode(UseModes.Consultation);
            if (this.CurrentArticle != null)
                this.BindDataToInterface(this.CurrentArticle);
            else
                this.ResetControls();
           
            this.DGVArticles.Focus();
        }

        private void DGVArticles_SelectionChanged(object sender, EventArgs e)
        {

            if (this.Articles.dt != null)
            {
                if (this.DGVArticles.CurrentRow != null)
                {
                    if (this.DGVArticles.CurrentRow.Index != -1 && this.DGVArticles.CurrentRow.Index < this.Articles.dt.Rows.Count)
                    {
                        if(this.GetSelectedDataRowFromDGVArticles()!=null && this.CurrentUseMode != UseModes.AddingNew)
                        {
                            this.CurrentArticle.GetFromDataRow(this.GetSelectedDataRowFromDGVArticles());
                            //AppearanceHandler.ResetInitialAppearance(this.FrmEmptiesCtrls, this.ToolTipErrorsInfos);
                            this.BindDataToInterface(this.CurrentArticle);                         
                        }
                    }
                    else
                        this.ResetControls();
                }
                else
                    this.ResetControls();
            }
            else
                this.ResetControls();
        }

        #endregion



    }
}
