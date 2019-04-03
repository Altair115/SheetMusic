using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SheetMusic.Models
{
    public class Piece
    {
        public int Id { get; set; }
        public string PieceName { get; set; }
        public string PieceSubName { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Difficulty { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}