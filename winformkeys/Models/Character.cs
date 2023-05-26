using System.ComponentModel.DataAnnotations;

namespace winformkeys.Models
{
    public class Character
    {

        public int Id { get; set; }  
        public string CharacterName { get; set; }
        public string GameAffiliation { get; set; }
        public virtual ICollection<SpecialMove> SpecialMovesList { get; set; }


    }
}
