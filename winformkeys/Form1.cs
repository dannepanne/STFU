

using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using winformkeys.Data;
using winformkeys.Models;
using winformkeys.TextToSF4;
using winformkeys.Utilities;

namespace winformkeys
{



    /// <summary>
    /// /possible to input several things after another instead of one at a time, possible to block. database with characters which then decides whick specials are possible
    /// </summary>
    public partial class Form1 : Form
    {
        private DataInitialize datainit = new DataInitialize();
        private IMoves moves = new Moves();
        private Specials specials = new Specials();
        private bool facingRight = true;
       
        private string imageLocation = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Screenshot.png");


        
        private List<Character> characters = new List<Character>();
        public Form1()
        {
            InitializeComponent();
            characters = datainit.DataInitializeCharacters();

           // var context = new MLContext();

            using (var ctx = new FighterContext())
            {
                ctx.Database.EnsureCreated();
            }

        }



        public static int GetSFIVProcess()
        {
            int id = 0;
            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                if (p.ProcessName == "SSFIV")
                    id = p.Id;

            }
            return id;
        }



        private string? input;
        Process process = Process.GetProcessById(GetSFIVProcess());
        Process processMain = Process.GetCurrentProcess();

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                List<SpecialMove> specMoves = characters[0].SpecialMovesList.ToList();
                IntPtr windowHandleMain = processMain.MainWindowHandle;
                IntPtr windowHandle = process.MainWindowHandle;


                PredictFacingRight();



                string strength = "";

                var inputToSplit = StringSplitter(input);

                var move = inputToSplit.Item1.ToString();

                if (inputToSplit.Item2.ToLower() != "")
                {

                    strength = inputToSplit.Item2.ToLower();

                }
                else
                {
                    strength = "light";
                }

                //SWITCH CASE THAT TRIGGERS IF SPECIAL INPUT STRING IS SAME AS ATTACK!

                string switchcase = "";

                foreach (SpecialMove s in specMoves)
                {
                    if (s.SpecialMoveName.ToLower() == move)
                        switchcase = s.SpecialMoveInput;

                }

                switch (switchcase) //case standard // choose strength
                {
                    case "QCForwardPunch":

                        SetForegroundWindow(windowHandle);
                        specials.QCForwardPunch(strength, facingRight);
                        SetForegroundWindow(windowHandleMain);
                        break;

                    case "DPForwardPunch":
                        SetForegroundWindow(windowHandle);
                        specials.DPForwardPunch(strength, facingRight);
                        SetForegroundWindow(windowHandleMain);
                        break;

                    case "QCBackwardKick":
                        SetForegroundWindow(windowHandle);
                        specials.QCBackKick(strength, facingRight);
                        SetForegroundWindow(windowHandleMain);
                        break;


                        SendKeys.SendWait("{ENTER}");
                        Thread.Sleep(500);



                        SetForegroundWindow(windowHandleMain);
                        listBox1.Items.Add(move + " " + strength);

                        textBox1.Clear();
                }
            }
        }

        private Tuple<string, string> StringSplitter(string input)
        {
            string[] split = input.Split(' ');
            string move = split[0];
            string strength = "";

            if(split.Length > 1)            
            { 
                strength = split[1]; 
            } 
       
            return Tuple.Create(move, strength);
        }

        private void PredictFacingRight()
        {
            var i = new Utils();
            i.ScreenGrab();
            var image = (Bitmap)Image.FromFile(imageLocation);




            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}