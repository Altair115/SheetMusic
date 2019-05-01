using System.Collections;
using System.Security.Policy;
using System.Web.Mvc.Html;
using System.Web.Services.Protocols;

namespace SheetMusic
{
    public class resolver
    {


        private string _filter = "name";

        public static string getQueryString(string param)
        {
            switch (param)
            {
                case "name":
                    return "SELECT * FROM Pieces WHERE LOWER(PieceName) LIKE LOWER(%@0%)";
                case "genre":
                    return "SELECT * FROM Pieces WHERE LOWER(Genre) LIKE LOWER(%@0%)";
                case "year":
                    return "SELECT * FROM Pieces WHERE LOWER(Year) LIKE LOWER(%@0%)";
                case "difficulty":
                    return "SELECT * FROM Pieces WHERE LOWER(Difficulty) LIKE LOWER(%@0%)";
                default:
                    return "SELECT * FROM Pieces WHERE LOWER(PieceName) LIKE LOWER(%@0%)";
            }
        }


    }
}