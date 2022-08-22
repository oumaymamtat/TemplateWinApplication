using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyUtilities;

/// <summary>
/// Description résumée de BLL
/// </summary>
public class BLArticle
{
    public static int AddNew(Article p)
    {        
        // Test de l'unicité de la clé       
        if (DALArticle.CheckKeyUnicity(p.Reference) == true)
        {
            return DALArticle.Insert(p);
        }
        else
            throw new MyException("Erreur dans l'ajout d'un article", "La référence saisie est déja utilisée", "BLL");
    }

    public static int Update(Article CurArticle, Article NewArticle)
    {
        if (CurArticle.Reference != NewArticle.Reference)
        {
            if (DALArticle.CheckKeyUnicity(NewArticle.Reference) == true)
            {
                return DALArticle.Update(CurArticle, NewArticle);
            }
            else
            {
                throw new MyException("Erreur dans la modification de l'article", "La nouvelle Reference saisie est déja utilisée", "BLL");
            }
        }
        else
            return DALArticle.Update(CurArticle, NewArticle);
    }

    public static int Update(int pRef, Article NewArticle)
    {
        if (pRef != NewArticle.Reference)
        {
            if (DALArticle.CheckKeyUnicity(NewArticle.Reference) == true)
            {
                return DALArticle.Update(pRef, NewArticle);
            }
            else
            {
                throw new MyException("Erreur dans l'ajout d'un article", "La référence saisie est déja utilisée", "BLL");
            }
        }
        else
            return DALArticle.Update(pRef, NewArticle);
    }

    public static int Delete(int pRef)
    {
        return DALArticle.Delete(pRef);
    }

    public static ArticlesList GetAll()
    {
        return DALArticle.SelectAll();
    }
}