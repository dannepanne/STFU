namespace winformkeys.TextToSF4
{
    public class Moves : IMoves
    {

        public string Up()
        {
            return "^";
        }
        public string Down()
        {
            return "+";
        }
        public string Right()
        {
            return "{RIGHT}";
        }

        public string Left()
        {
            return "{LEFT}";
        }
        public string DiagonalDownLeft()
        {
            return "+{LEFT}";
        }
        public string DiagonalDownRight()
        {
            return "+{RIGHT}";
        }
        public string DiagonalUpLeft()
        {
            return "^{LEFT}";
        }
        public string DiaginalUpRight()
        {
            return "^{RIGHT}";
        }


        public string LightPunch()
        {
            return "q";
        }

        public string LightKick()
        {
            return "a";
        }
        public string MediumPunch()
        {
            return "w";
        }
        public string MediumKick()
        {
            return "s";
        }

        public string HardPunch()
        {
            return "e";
        }

        public string HardKick()
        {
            return "d";
        }

    }
}
