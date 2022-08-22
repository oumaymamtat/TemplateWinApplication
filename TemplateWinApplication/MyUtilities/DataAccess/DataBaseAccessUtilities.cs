
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace MyUtilities
{
    public static class DataBaseAccessUtilities
    {

        public static int NonQueryRequest(SqlCeCommand MyCommand)
        {
            try
            {
                try
                {
                    MyCommand.Connection.Open();
                }
                catch (SqlCeException e)
                {
                    throw new MyException(e,"DataBase Error", "Erreur de connexion à la base", "DAL");
                }

                return MyCommand.ExecuteNonQuery();
            }
            catch (SqlCeException e)
            {
                throw new MyException(e, "DataBase Error", e.Message, "DAL");
            }
            finally
            {
                MyCommand.Connection.Close();
            }

        }
        public static int NonQueryRequest(string StrRequest, SqlCeConnection MyConnection)
        {
            try
            {
                try
                {
                    MyConnection.Open();
                }
                catch (SqlCeException e)
                {
                    throw new MyException(e, "DataBase Error", "Erreur de connexion à la base", "DAL");
                }

                SqlCeCommand MyCommand = new SqlCeCommand(StrRequest, MyConnection);
                return MyCommand.ExecuteNonQuery();
            }
            catch (SqlCeException e)
            {
                throw new MyException(e, "DataBase Error", "Erreur d'éxecution de la requête : \n", "DAL");
            }
            finally
            {
                MyConnection.Close();
            }

        }        

        public static object ScalarRequest(SqlCeCommand MyCommand)
        {
            try
            {
                try
                {
                    MyCommand.Connection.Open();
                }
                catch (SqlCeException e)
                {
                    throw new MyException(e, "DataBase Error", "Erreur de connexion à la base", "DAL");
                }

                return MyCommand.ExecuteScalar();
            }
            catch (SqlCeException e)
            {
                throw new MyException(e, "DataBase Error", "Erreur d'éxecution de la requête : \n", "DAL");
            }
            finally
            {
                MyCommand.Connection.Close();
            }
        }
        public static object ScalarRequest(string StrRequest, SqlCeConnection MyConnection)
        {
            try
            {
                try
                {
                    MyConnection.Open();
                }
                catch (SqlCeException e)
                {
                    throw new MyException(e, "DataBase Error", "Erreur de connexion à la base", "DAL");
                }
                SqlCeCommand MyCommand = new SqlCeCommand(StrRequest, MyConnection);

                return MyCommand.ExecuteScalar();
            }
            catch (SqlCeException e)
            {
                throw new MyException(e, "DataBase Error", "Erreur d'éxecution de la requête : \n", "DAL");
            }
            finally
            {
                MyConnection.Close();
            }
        }
      

        public static DataTable SelectRequest(SqlCeCommand MyCommand)
        {
            try
            {
                DataTable Table;
                SqlCeDataAdapter SelectAdapter = new SqlCeDataAdapter(MyCommand);
                Table = new DataTable();
                SelectAdapter.Fill(Table);
                return Table;
            }
            catch (SqlCeException e)
            {
                //throw new MyException(e, "DataBase Error", "Erreur d'éxecution de la requête de sélection : \n", "DAL");
                throw new MyException(e, "DataBase Errors", e.Message, "DAL");
            }
            finally
            {
                MyCommand.Connection.Close();
            }
        }
        public static DataTable SelectRequest(string StrSelectRequest, SqlCeConnection MyConnection)
        {
            try
            {
                DataTable Table;
                SqlCeCommand SelectCommand = new SqlCeCommand(StrSelectRequest, MyConnection);
                SqlCeDataAdapter SelectAdapter = new SqlCeDataAdapter(SelectCommand);
                Table = new DataTable();
                SelectAdapter.Fill(Table);
                return Table;
            }
            catch (SqlCeException e)
            {
                
                throw new MyException(e, "DataBase Error", "Erreur d'éxecution de la requête de sélection : \n", "DAL");
                 
            }
            finally
            {
                MyConnection.Close();
            }
        }
        

        public static void ShowRequest(SqlCeCommand Cmd)
        {
            String ListPar = "\t\t****Texte de la Requete****\n";
            ListPar += Cmd.CommandText + "\n";
            ListPar += "\t\t****Liste des parmêtres : ****\n";
            foreach (SqlCeParameter Param in Cmd.Parameters)
            {
                ListPar += Param.ParameterName + "\t:\t\"" + Param.Value.ToString() + "\"\t:\t" + Param.DbType.ToString() + "\n";
            }
            System.Windows.Forms.MessageBox.Show(ListPar);

        }

        public static bool CheckFieldValueExistence(string TableName, string FieldName, SqlDbType FieldType, object FieldValue, SqlCeConnection MyConnection)
        {
            try
            {
                string StrRequest = "SELECT COUNT(" + FieldName + ") FROM " + TableName + " WHERE ((" + FieldName + " = @" + FieldName + ")";
                StrRequest += "OR ( (@" + (FieldName + 1).ToString() + " IS NULL)AND (" + FieldName + " IS NULL)))";
                SqlCeCommand Command = new SqlCeCommand(StrRequest, MyConnection);                
                Command.Parameters.Add( "@"+FieldName, FieldType).Value = FieldValue;
                Command.Parameters.Add( "@"+FieldName+1, FieldType).Value = FieldValue;        
                return ((int)DataBaseAccessUtilities.ScalarRequest(Command) != 0);
            }
            catch (SqlCeException e)
            {
                throw new MyException(e, "DataBase Error", "Erreur d'éxecution de la requête de vérification de l'existence de la valeur : \n", "DAL");
            }
            finally
            {
                MyConnection.Close();
            }

        }
        
        public static object GetMaxFieldValue(SqlCeConnection MyConnection, string TableName, string FieldName)
        {
            try
            {
                string StrMaxRequest = "SELECT MAX(" + FieldName + ") FROM " + TableName;

                SqlCeCommand Command = new SqlCeCommand(StrMaxRequest, MyConnection);               
                return (DataBaseAccessUtilities.ScalarRequest(Command));

            }
            catch (SqlCeException e)
            {
                throw new MyException(e, "DataBase Error", "Erreur d'éxecution de la requête de vérification de l'existence de la valeur : \n", "DAL");
            }
            finally
            {
                MyConnection.Close();
            }
        }

    }
}
