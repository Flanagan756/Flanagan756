using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_OOD_Online
{
   public class Player
    {
        public int PlayerId { get; set; }
        public string Name{ get; set; }
        public string Position { get; set; }
        public int TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
    public class Team
    {
        public int TeamId { get; set; }
        public  string TeamName { get; set; }
        public string Location { get; set; }
        public string HomeGround { get; set; }

        public virtual List<Player> Players { get; set; }
    }
    public class TeamData : DbContext
    {
        public TeamData() : base("MyTeamData") { } // Overides the base constructor
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
