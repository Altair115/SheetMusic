using System;
using System.Collections;
using System.Security.Policy;
using System.Web.Mvc.Html;
using System.Web.Services.Protocols;

namespace SheetMusic.iAz_Magic
{
    public class resolver
    {

        public static string getQueryString(string param, string _key)
        {
            switch (param)
            {
                case "name":
                    return String.Format("SELECT * FROM Pieces WHERE PieceName LIKE LOWER(@0) AND user_id = '{0}'", _key);
                case "genre":
                    return String.Format("SELECT * FROM Pieces WHERE Genre LIKE LOWER(@0) AND user_id = '{0}'",_key);
                case "year":
                    return String.Format("SELECT * FROM Pieces WHERE Year LIKE LOWER(@0) AND user_id = '{0}'", _key);
                case "difficulty":
                    return String.Format("SELECT * FROM Pieces WHERE Difficulty LIKE LOWER(@0) AND user_id = '{0}'", _key);
                case "artist":
                    return String.Format("SELECT * FROM Pieces WHERE Artist LIKE LOWER(@0) AND user_id = '{0}'", _key);
                default:
                    return String.Format("SELECT * FROM Pieces WHERE PieceName LIKE LOWER(@0) AND user_id = '{0}'", _key);
            }
        }



    }
}