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
    public partial class FormListeArticles : Form
    {
       
     /********************************************************************************************************
     ********************************************************************************************************
     *
     *                                             Attributs & Constructors
     * 
     ********************************************************************************************************
     ********************************************************************************************************/

        #region Attributes & Constructors
              
        ArticlesList Articles;      
        
        public FormListeArticles()
        {           
            try
            {
                InitializeComponent();
                this.BindDataToDGVArticles();
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
            this.Location = new Point((this.Parent.ClientSize.Width - this.Width) / 2, 50);           
        }

       
        /*******************************************************************************************************
        *  Fonctions utilitaires pour la gestion de la grille 
        *******************************************************************************************************/

        private DataRow GetSelectedDataRowFromDGVArticle()
        {
            if (this.Articles.dt != null && this.DGVArticles.SelectedRows.Count != 0)
            {
                if (this.DGVArticles.SelectedRows.Count > 0)
                {
                    // Recherche de la ligne sélectionnée dans la grille ainsi que la valeur de l'identifiant
                    string SelectedRowId = this.DGVArticles.SelectedRows[0].Cells["Reference"].Value.ToString();
                    // Recherche de la ligne qui lui correspond dans la DataTable
                    DataRow[] SelectionResult = null;

                    // Il faut penser à traiter le cas des caractères spéciaux dans la chaine représentant
                    // la requête passée au Select
                    // CurrentRowId.Replace("'", "\'");  
                    SelectionResult = this.Articles.dt.Select("Reference = " + SelectedRowId + "");

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
                this.DGVArticles.ClearSelection();
            }
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
        private void FormListeArticles_Load(object sender, EventArgs e)
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
            FormArticle frm = new FormArticle();
            frm.ShowDialog();
            this.BindDataToDGVArticles();
            
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {           
            if (this.DGVArticles.SelectedRows.Count!=0)
            {
                FormArticle frm = new FormArticle(new Article(this.GetSelectedDataRowFromDGVArticle()));
                frm.ShowDialog();
                this.BindDataToDGVArticles();
            }
            else
                MessageBox.Show("Veuillez sélectionner une ligne de la grille");
        }
        #endregion

    }
}    

