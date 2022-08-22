using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;

/// <summary>
/// Description résumée de Entities
/// </summary>

[Serializable]
public class Article
{
    int _Reference;
    string _Designation;
    string _Categorie;
    float? _Prix;
    DateTime _DateFabrication;
    bool _Promo;

    public int Reference
    {
        get
        {
            return _Reference;
        }
        set
        {
            _Reference = value;
        }
    }
    public string Designation
    {
        get
        {
            return _Designation;
        }
        set
        {
            _Designation = value;
        }
    }
    public string Categorie
    {
        get
        {
            return _Categorie;
        }
        set
        {
            _Categorie = value;
        }
    }
    public float? Prix
    {
        get
        {
            return _Prix;
        }
        set
        {
            _Prix = value;
        }
    }
    public DateTime DateFabrication
    {
        get
        {
            return _DateFabrication;
        }
        set
        {
            _DateFabrication = value;
        }
    }
    public bool Promo
    {
        get
        {
            return _Promo;
        }
        set
        {
            _Promo = value;
        }
    }

    public Article()
    {
    }

    public Article(int pReference, string pDesignation, float? pPrix, DateTime pDateFabrication, bool pPromo)
    {
        Reference = pReference;
        Designation = pDesignation;
        Prix = pPrix;
        DateFabrication = pDateFabrication;
        Promo = pPromo;
    }

    public Article(DataRow dr)
    {
        GetFromDataRow(dr);
    }

    public void GetFromDataRow(DataRow dr)
    {
        // Référence
        Reference = (int)dr["Reference"];
        
        //Désignation
        Designation = dr["Designation"] == System.DBNull.Value ? "" : (string)dr["Designation"]; 
        
        //Catégorie
        Categorie = dr["Categorie"] == System.DBNull.Value ? "" : (string)dr["Categorie"];
        
        //Prix
        Prix = dr["Prix"] == System.DBNull.Value ? null : (float?)Single.Parse(dr["Prix"].ToString());  // A cause de la représentation des réeels de SQL Server float sql server = double c#

        // DateFabrication       
        DateFabrication = dr["DateFabrication"] == System.DBNull.Value ? DateTime.MinValue.Date : (DateTime)dr["DateFabrication"];
      
        // Promo
        Promo = dr["Promo"].ToString() == "True" ? true : false;     
    }

    public object[] ExportToArray()
    {
        return this.ExportToArray();
    }
	
}

public class ArticlesList
{
    public DataTable dt;

    public ArticlesList()
    {
    }

    public ArticlesList(DataTable pdt)
    {
        dt = pdt;
    }
    public List<Article> GetList()
    {
        if (dt != null)
        {
            List<Article> L = new List<Article>(dt.Rows.Count);
            foreach (DataRow dr in dt.Rows)
                L.Add(new Article(dr));
            return L;
        }
        else
            return null;
    }
}
       
