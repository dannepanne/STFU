using System.Diagnostics;
using winformkeys.Data;
using winformkeys.Models;
using winformkeys.TextToSF4;


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

        private List<Character> characters = new List<Character>();
        public Form1()
        {
            InitializeComponent();
            characters = datainit.DataInitializeCharacters();
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



        private string input;
        Process process = Process.GetProcessById(GetSFIVProcess());
        Process processMain = Process.GetCurrentProcess();

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //SWITCH
                if (process != null)
                {
                    input = textBox1.Text.ToLower();
                    if (input == "changedirection")
                    {
                        facingRight = !facingRight;
                    }
                    if (input == "facingright")
                    {
                        facingRight = true;
                    }
                    if (input == "facingleft")
                    {
                        facingRight = false;
                    }
                    if (input == "enter")
                    {


                        IntPtr windowHandle = process.MainWindowHandle;
                        SetForegroundWindow(windowHandle);
                        Thread.Sleep(500);


                        SendKeys.SendWait("{ENTER}");
                        Thread.Sleep(500);

                    }
                    else if (input == "fireball")
                    {

                        IntPtr windowHandle = process.MainWindowHandle;
                        SetForegroundWindow(windowHandle);


                        Thread.Sleep(100);

                        specials.QCForwardPunch("hard", facingRight);

                        Thread.Sleep(500);

                    }
                    else if (input == "dragonpunch")
                    {

                        IntPtr windowHandle = process.MainWindowHandle;
                        SetForegroundWindow(windowHandle);
                        Thread.Sleep(100);



                        Thread.Sleep(500);

                    }
                    else if (input == "hardkick")
                    {



                        IntPtr windowHandle = process.MainWindowHandle;
                        SetForegroundWindow(windowHandle);
                        Thread.Sleep(500);


                        SendKeys.SendWait(moves.HardKick());
                        Thread.Sleep(500);

                    }
                    else if (input == "jump")
                    {

                        IntPtr windowHandle = process.MainWindowHandle;
                        SetForegroundWindow(windowHandle);
                        Thread.Sleep(500);

                        SendKeys.SendWait(moves.DiaginalUpRight());

                        Thread.Sleep(500);

                    }
                    else if (input == "down")
                    {



                        IntPtr windowHandle = process.MainWindowHandle;
                        SetForegroundWindow(windowHandle);
                        Thread.Sleep(500);

                        SendKeys.SendWait(moves.Down());

                        Thread.Sleep(500);

                    }
                    else if (input == "backdash")
                    {

                        IntPtr windowHandle = process.MainWindowHandle;
                        SetForegroundWindow(windowHandle);
                        Thread.Sleep(500);

                        SendKeys.SendWait("{LEFT 3}");

                        Thread.Sleep(500);

                    }
                    else if (input == "block")
                    {

                        IntPtr windowHandle = process.MainWindowHandle;
                        SetForegroundWindow(windowHandle);
                        Thread.Sleep(500);
                        //Need to solve this!

                    }
                }
                IntPtr windowHandleMain = processMain.MainWindowHandle;
                SetForegroundWindow(windowHandleMain);

                listBox1.Items.Add(input);
                textBox1.Clear();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}