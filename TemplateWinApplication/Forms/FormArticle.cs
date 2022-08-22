using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyUtilities;

namespace TemplateWinApplication
{
    public partial class FormArticle : Form
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
        UseModes CurrentUseMode;
        List<ErrorCtrlMsg> FrmErrorCtrls;       
        Control[] ConsultationModeDependentControls; 
        Control[] AddEditModeDependentControls;

       
        private void InitForm()
        {
            InitializeComponent(); 
            this.FrmErrorCtrls = new List<ErrorCtrlMsg>();
            AddEditModeDependentControls = new Control[] {this.CmbCategorie, this.DTDateFabrication};
            ConsultationModeDependentControls = new Control[] {this.TxtCategorie, this.TxtDateFabrication};
        }

        // Constructor to be used for Adding new record 
        public FormArticle()
        {
            InitForm();                      
            this.NewArticle = this.CurrentArticle = null;                       
            this.SetUseMode(UseModes.AddingNew);                        
        }

        // Constructor to be used for Consultation mode
        public FormArticle(Article a)
        {
            InitForm();  
            this.NewArticle = this.CurrentArticle = a;
            this.BindDataToInterface(a);               
            this.SetUseMode(UseModes.Consultation);  
            
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
            TextBox [] ParamControls = { 
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
                        this.Text = "GA : Gestion des articles - Ajout d'une nouvel article";                                           
                        AppearanceHandler.HideControls(ConsultationModeDependentControls);
                        AppearanceHandler.ShowControls(AddEditModeDependentControls);
                        this.PanelNouveauModifierSupprimer.Visible = false;
                        this.PanelAjouterAnnuler.Visible = true;
                        this.PanelValiderAnnuler.Visible = false;

                        this.CmbCategorie.SelectedIndex = 0;
                        this.TxtReference.Focus();
                        this.SetModeToReadOnly(false);
                        this.ResetControls();
                        break;
                    }

                case UseModes.Consultation:
                    {
                        this.Text = "GA : Gestion des articles - Consultation";   
                        AppearanceHandler.HideControls(AddEditModeDependentControls);
                        AppearanceHandler.ShowControls(ConsultationModeDependentControls);
                        this.PanelNouveauModifierSupprimer.Visible = true;
                        this.PanelAjouterAnnuler.Visible = false;
                        this.PanelValiderAnnuler.Visible = false;                                                                                         
                        this.SetModeToReadOnly(true);
                        break;
                    }

                case UseModes.Modification:
                    {                      
                        
                        this.Text = "GA : Gestion des articles - Modification";   
                        AppearanceHandler.HideControls(ConsultationModeDependentControls);
                        AppearanceHandler.ShowControls(AddEditModeDependentControls);
                        this.PanelNouveauModifierSupprimer.Visible = false;
                        this.PanelAjouterAnnuler.Visible = false;
                        this.PanelValiderAnnuler.Visible = true;
                        this.TxtReference.Focus();
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
            if(this.TxtPrix.Text!="")
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
         *******************************************************************************************************/

        private void FormArticle_Load(object sender, EventArgs e)
        {
            this.InitializeStartPosition();
        }
       
        private void BtnNouveau_Click(object sender, EventArgs e)
        {
            this.SetUseMode(UseModes.AddingNew);
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            this.SetUseMode(UseModes.Modification);
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            string DelMsg = "Vous êtes sur le point de supprimer un article";
            DelMsg += " Cliquez sur OK pour confirmer la suppression ou sur Annuler dans le cas contraire !!! ";
            DialogResult DeleteDecision;
            DeleteDecision = MessageBox.Show(DelMsg, "Suppression d'un article", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DeleteDecision == DialogResult.OK)
            {
                try
                {
                    if (BLArticle.Delete(this.CurrentArticle.Reference) > 0)
                    {
                        MessageBox.Show("L'article a été convenablement supprimé", "Suppression d'un article", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        // Autre action à faire
                    }
                    else
                    {
                        MessageBox.Show("L'article n'a pas été convenablement supprimé", "Suppression d'un article", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        // Autre action à faire
                    }                   
                }
                catch (MyException MyEx)
                {
                    MessageBox.Show(MyEx.MyExceptionMessage, "GA : " + MyEx.MyExceptionTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Close();
                }
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
                this.CurrentArticle = this.GetDataFromInterface();
                BLArticle.AddNew(this.CurrentArticle);
                this.Close();
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
            this.Close();            
        }

        private void BtnValider_Click(object sender, EventArgs e)

        {
            try
            {
                AppearanceHandler.ResetInitialAppearance(this.FrmErrorCtrls, this.ToolTipErrorsInfos);
                this.FormatData();
                this.ValidateData();

                // Mise à jour des données sur le type du diplome
                this.NewArticle = this.GetDataFromInterface();
                BLArticle.Update(this.CurrentArticle, this.NewArticle);
                //this.CurrentArticle = this.NewArticle;
                this.SetUseMode(UseModes.Consultation);
                this.Close();
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
            this.BindDataToInterface(this.CurrentArticle);
        }

       

        
    }
}
