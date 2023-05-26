
using winformkeys.Data;
using winformkeys.Models;

class Program
{

    public void CreateDatabase()
    {
        using (var ctx = new FighterContext())
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

