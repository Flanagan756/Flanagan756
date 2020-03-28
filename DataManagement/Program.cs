using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8_OOD_Online;


namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamData db = new TeamData();
            using(db)
            {

                Team t1 = new Team() { TeamId = 1, TeamName = "Sligo Rovers", Location = "Sligo", };
                Player p1 = new Player() { PlayerId = 1, Name = "Tom", Position = "Forward", TeamId = 1, Team = t1 };
                Player p2 = new Player() { PlayerId = 1, Name = "Mick", Position = "Defender", TeamId = 1, Team = t1 };

                Team t2 = new Team() { TeamId = 2, TeamName = "Hampton FC", Location = "Hampton", };
                Player p3 = new Player() { PlayerId = 3, Name = "James", Position = "Midfielder", TeamId = 2, Team = t2 };
                Player p4 = new Player() { PlayerId = 4, Name = "Paul", Position = "Goalkeeper", TeamId = 2, Team = t2 };

                db.Teams.Add(t1);
                db.Teams.Add(t2);

                Console.WriteLine("Added the teams to the database");

                db.Players.Add(p1);
                db.Players.Add(p2);
                db.Players.Add(p3);
                db.Players.Add(p4);

                Console.WriteLine("Added Players to the database");

                db.SaveChanges();

                Console.WriteLine("Saved changes to the database");
            }
        }
    }
}
