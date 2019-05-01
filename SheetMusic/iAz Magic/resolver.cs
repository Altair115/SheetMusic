﻿using System.Collections;
using System.Security.Policy;
using System.Web.Mvc.Html;
using System.Web.Services.Protocols;

namespace SheetMusic
{
    public class resolver
    {

        public static string getQueryString(string param)
        {
            switch (param)
            {
                case "name":
                    return "SELECT * FROM Pieces WHERE PieceName LIKE LOWER(@0)";
                case "genre":
                    return "SELECT * FROM Pieces WHERE Genre LIKE LOWER(@0)";
                case "year":
                    return "SELECT * FROM Pieces WHERE Year LIKE LOWER(@0)";
                case "difficulty":
                    return "SELECT * FROM Pieces WHERE Difficulty LIKE LOWER(@0)";
                default:
                    return "SELECT * FROM Pieces WHERE PieceName LIKE LOWER(@0)";
            }
        }


    }
}