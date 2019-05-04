using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.Google;

namespace SheetMusic.iAz_Magic
{
    public class MemCache
    {

        private static bool a1 = true;
        private static bool a2;
        private static bool a3;
        private static bool a4;
        private static bool a5;

#region getMemCacheVals

 public static string getCBoxVal(string arg)
 {

     //Read value for checkbox, and return checked function if needed.
     if (arg == "a1" && a1)
     {
         return "checked='checked'";
     }

     if (arg == "a2" && a2)
     {
         return "checked='checked'";
     }

     if (arg == "a3" && a3)
     {
         return "checked='checked'";
     }

     if (arg == "a4" && a4)
     {
         return "checked='checked'";
     }

     if (arg == "a5" && a5)
     {
         return "checked='checked'";
     }

     return "";
 }
 #endregion

#region SetMemCacheVals


        //Force set all bools if needed.
        //This is one bad piece of code.
        public static void forceSetMemVal(string arg)
        {
            if (arg == "a1" && a1 == false)
            {
                a1 = true;
                a2 = false;
                a3 = false;
                a4 = false;
                a5 = false;
            }
            if (arg == "a2" && a2 == false)
            {
                a1 = false;
                a2 = true;
                a3 = false;
                a4 = false;
                a5 = false;
            }
            if (arg == "a3" && a3 == false)
            {
                a1 = false;
                a2 = false;
                a3 = true;
                a4 = false;
                a5 = false;
            }
            if (arg == "a4" && a4 == false)
            {
                a1 = false;
                a2 = false;
                a3 = false;
                a4 = true;
                a5 = false;
            }
            if (arg == "a5" && a5 == false)
            {
                a1 = false;
                a2 = false;
                a3 = false;
                a4 = false;
                a5 = true;
            }
        }
#endregion
    }
}