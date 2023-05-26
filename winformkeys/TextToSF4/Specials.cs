namespace winformkeys.TextToSF4
{
    public class Specials
    {

        private Moves moves = new Moves();


        public void KickStrength(string strength)
        {
            switch (strength)
            {
                case ("light"):
                    SendKeys.SendWait(moves.LightKick());
                    break;
                case ("medium"):
                    SendKeys.SendWait(moves.MediumKick());
                    break;
                case ("hard"):
                    SendKeys.SendWait(moves.HardKick());
                    break;
            }
        }
        public void PunchStrength(string strength)
        {
            switch (strength)
            {
                case ("light"):
                    SendKeys.SendWait(moves.LightPunch());
                    break;
                case ("medium"):
                    SendKeys.SendWait(moves.MediumPunch());
                    break;
                case ("hard"):
                    SendKeys.SendWait(moves.HardPunch());
                    break;
            }
        }


        public void QCForwardPunch(string punchstrength, bool facingRight) //QuartercircleforwardPunch /switch for strenght
        {

            if (facingRight)
            {
                SendKeys.SendWait(moves.Down());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.DiagonalDownRight());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.Right());
                Thread.Sleep(100);
            }
            else if (!facingRight)
            {
                SendKeys.SendWait(moves.Down());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.DiagonalDownLeft());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.Left());
                Thread.Sleep(100);
            }

            PunchStrength(punchstrength.ToLower());

        }

        public void DPForwardPunch(string punchstrength, bool facingRight) //DPforward /switch for strenght
        {
            if (facingRight)
            {
                SendKeys.SendWait(moves.Right());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.Down());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.DiagonalDownRight());
                Thread.Sleep(100);
            }
            else if (!facingRight)
            {
                SendKeys.SendWait(moves.Left());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.Down());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.DiagonalDownLeft());
                Thread.Sleep(100);
            }

            PunchStrength(punchstrength.ToLower());
        }

        public void QCBackKick(string kickstrenght, bool facingRight)
        {
            if (facingRight)
            {
                SendKeys.SendWait(moves.Down());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.DiagonalDownLeft());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.Left());
                Thread.Sleep(100);
            }
            else if (!facingRight)
            {
                SendKeys.SendWait(moves.Down());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.DiagonalDownRight());
                Thread.Sleep(100);
                SendKeys.SendWait(moves.Right());
                Thread.Sleep(100);
            }

            KickStrength(kickstrenght.ToLower());

        }


        public void ChargeBackToForwardPunch()
        {

        }

        public void ChargeBackToForwardKick()
        {

        }
        public void ChargeDownToUpPunch()
        {

        }
        public void ChargeDownToUpKick()
        {

        }
    }
}
