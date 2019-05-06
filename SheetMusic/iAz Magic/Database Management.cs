using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using WebMatrix.Data;

namespace SheetMusic.iAz_Magic
{
    public class Database_Management
    {
        static string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Sheetz.mdf;Integrated Security=True";

        static string provider = "System.Data.SqlClient";
        static Database db = Database.OpenConnectionString(connectionString, provider);


        public static void yoinkintoDatabase(string PieceName, string PieceSubName, string PieceGenre,
            string PieceArtist,
            string PieceYear, string PiecePlace, string PieceDifficulty, string _key)
        {
            #region isEmptychecks

            if (PieceName.IsEmpty())
            {
                PieceName = "N/A";
            }

            if (PieceSubName.IsEmpty())
            {
                PieceSubName = "N/A";
            }

            if (PieceGenre.IsEmpty())
            {
                PieceGenre = "N/A";
            }

            if (PieceArtist.IsEmpty())
            {
                PieceArtist = "N/A";
            }

            if (PieceYear.IsEmpty())
            {
                PieceYear = "N/A";
            }

            if (PiecePlace.IsEmpty())
            {
                PiecePlace = "N/A";
            }

            if (PieceDifficulty.IsEmpty())
            {
                PieceDifficulty = "N/A";
            }

            #endregion

            db.Execute(
                "INSERT INTO Pieces(PieceName, PieceSubName, Genre, Year, Difficulty, Description, User_Id, Artist) VALUES(@0, @1, @2, @3, @4, @5, @6, @7)",
                PieceName, PieceSubName, PieceGenre, PieceYear, PieceDifficulty, PiecePlace, _key, PieceArtist);
        }


        public static void EditintoDatabase(string PieceName, string PieceSubName, string PieceGenre,
            string PieceArtist, string PieceYear, string PiecePlace, string PieceDifficulty, string _key)
        {
            #region isEmptychecks

            if (PieceName.IsEmpty())
            {
                PieceName = "N/A";
            }

            if (PieceSubName.IsEmpty())
            {
                PieceSubName = "N/A";
            }

            if (PieceGenre.IsEmpty())
            {
                PieceGenre = "N/A";
            }

            if (PieceArtist.IsEmpty())
            {
                PieceArtist = "N/A";
            }

            if (PieceYear.IsEmpty())
            {
                PieceYear = "N/A";
            }

            if (PiecePlace.IsEmpty())
            {
                PiecePlace = "N/A";
            }

            if (PieceDifficulty.IsEmpty())
            {
                PieceDifficulty = "N/A";
            }

            #endregion

            db.Execute("UPDATE Pieces SET PieceName = @0, PieceSubName = @1, Genre = @2, Year = @3, Difficulty=@4, Description=@5, User_Id=@6, Artist=@7",
                PieceName, PieceSubName, PieceGenre, PieceYear, PieceDifficulty, PiecePlace, _key, PieceArtist);
        }
    }
}