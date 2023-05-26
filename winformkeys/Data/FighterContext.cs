using Microsoft.EntityFrameworkCore;
using winformkeys.Models;

namespace winformkeys.Data
{
    public class FighterContext : DbContext
    {
        public FighterContext() : base()
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<SpecialMove> SpecialMoves { get; set; }


    }
}
