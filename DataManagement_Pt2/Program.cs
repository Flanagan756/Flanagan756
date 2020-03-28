using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8_OOD_Online_Pt2;

namespace DataManagement_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerGameData db = new ComputerGameData();
            using (db)
            {

                ComputerGame cg1 = new ComputerGame() {ComputerGameId=1,Name="Sonic the Hedgehog", Genre="Adventure"};
                Character c1 = new Character() { CharacterId = 1, CharacterName = "Sonic", CharacterImage= "https://i.pinimg.com/originals/40/b6/a7/40b6a72c040834dc917e15937a14d41e.png",ComputerGameId= 1};
                Character c2 = new Character() { CharacterId = 2, CharacterName = "Tails", CharacterImage = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1a/Miles_%22Tails%22_Prower_Sonic_and_All-Stars_Racing_Transformed.png/220px-Miles_%22Tails%22_Prower_Sonic_and_All-Stars_Racing_Transformed.png", ComputerGameId = 1 };

                ComputerGame cg2 = new ComputerGame() { ComputerGameId = 2, Name = "Street Fighter", Genre = "Fighting" };
                Character c3 = new Character() { CharacterId = 3, CharacterName = "Ryu", CharacterImage = "https://i.pinimg.com/originals/5d/1c/47/5d1c4764f5ffb23ef0b8f30ffcee7551.jpg", ComputerGameId = 2 };
                Character c4 = new Character() { CharacterId = 4, CharacterName = "Ken", CharacterImage = "https://i.pinimg.com/originals/a4/e3/16/a4e3165030a3715c35a7ac38960c55fe.gif", ComputerGameId = 2 };


                db.ComputerGames.Add(cg1);
                db.ComputerGames.Add(cg2);

                Console.WriteLine("Added the Computer Games to the database");

                db.Characters.Add(c1);
                db.Characters.Add(c2);
                db.Characters.Add(c3);
                db.Characters.Add(c4);


                Console.WriteLine("Added Characters to the database");

                db.SaveChanges();

                Console.WriteLine("Saved changes to the database");
            }
        }
    }
}
