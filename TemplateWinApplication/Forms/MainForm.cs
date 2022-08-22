using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemplateWinApplication
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArticle frm = new FormArticle();
            frm.Show();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeArticles frm = new FormListeArticles();
            frm.Show();
        }

        private void modèle2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionArticles1 frm = new FormGestionArticles1();
            frm.Show();
        }

        private void modèle3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionArticles2 frm = new FormGestionArticles2();
            frm.Show();
        }


      
  

                   
    }
}
