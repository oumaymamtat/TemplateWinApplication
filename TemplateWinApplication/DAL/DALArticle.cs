using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlServerCe;
using MyUtilities;
using System.Configuration;
using TemplateWinApplication;

public class DALArticle
{
    
    public static bool CheckKeyUnicity(object FieldValue)
    {
        return !DataBaseAccessUtilities.CheckFieldValueExistence("Article", "Reference", SqlDbType.Int, FieldValue, Program.Connection);
    }

    public static int Insert(Article p)
    {                
        string StrSQL = "INSERT INTO Article (Reference, Designation, Categorie, Prix, DateFabrication, Promo) VALUES(@Reference,@Designation, @Categorie, @Prix, @DateFabrication, @Promo)";
        SqlCeCommand Cmd = new SqlCeCommand(StrSQL, Program.Connection);
        Cmd.Parameters.Add("@Reference", SqlDbType.Int).Value = p.Reference;
        Cmd.Parameters.Add("@Designation", SqlDbType.NVarChar).Value = p.Designation;
        Cmd.Parameters.Add("@Categorie", SqlDbType.NVarChar).Value = p.Categorie;
        //Cmd.Parameters.Add("@Prix", SqlDbType.Float).Value = p.Prix;

        if (p.Prix == null)
            Cmd.Parameters.Add("@Prix", SqlDbType.Float).Value = DBNull.Value;
        else
            Cmd.Parameters.Add("@Prix", SqlDbType.Float).Value = p.Prix;        
        
        Cmd.Parameters.Add("@DateFabrication", SqlDbType.DateTime).Value = p.DateFabrication;
        Cmd.Parameters.Add("@Promo", SqlDbType.Bit).Value = p.Promo;
        return DataBaseAccessUtilities.NonQueryRequest(Cmd);        
    }

    public static int Delete(int pReference)
    {
        string StrSQL = "DELETE FROM Article WHERE Reference = @Reference";
        SqlCeCommand Cmd = new SqlCeCommand(StrSQL, Program.Connection);
        Cmd.Parameters.Add("@Reference", SqlDbType.Int).Value = pReference;
        return DataBaseAccessUtilities.NonQueryRequest(Cmd);
    }

    public static int Update(int pCurReference, Article pNewArticle)
    {
        string StrSQL = "UPDATE Article SET Reference=@Reference, Designation=@Designation, Categorie=@Categorie, Prix=@Prix, DateFabrication=@DateFabrication, Promo=@Promo WHERE Reference = @CurReference";
        //string StrSQL = "UPDATE Article SET Reference=@Reference, Designation=@Designation, Prix=@Prix WHERE Reference = @CurReference";
        SqlCeCommand Cmd = new SqlCeCommand(StrSQL, Program.Connection);
        Cmd.Parameters.Add("@Reference", SqlDbType.Int).Value = pNewArticle.Reference;
        Cmd.Parameters.Add("@Designation", SqlDbType.NVarChar).Value = pNewArticle.Designation;
        Cmd.Parameters.Add("@Categorie", SqlDbType.NVarChar).Value = pNewArticle.Categorie;
        Cmd.Parameters.Add("@Prix", SqlDbType.Float).Value = pNewArticle.Prix;
        Cmd.Parameters.Add("@DateFabrication", SqlDbType.DateTime).Value = pNewArticle.DateFabrication;
        Cmd.Parameters.Add("@Promo", SqlDbType.Bit).Value = pNewArticle.Promo;
        Cmd.Parameters.Add("@CurReference", SqlDbType.Int).Value = pCurReference;

        return DataBaseAccessUtilities.NonQueryRequest(Cmd);
    }

    public static int Update(Article pCur, Article pNew)
    {
        return Update(pCur.Reference, pNew);
    }

    //public static Article SelectByReference(string pRef)
    //{
    //    string StrSQL = "SELECT * FROM Article WHERE Reference = @Ref";
    //    SqlCeCommand Command = new SqlCeCommand(StrSQL, Program.Connection);
    //    Command.Parameters.Add("@Ref", SqlDbType.NVarChar).Value = pCode;
    //    DataTable dt = DataBaseAccessUtilities.SelectRequest(Command);
    //    if (dt != null && dt.Rows.Count != 0)
    //        return new Article(dt.Rows[0]);
    //    else
    //        return null;
    //}

    //public static ArticlesList SelectByCriterium(string FieldName, SqlDbType FieldType, string FieldValue)
    //{
    //    string StrSQL = "SELECT * FROM Article WEHRE " + FieldName + "= @" + FieldName;
    //    SqlCeCommand Command = new SqlCeCommand(StrSQL, Program.Connection);
    //    Command.Parameters.Add("@" + FieldName, FieldType).Value = FieldValue;
    //    DataTable dt = DataBaseAccessUtilities.SelectRequest(Command);
    //    if (dt != null)
    //        return new ArticlesList(dt);
    //    else
    //        return null;
    //}

    public static ArticlesList SelectAll()
    {
        string StrSQL = "SELECT * FROM Article";
        DataTable dt = DataBaseAccessUtilities.SelectRequest(StrSQL, Program.Connection);
        if (dt != null)
            return new ArticlesList(dt);
        else
            return null;
    }

    //public static ArticlesList SelectAllWithJoin()
    //{
    //    string StrSQL = "SELECT Article.Code, Article.Libelle, Article.CodeCategorie, Categorie.Libelle as CategorieLib FROM Article, CATEGORIE WHERE Categorie.Code=Article.CodeCategorie";
    //    DataTable dt = DataBaseAccessUtilities.SelectRequest(StrSQL, Program.Connection);
    //    if (dt != null)
    //        return new ArticlesList(dt);
    //    else
    //        return null;
    //}



}