// Last Modified date : 31-05-2012 - 12:00


using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.SqlServerCe;
using MyUtilities;
using System.Text.RegularExpressions;





namespace MyUtilities
{
    /*********************************************************************************
     * 
     *                                  Enumérations
     *                             
     * *******************************************************************************/

    public enum UseModes { AddingNew, Consultation, Modification };
    public enum ExceptionLevel { DAL, BL, Presentation }


    /*********************************************************************************
     * 
     *                                  Exceptions
     *                             
     * *******************************************************************************/

    public class MyException : Exception
    {
        
        string _Level;
        string _MyExceptionTitle;
        string _MyExceptionMessage;
       

        public string Level
        {
            get
            {
                return this._Level;
            }
        }

        public string MyExceptionTitle
        {
            get
            {
                return this._MyExceptionTitle;
            }
        }

        public string MyExceptionMessage
        {
            get
            {
                return this._MyExceptionMessage.ToString();
            }
        }


        public MyException(string MyExceptionTitle, string MyExceptionMessage, string lev)
        {
            this._Level = lev;
            this._MyExceptionTitle = MyExceptionTitle;
            this._MyExceptionMessage = MyExceptionMessage;
        }
      
        public MyException(Exception e, string MyExceptionTitle, string MyExceptionMessage, string lev) : base(e.Message)
        {            
            this._Level = lev;
            this._MyExceptionTitle = MyExceptionTitle;
            this._MyExceptionMessage = MyExceptionMessage;
        }

    }


    /*********************************************************************************
     * 
     *                                  Classes and structures
     *                             
     * *******************************************************************************/

    public static class DataFormatValidation
    { 
        public static bool ValidMail(string mail_address)
        {
            Regex myRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
            return myRegex.IsMatch(mail_address);
        }

        public static bool IsInteger(string val)
        {
            int result;
            return Int32.TryParse(val, out result);
        }

        public static bool IsFloat(string val)
        {
            float result;
            return Single.TryParse(val, out result);
        }
    }

    public static class DataFormatter
    {
        public static float FormatFloat(float inFloat)
        {
            return float.Parse(inFloat.ToString().Replace(',', '.'));
        }
    }


  
    
   
    public class DataValidationException : Exception
    {
        private string _ExecptionMessage;
        public string ExceptionMessage
        {
            get
            {
                return this._ExecptionMessage;
            }
        }
        public DataValidationException(string StrExceptionMessage)
        {
            this._ExecptionMessage = StrExceptionMessage;
        }
    }

    public static class DataFormating
    {
        public static string DeleteAllCharOccurencesFromString(string Str, char c)
        {
            string FormatedStr = "";
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str[i] != c)
                {
                    FormatedStr += Str[i];
                }
            }
            return FormatedStr;
        }
        public static List<string> ExtractValuesFromFormatedString(string Str, char Separator)
        {
            List<string> StrValuesList = new List<string>();
            string TempStrValue;
            Str = Str.TrimStart(Separator);

            int i = 0;
            while (i < Str.Length)
            {
                TempStrValue = "";
                while ((Str[i] != Separator))
                {
                    TempStrValue += Str[i];
                    i++;
                    if (i == Str.Length)
                        break;
                }
                i++;

                if (TempStrValue != "")
                    StrValuesList.Add(TempStrValue);
            }
            return StrValuesList;
        }
        public static int CompareListValues(List<string> List)
        {
            int NbErreur = 0;
            for (int i = 0; i < List.Count - 1; i++)
            {
                for (int j = i + 1; j < List.Count; j++)
                {
                    if (List[i] == List[j])
                        NbErreur++;
                }
            }
            return NbErreur;
        }
        public static string FormatRequestParameter(string StrSQLParam)
        {
            return StrSQLParam.Replace("'", "''");
        }
        public static bool IsNumeric(string value)
        {
            //bool variable to hold the return value
            bool match;
            //regula expression to match numeric values
            string pattern = "(^[-+]?\\d+(,?\\d*)*\\.?\\d*([Ee][-+]\\d*)?$)|(^[-+]?\\d?(,?\\d*)*\\.\\d+([Ee][-+]\\d*)?$)";
            //generate new Regulsr Exoression eith the pattern and a couple RegExOptions
            Regex regEx = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            //tereny expresson to see if we have a match or not
            match = regEx.Match(value).Success ? true : false;
            //return the match value (true or false)
            return match;
        }
        public static bool IsNumeric(string val, System.Globalization.NumberStyles NumberStyle)
        {
            Double result;
            return Double.TryParse(val, NumberStyle,
                System.Globalization.CultureInfo.CurrentCulture, out result);
        }
    }
      
  

    public static class NumberToLettersConverter
    {
        static string[] A = { "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize" };
        static string[] B = { "vingt", "trente", "quarante", "cinquante", "soixante", "", "quatre vingt" };
        static string[] C = { "cent", "mille", "million", "milliard" };

        public static string ConvertNumberToText(int number)
        {
            string tmp, tmp1;
            string tmp2 = "";
            int a, b, c, n;
            string result = "";

            if (number == 0)
                result = "zéro";
            else
            {
                n = number;
                if ((n % 100 >= 1) && (n % 100 <= 16))
                    tmp = A[n % 100 - 1];
                else
                    if (n % 100 == 0)
                        tmp = "";
                    else
                    {
                        a = n % 10;
                        n = n / 10;
                        b = n % 10;
                        n = n / 10;
                        if (b == 1)
                            tmp = A[9] + " " + A[a + 1];
                        else
                            if (b == 7 || b == 9)
                            {
                                if ((a >= 0) && (a <= 6))
                                    tmp = B[b - 3] + " " + A[a + 9];
                                else
                                    tmp = B[b - 3] + " " + A[9] + " " + A[a - 1];
                            }
                            else
                            {
                                if (a != 0)
                                    tmp = B[b - 2] + " " + A[a - 1];
                                else
                                    tmp = B[b - 2];
                            }
                    }
                n = number / 100;
                c = n % 10;
                if (c == 0)
                    tmp1 = "";
                else
                    if (c == 1)
                        tmp1 = C[0];
                    else
                        tmp1 = A[c - 1] + " " + C[0];// +"s";

                n = number / 1000;
                if (n > 0 && n < 17)
                {
                    if (n == 1)
                        tmp2 = C[1];
                    else
                        tmp2 = A[n - 1] + " " + C[1];// +"s";
                }
                result = tmp2 + " " + tmp1 + " " + tmp;
            }
            return result.Trim();
        }
    }
}
   

