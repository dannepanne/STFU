using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using winformkeys.Models;

namespace winformkeys.Data
{
    public class FighterContext : DbContext
    {
        private string dBconnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=FighterDatabase;Integrated Security=True";

        public FighterContext() : base()
        {

        }
        
        public DbSet<Character> Characters { get; set; }
        public DbSet<SpecialMove> SpecialMoves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(dBconnectionString);

        }


        public void SeedData()
        {
            using (var ctx = new FighterContext())
            {
                if(!ctx.Characters.Any())
                {
                    var newcharacter = new Character
                    {
                        CharacterName = "Ryu",
                        //Id = 1,
                        GameAffiliation = "Ultra Street Fighter 4",
                        SpecialMovesList = new List<SpecialMove>()
                       {
                            new SpecialMove {
                            SpecialMoveName = "Shoryuken",
                            SpecialMoveInput = "DPForwardPunch"
                             },
                            new SpecialMove {
                            SpecialMoveName = "Hadoken",
                            SpecialMoveInput = "QCForwardPunch"
                            },
                            new SpecialMove {
                            SpecialMoveName = "Tatsumaki",
                            SpecialMoveInput = "QCBackwardKick"
                             }

                        }

                    };

                    ctx.Characters.Add(newcharacter);
                    ctx.SaveChanges();
                }
            }

        }


    }
}
