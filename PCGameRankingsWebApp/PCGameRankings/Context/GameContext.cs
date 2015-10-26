using PCGameRankings.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PCGameRankings.Context
{
    public class GameContext : DbContext
    {
            public DbSet<PCGames> PCGame { get; set; }


        public GameContext() : base("DefaultConnection")
        {

        }
    }


}