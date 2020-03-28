using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_OOD_Online_Pt2
{
    public class ComputerGame
    {
        public int ComputerGameId{ get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

        public virtual List<Character> Characters { get; set;}


    }
    public class Character
    {
        public int  CharacterId { get; set; }
        public string CharacterName { get; set; }

        public string CharacterImage { get; set; }

        public int ComputerGameId { get; set; }

        public virtual ComputerGame ComputerGame { get; set; }
    }
    public class ComputerGameData : DbContext
    {
        public ComputerGameData() : base("MyComputerData") { }
        public DbSet<Character> Characters { get; set; }
        public DbSet<ComputerGame> ComputerGames { get; set; }
    }
}
