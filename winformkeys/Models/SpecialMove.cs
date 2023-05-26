using System.ComponentModel.DataAnnotations.Schema;

namespace winformkeys.Models
{
    public class SpecialMove
    {
        public int Id { get; set; }
       
        public string SpecialMoveName { get; set; }
        public string SpecialMoveInput { get; set; }

        public virtual Character Character { get; set; }
    }
}
