using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Sql;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Xml;

namespace TemplateWinApplication
{    
    static class Program
    {
        public static string DBServerPath;
        public static string DataServerPath;
        public static SqlCeConnection Connection;
        public static String StrConnection;
        //public static Form MainForm;


        public static void InitDBServerPath()
        {
            try
            {
                XmlDocument ConfigFiledoc = new XmlDocument();
                ConfigFiledoc.Load("ConfigFile.xml");
                XmlNode n = ConfigFiledoc.SelectSingleNode("//DataServerPath");
                DataServerPath = n.InnerText.ToString();
                DBServerPath = ConfigFiledoc.SelectSingleNode("//DBServerPath").InnerText.ToString();
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.InitDBServerPath();
            // Program.StrConnection = @"Data Source= " + Program.DataServerPath + "; Integrated Security=true; Initial Catalog= " + Program.DBServerPath;
            //Program.StrConnection = "Data Source= " + Program.DataServerPath + "; Integrated Security=true; Initial Catalog= " + Program.DBServerPath;
            Program.StrConnection = "Data Source= ArticlesDB.sdf";
            Program.Connection = new SqlCeConnection(Program.StrConnection);           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormListeArticles());
            Application.Run(new MainForm());
        }
    }
}
