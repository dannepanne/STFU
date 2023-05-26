using winformkeys.Models;

namespace winformkeys.Data
{
    public class DataInitialize
    {

        public List<Character> DataInitializeCharacters()
        {
            //TODO
            //using (var ctx = new FighterContext())
            //{
            //    var newDbCharacter = new Character()
            //    {
            //        CharacterName = "Ryu",
            //        Id = 1,
            //        GameAffiliation = "Ultra Street Fighter 4",
            //        SpecialMovesList = new List<SpecialMove>()
            //    {
            //        new SpecialMove {
            //        SpecialMoveName = "Shoryuken",
            //        SpecialMoveInput = "DPF+P"
            //        },
            //        new SpecialMove {
            //        SpecialMoveName = "Hadoken",
            //        SpecialMoveInput = "QCF+P"
            //        },
            //        new SpecialMove {
            //        SpecialMoveName = "Tatsumaki",
            //        SpecialMoveInput = "QCB+K"
            //        }

            //    }
            //    };

            //    ctx.Characters.Add(newDbCharacter);
            //    ctx.SaveChanges();
            //}


            List<Character> LoadedCharacters = new List<Character>();

            Character newcharacter = new Character
            {
                CharacterName = "Ryu",
                Id = 1,
                GameAffiliation = "Ultra Street Fighter 4",
                SpecialMovesList = new List<SpecialMove>()
                {
                    new SpecialMove {
                    SpecialMoveName = "Shoryuken",
                    SpecialMoveInput = "DPF+P"
                    },
                    new SpecialMove {
                    SpecialMoveName = "Hadoken",
                    SpecialMoveInput = "QCF+P"
                    },
                    new SpecialMove {
                    SpecialMoveName = "Tatsumaki",
                    SpecialMoveInput = "QCB+K"
                    }

                }
            };
            LoadedCharacters.Add(newcharacter);


            return LoadedCharacters;
        }




    }
}
