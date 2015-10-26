using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PCGameRankings.Models
{
    public class PCGames
    {
        [Key]
        public int GameID { get; set; }
        public string GameTitle { get; set; }
        public string ImageURL { get; set; }
        public string Rank { get; set; }
        public DateTime ReleaseDate { get; set; }

        
    }
}