using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Xml;

namespace blighted_
{
    public partial class Form1 : Form
    {
        //Variables/global objects/bools
        int scene = 0;
        int countdown = 31;
        bool hasSword = false;
        bool hashealthpotion = false;
        bool choosetodrinkPotion = false;
        bool vagabondinparty = false;
        bool hasFang = false;
        bool hasExtract = false;
        bool hasMilk = false;
        SoundPlayer mainTheme = new SoundPlayer(Properties.Resources.Free_People);
        SoundPlayer titleTheme = new SoundPlayer(Properties.Resources.Eerie_Angel);
        SoundPlayer battleTheme = new SoundPlayer(Properties.Resources.Fight_The_Monsters);
        SoundPlayer mountainTheme = new SoundPlayer(Properties.Resources.Behind_The_Picket_Fences);
        SoundPlayer desertTheme = new SoundPlayer(Properties.Resources.Eastern_Nature);
        SoundPlayer sadTheme = new SoundPlayer(Properties.Resources.Death_Of_The_Rainbow);
        SoundPlayer bossTheme = new SoundPlayer(Properties.Resources.Deepest_Recesses);
        SoundPlayer creditTheme = new SoundPlayer(Properties.Resources.credits);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            titleTheme.PlayLooping();
            titleLabel.Visible = false;
            option1Label.Visible = false;
            option2Label.Visible = false;
            option3Label.Visible = false;
            option4Label.Visible = false;
            dialogueText.Visible = false;
            settingPicture.Visible = false;
            titleLabel.Visible = false;
            titleLabel.Visible = false;
            inventoryLabel.Visible = false;
            creditLabel.Visible = false;
            logopicBox.Visible = false;
            dialogueText.Text = "You: Hey mother, I’m not feeling too well. What do you think I should do?";
            dialogueText.Text += "\n\nIt’s up to you. I believe Hygieia would be available to see you at this time. Maybe sleeping could do you some good. Fresh air could do you some good too.";
            option1Label.Text = "Go to sleep(Q)";
            option2Label.Text = "Go to Hygieia's hut(W)";
            option3Label.Text = "";
            option4Label.Text = "";
        }


        private void startButton_Click(object sender, EventArgs e)//start button on start menu
        {
            Thread.Sleep(100);
            titleTheme.Stop();
            mainTheme.PlayLooping();
            startButton.Visible = false;
            option1Label.Visible = true;
            option2Label.Visible = true;
            option3Label.Visible = true;
            option4Label.Visible = true;
            dialogueText.Visible = true;
            settingPicture.Visible = true;
            inventoryLabel.Visible = true;
            tilldeathTimer.Start();
            this.Focus();
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int combatRand;
            Random randNum = new Random();
            combatRand = randNum.Next(1, 10);
            if (countdown <= 0)//end of game if run out of time/health
            {
                dialogueText.Text = "You ran out of health and the disease finally takes over your body as you fall to the ground. Your dead body lays there motionless for a minute. Then your head slowly rises up from the ground and your eyes are blood red.";
                option1Label.Text = "";
                option2Label.Text = "";
                option3Label.Text = "";
                option4Label.Text = "";
                Refresh();
                Thread.Sleep(10000);
                Credits();
                Refresh();
            }
            if (e.KeyCode == Keys.Q)//Option 1
            {
                if (scene == 0) { scene = 1; Thread.Sleep(300); }
                else if (scene == 1) { scene = 2; Thread.Sleep(300); }
                else if (scene == 2) { scene = 3; Thread.Sleep(300); }
                else if (scene == 5) { scene = 6; Thread.Sleep(300); }
                else if (scene == 7) { scene = 6; Thread.Sleep(300); }
                else if (scene == 8) { scene = 9; Thread.Sleep(300); }
                else if (scene == 9) { scene = 6; Thread.Sleep(300); }
                else if (scene == 10) { scene = 6; Thread.Sleep(300); }
                else if (scene == 11) { scene = 6; Thread.Sleep(300); }
                else if (scene == 12) { scene = 13; Thread.Sleep(300); }
                else if (scene == 6) { scene = 12; Thread.Sleep(300); }
                else if (scene == 13 && hasSword == false && combatRand > 5) { scene = 14; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 13 && hasSword == false && combatRand < 5) { scene = 19; }
                else if (scene == 19 && combatRand > 5) { scene = 15; Thread.Sleep(300); }
                else if (scene == 19 && combatRand < 5) { scene = 19; Thread.Sleep(300); }
                else if (scene == 19 && hasSword == true && combatRand > 5) { scene = 16; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 19 && hasSword == true && combatRand < 5) { scene = 19; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 14) { scene = 15; }
                else if (scene == 13 && hasSword == true && combatRand > 5) { scene = 16; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 13 && hasSword == true && combatRand < 5) { scene = 19; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 17) { scene = 13; Thread.Sleep(300); }
                else if (scene == 18) { scene = 13; Thread.Sleep(300); }
                else if (scene == 15) { scene = 20; Thread.Sleep(300); }
                else if (scene == 16) { scene = 20; Thread.Sleep(300); }
                else if (scene == 20) { scene = 22; Thread.Sleep(300); }
                else if (scene == 21) { scene = 23; Thread.Sleep(300); }
                else if (scene == 22) { scene = 23; Thread.Sleep(300); }
                else if (scene == 23) { scene = 25; Thread.Sleep(300); }
                else if (scene == 24) { scene = 25; Thread.Sleep(300); }
                else if (scene == 25) { scene = 25; Thread.Sleep(300); }
                else if (scene == 26) { scene = 27; Thread.Sleep(300); }
                else if (scene == 27) { scene = 28; Thread.Sleep(300); }
                else if (scene == 28) { scene = 31; Thread.Sleep(300); }
                else if (scene == 31) { scene = 32; Thread.Sleep(300); }
                else if (scene == 30) { scene = 31; Thread.Sleep(300); }
                else if (scene == 28) { scene = 31; Thread.Sleep(300); }
                else if (scene == 29) { scene = 31; Thread.Sleep(300); }
                else if (scene == 32) { scene = 36; Thread.Sleep(300); }
                else if (scene == 33) { scene = 36; Thread.Sleep(300); }
                else if (scene == 34) { scene = 36; Thread.Sleep(300); }
                else if (scene == 35) { scene = 36; Thread.Sleep(300); }
                else if (scene == 36) { scene = 37; Thread.Sleep(300); }
                else if (scene == 37) { scene = 39; Thread.Sleep(300); }
                else if (scene == 39 && combatRand > 5) { scene = 41; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 39 && combatRand < 5) { scene = 40; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 40 && combatRand > 5) { scene = 41; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 40 && combatRand < 5) { scene = 40; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 41) { scene = 38; Thread.Sleep(300); choosetodrinkPotion = true; }
                else if (scene == 38) { scene = 42; Thread.Sleep(300); }
                else if (scene == 42) { scene = 43; Thread.Sleep(300); }
                else if (scene == 43) { scene = 42; Thread.Sleep(300); }
                else if (scene == 44) { scene = 42; Thread.Sleep(300); }
                else if (scene == 46) { scene = 42; Thread.Sleep(300); }
                else if (scene == 45) { scene = 47; Thread.Sleep(300); }
                else if (scene == 47) { scene = 48; Thread.Sleep(300); }
                else if (scene == 48) { scene = 51; Thread.Sleep(300); }
                else if (scene == 49) { scene = 54; Thread.Sleep(300); }
                else if (scene == 50) { scene = 42; Thread.Sleep(300); }
                else if (scene == 51) { scene = 42; Thread.Sleep(300); }
                else if (scene == 54) { scene = 55; Thread.Sleep(300); }
                else if (scene == 52) { scene = 54; Thread.Sleep(300); }
                else if (scene == 53) { scene = 54; Thread.Sleep(300); }
                else if (scene == 55) { scene = 58; Thread.Sleep(300); }
                else if (scene == 56) { scene = 58; Thread.Sleep(300); }
                else if (scene == 57) { scene = 58; Thread.Sleep(300); }
                else if (scene == 58) { scene = 59; Thread.Sleep(300); }
                else if (scene == 59) { scene = 60; Thread.Sleep(300); }
                else if (scene == 60) { scene = 61; Thread.Sleep(300); }
                else if (scene == 61) { scene = 63; Thread.Sleep(300); }
                else if (scene == 62) { scene = 64; Thread.Sleep(300); }
                else if (scene == 63) { scene = 65; Thread.Sleep(300); }
                else if (scene == 64) { scene = 65; Thread.Sleep(300); }
                else if (scene == 66) { scene = 67; Thread.Sleep(300); }
                else if (scene == 67) { scene = 69; Thread.Sleep(300); }
                else if (scene == 68) { scene = 69; Thread.Sleep(300); }
                else if (scene == 69) { scene = 70; Thread.Sleep(300); }
                else if (scene == 65) { scene = 63; Thread.Sleep(300); }
                else if (scene == 72) { scene = 73; Thread.Sleep(300); }
                else if (scene == 73 && combatRand > 5) { scene = 75; combatRand = randNum.Next(1, 11);  Thread.Sleep(300); }
                else if (scene == 73 && combatRand < 5) { scene = 74; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 74 && combatRand > 5) { scene = 75; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 74 && combatRand < 5) { scene = 74; combatRand = randNum.Next(1, 11); Thread.Sleep(300); }
                else if (scene == 70) { Credits(); }
                else if (scene == 71) { Credits(); }
                else if (scene == 75) { Credits(); }

            }
            else if (e.KeyCode == Keys.W)//Option 2
            {
                if (scene == 0) { scene = 2; Thread.Sleep(300); }
                else if (scene == 3) { scene = 5; Thread.Sleep(300); }
                else if (scene == 2) { scene = 5; Thread.Sleep(300); }
                else if (scene == 5) { scene = 7; Thread.Sleep(300); }
                else if (scene == 7) { scene = 8; Thread.Sleep(300); }
                else if (scene == 8) { scene = 10; Thread.Sleep(300); }
                else if (scene == 12) { scene = 17; Thread.Sleep(300); }
                else if (scene == 20) { scene = 21; Thread.Sleep(300); }
                else if (scene == 21) { scene = 24; Thread.Sleep(300); }
                else if (scene == 22) { scene = 24; Thread.Sleep(300); }
                else if (scene == 15) { scene = 20; Thread.Sleep(300); choosetodrinkPotion = true; }
                else if (scene == 16) { scene = 20; Thread.Sleep(300); choosetodrinkPotion = true; }
                else if (scene == 23) { scene = 25; Thread.Sleep(300); }
                else if (scene == 24) { scene = 25; Thread.Sleep(300); }
                else if (scene == 25) { scene = 25; Thread.Sleep(300); }
                else if (scene == 27) { scene = 29; Thread.Sleep(300); }
                else if (scene == 30) { scene = 29; Thread.Sleep(300); }
                else if (scene == 31) { scene = 33; Thread.Sleep(300); }
                else if (scene == 36) { scene = 38; Thread.Sleep(300); }
                else if (scene == 42) { scene = 44; Thread.Sleep(300); }
                else if (scene == 47) { scene = 49; Thread.Sleep(300); }
                else if (scene == 48) { scene = 52; Thread.Sleep(300); }
                else if (scene == 49) { scene = 51; Thread.Sleep(300); }
                else if (scene == 41) { scene = 38; Thread.Sleep(300); choosetodrinkPotion = true; }
                else if (scene == 54) { scene = 56; Thread.Sleep(300); }
                else if (scene == 59) { scene = 61; Thread.Sleep(300); }
                else if (scene == 60) { scene = 62; Thread.Sleep(300); }
                else if (scene == 63) { scene = 66; Thread.Sleep(300); }
                else if (scene == 64) { scene = 66; Thread.Sleep(300); }
                else if (scene == 66) { scene = 68; Thread.Sleep(300); }
                else if (scene == 69) { scene = 71; Thread.Sleep(300); }
            }
            else if (e.KeyCode == Keys.E)//option 3
            {
                if (scene == 5) { scene = 8; Thread.Sleep(300); }
                else if (scene == 8) { scene = 11; Thread.Sleep(300); }
                else if (scene == 12) { scene = 18; Thread.Sleep(300); }
                else if (scene == 21) { scene = 23; Thread.Sleep(300); }
                else if (scene == 22) { scene = 23; Thread.Sleep(300); }
                else if (scene == 23) { scene = 25; Thread.Sleep(300); }
                else if (scene == 24) { scene = 25; Thread.Sleep(300); }
                else if (scene == 25) { scene = 25; Thread.Sleep(300); }
                else if (scene == 27) { scene = 30; Thread.Sleep(300); }
                else if (scene == 31) { scene = 34; Thread.Sleep(300); }
                else if (scene == 42) { scene = 45; Thread.Sleep(300); }
                else if (scene == 47) { scene = 50; Thread.Sleep(300); }
                else if (scene == 48) { scene = 53; Thread.Sleep(300); }
                else if (scene == 54) { scene = 57; Thread.Sleep(300); }
                else if (scene == 59) { scene = 62; Thread.Sleep(300); }
                else if (scene == 69) { scene = 72; Thread.Sleep(300); }
            }
            else if (e.KeyCode == Keys.R)//option 4
            {
                if (scene == 8) { scene = 6; }
                else if (scene == 23) { scene = 26; Thread.Sleep(300); }
                else if (scene == 24) { scene = 26; Thread.Sleep(300); }
                else if (scene == 25) { scene = 26; Thread.Sleep(300); }
                else if (scene == 42) { scene = 46; Thread.Sleep(300); }
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Add || e.KeyCode == Keys.Alt || e.KeyCode == Keys.Apps || e.KeyCode == Keys.Attn || e.KeyCode == Keys.B || e.KeyCode == Keys.Back || e.KeyCode == Keys.BrowserBack || e.KeyCode == Keys.BrowserFavorites || e.KeyCode == Keys.BrowserForward || e.KeyCode == Keys.BrowserHome || e.KeyCode == Keys.BrowserRefresh || e.KeyCode == Keys.BrowserSearch || e.KeyCode == Keys.BrowserStop || e.KeyCode == Keys.C || e.KeyCode == Keys.Cancel || e.KeyCode == Keys.Capital || e.KeyCode == Keys.CapsLock || e.KeyCode == Keys.Clear || e.KeyCode == Keys.Control || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Crsel || e.KeyCode == Keys.D || e.KeyCode == Keys.D0 || e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.D5 || e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9 || e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Divide || e.KeyCode == Keys.Down || e.KeyCode == Keys.End || e.KeyCode == Keys.Enter || e.KeyCode == Keys.EraseEof || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Execute || e.KeyCode == Keys.Exsel || e.KeyCode == Keys.F || e.KeyCode == Keys.F1 || e.KeyCode == Keys.F10 || e.KeyCode == Keys.F11 || e.KeyCode == Keys.F12 || e.KeyCode == Keys.F13 || e.KeyCode == Keys.F14 || e.KeyCode == Keys.F15 || e.KeyCode == Keys.F16 || e.KeyCode == Keys.F17 || e.KeyCode == Keys.F18 || e.KeyCode == Keys.F19 || e.KeyCode == Keys.F2 || e.KeyCode == Keys.F20 || e.KeyCode == Keys.F21 || e.KeyCode == Keys.F22 || e.KeyCode == Keys.F23 || e.KeyCode == Keys.F24 || e.KeyCode == Keys.F3 || e.KeyCode == Keys.F4 || e.KeyCode == Keys.F5 || e.KeyCode == Keys.F6 || e.KeyCode == Keys.F7 || e.KeyCode == Keys.F8 || e.KeyCode == Keys.F9 || e.KeyCode == Keys.FinalMode || e.KeyCode == Keys.G || e.KeyCode == Keys.H || e.KeyCode == Keys.HanguelMode || e.KeyCode == Keys.HangulMode || e.KeyCode == Keys.HanjaMode || e.KeyCode == Keys.Help || e.KeyCode == Keys.Home || e.KeyCode == Keys.I || e.KeyCode == Keys.IMEAccept || e.KeyCode == Keys.IMEAceept || e.KeyCode == Keys.IMEConvert || e.KeyCode == Keys.IMEModeChange || e.KeyCode == Keys.IMENonconvert || e.KeyCode == Keys.Insert || e.KeyCode == Keys.J || e.KeyCode == Keys.JunjaMode || e.KeyCode == Keys.K || e.KeyCode == Keys.KanaMode || e.KeyCode == Keys.KanjiMode || e.KeyCode == Keys.L || e.KeyCode == Keys.LaunchApplication1 || e.KeyCode == Keys.LaunchApplication2 || e.KeyCode == Keys.LaunchMail || e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.Left || e.KeyCode == Keys.LineFeed || e.KeyCode == Keys.LMenu || e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.LWin || e.KeyCode == Keys.M || e.KeyCode == Keys.MediaNextTrack || e.KeyCode == Keys.MediaPlayPause || e.KeyCode == Keys.MediaPreviousTrack || e.KeyCode == Keys.MediaStop || e.KeyCode == Keys.Menu || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.N || e.KeyCode == Keys.Next || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.O || e.KeyCode == Keys.Oem1 || e.KeyCode == Keys.Oem102 || e.KeyCode == Keys.Oem2 || e.KeyCode == Keys.Oem3 || e.KeyCode == Keys.Oem4 || e.KeyCode == Keys.Oem5 || e.KeyCode == Keys.Oem6 || e.KeyCode == Keys.Oem7 || e.KeyCode == Keys.Oem8 || e.KeyCode == Keys.OemBackslash || e.KeyCode == Keys.OemClear || e.KeyCode == Keys.OemCloseBrackets || e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.OemOpenBrackets || e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.OemPipe || e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.OemQuestion || e.KeyCode == Keys.OemQuotes || e.KeyCode == Keys.OemSemicolon || e.KeyCode == Keys.Oemtilde || e.KeyCode == Keys.P || e.KeyCode == Keys.Pa1 || e.KeyCode == Keys.PageDown || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Pause || e.KeyCode == Keys.Play || e.KeyCode == Keys.Print || e.KeyCode == Keys.PrintScreen || e.KeyCode == Keys.Prior || e.KeyCode == Keys.ProcessKey || e.KeyCode == Keys.RControlKey || e.KeyCode == Keys.Return || e.KeyCode == Keys.Right || e.KeyCode == Keys.RMenu || e.KeyCode == Keys.RShiftKey || e.KeyCode == Keys.RWin || e.KeyCode == Keys.S || e.KeyCode == Keys.Scroll || e.KeyCode == Keys.Select || e.KeyCode == Keys.SelectMedia || e.KeyCode == Keys.Separator || e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.Sleep || e.KeyCode == Keys.Snapshot || e.KeyCode == Keys.Space || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.T || e.KeyCode == Keys.Tab || e.KeyCode == Keys.U || e.KeyCode == Keys.Up || e.KeyCode == Keys.V || e.KeyCode == Keys.VolumeDown || e.KeyCode == Keys.VolumeMute || e.KeyCode == Keys.VolumeUp || e.KeyCode == Keys.X || e.KeyCode == Keys.Y || e.KeyCode == Keys.Z || e.KeyCode == Keys.Zoom)
            {
                MessageBox.Show("ONLY PRESS Q, W, E OR R!");
            }
            switch (scene)
            {
                case 1:

                    //Go to sleep choice from scene 1
                    dialogueText.Text = "You go to sleep. A few minutes later you hear the sounds of people screaming. You quickly get up from bed, ";
                    dialogueText.Text += "\nMother: Sorry did I wake you up? , this monster of a wasp flew in the window with the greatest of stingers, it startled me, Anyway if you’re not feeling any better you should go to Hygiea now.";
                    countdown--;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    dialogueText.Text += "\n(I’m not feeling any better maybe she is right...)";
                    option1Label.Text = "Go to Hygiea`s hut(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 2:

                    titleLabel.Visible = true;
                    //go to hygeia form sleep
                    dialogueText.Text = "Groggily you set out to find Hygeia, having decided to sleep later";
                    countdown--;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    dialogueText.Text += "\n\nHygeia: Hello, your mother told me you’d be visiting me. So what brings you here today?";
                    dialogueText.Text += "\n\nThere has been a great sickness rumoured to have befallen this village, and I am afraid I may be among them.";
                    dialogueText.Text += "\n\nHygeia: By the divines! my boy you sound so anxious and distraught, let me take a look and see what we can find.";
                    dialogueText.Text += "\n\nHygiea: After Examining you, you seem to have a case of Everling influenza, this is a deadly disease my boy, do not lose hope, there is a cure. You will need the following; Enchanted Fang, Sour Milk and Therian Extract";
                    dialogueText.Text += "\n\nHygiea: There is an old man up in the mountains that I believe can help you with finding these ingredients";
                    option1Label.Text = "Stay and rest for a while(Q)";
                    option2Label.Text = "Set out for the mountains(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 3:

                    //sleep in hygeia's hut
                    dialogueText.Text = "You stay an rest for a while...";
                    countdown--;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    option1Label.Text = "";
                    option2Label.Text = "Set out for the mountains(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 4://go to sleep at home

                    dialogueText.Text = "You go to sleep. a few minutes later you hear a person screaming. you quickly get up from bed.";
                    break;

                case 5://go up mountains
                    mountainTheme.PlayLooping();
                    dialogueText.Text = "You ascend up the mountain and arrive at the old mans hut.";
                    option1Label.Text = "Knock on the door(Q)";
                    option2Label.Text = "Just go in(W)";
                    option3Label.Text = "Walk around the back(E)";
                    option4Label.Text = "";
                    settingPicture.Image = (Properties.Resources.mountain_range);
                    break;

                case 6://knock on door

                    dialogueText.Text = "Hello old man, I was told by Hygiea to come seek your help in finding the three components needed to make the cure for everling influenza.";
                    dialogueText.Text += "\n\nAcikore: I am not a an old man I am a great and powerful Wizard. My name is Acikore. This is a very tricky disease to cure. It is not impossible I must say. First you will need to go to Toothless Fang Cave. You must get An enchanted Fang and bring back to me";
                    if (hasSword == true)
                    {
                        dialogueText.Text += "\n\n(Good thing I have a sword!)";
                        dialogueText.Text += "\n\nIs this cave dangerous?";
                        dialogueText.Text += "\n\nAcikore: The cave can be dangerous, but only when the Lasiodorain colony come back to the cave at night. You would most likely arrive at the cave at night. If you don’t want to fight the spiders, then wait till morning, Have a health potion, for safety";
                        inventoryLabel.Text += "\n\nx1 Health potion";
                        hashealthpotion = true;
                        dialogueText.Text += "\n\nThank you Acikore. I will come back with the enchanted fang.";
                    }
                    else
                    {
                        dialogueText.Text += "\n\nIs this cave dangerous? I don’t have anything to protect myself with.";
                        dialogueText.Text += "\n\nAcikore: The cave can be dangerous, but only when the Lasiodorain colony come back to the cave at night. You would most likely arrive at the cave at night. If you don’t want to fight the spiders, then wait till morning, ,  Have a health potion, for safety";
                        inventoryLabel.Text += "\n\nx1 Health potion";
                        hashealthpotion = true;
                        dialogueText.Text += "\n\nThank you Acikore. I will come back with the enchanted fang.";
                    }
                    option1Label.Text = "Head out to the cave(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 7://just enter door

                    dialogueText.Text = "This is trespassing, I should not just barge in!";
                    option1Label.Text = "Go back and knock on the door(Q)";
                    option2Label.Text = "Walk around the back(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 8://enter back door

                    dialogueText.Text = "You see an old door";
                    dialogueText.Text += "\n\nYou enter into a dark backroom, There are many potions on the walls";
                    option1Label.Text = "Drink green Potion(Q)";
                    option2Label.Text = "Drink red Potion(W)";
                    option3Label.Text = "Drink purple Potion(E)";
                    option4Label.Text = "Go back and knock on the door(R)";
                    break;

                case 9://drink green potion

                    dialogueText.Text = "You drink the green potion";
                    countdown = countdown - 5;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    dialogueText.Text += "\n\nIt was poisonous!";
                    option1Label.Text = "Go back and knock on the door(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 10://drink red potion

                    dialogueText.Text = "You drink the red potion";
                    dialogueText.Text += "\n\nYou feel a little better";
                    countdown++;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    option1Label.Text = "Go back and knock on the door(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 11://drink purple potion

                    dialogueText.Text = "You drink the purple potion";
                    dialogueText.Text += "\n\nYou feel something growing on your belt!";
                    dialogueText.Text += "\n\nYou look down to see a sword slowly appering in a hilt, It was a potion of arment! they are very rare! (+1 common sword to inventory)";
                    inventoryLabel.Text += "\n\nx1 Common sword";
                    hasSword = true;
                    option1Label.Text = "Go back and knock on the door(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 12://road to cave, combat with bandit
                    dialogueText.Text = "Bandit: Stop! or you will be cut down where you stand.";
                    dialogueText.Text += "\n\nThis guy doesn’t look to friendly!";
                    option1Label.Text = "Attack bandit(Q)";
                    option2Label.Text = "Ask what he wants.(W)";
                    option3Label.Text = "Run back the way you came.(E)";
                    break;
                case 13://combat
                    dialogueText.Text = "The bandit swings his sword and hits you for 1 damage";
                    battleTheme.PlayLooping();
                    countdown--;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    if (hasSword == false)
                    {
                        option1Label.Text = "Punch him with your fists(Q)";
                        option2Label.Text = "";
                        option3Label.Text = "";
                    }
                    else
                    {
                        option1Label.Text = "Strike him with your sword(Q)";
                        option2Label.Text = "";
                        option3Label.Text = "";
                    }
                    break;//fight with bandit
                case 14:
                    dialogueText.Text = "You hit him square across the jaw, stunning him for a second. He hits you back dealing 1 damage";
                    countdown--;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    option1Label.Text = "Hit him again(Q)";
                    break;
                case 15:
                    dialogueText.Text = "You hit him again , this time in the gut. He struggles for air as he falls to the ground";
                    dialogueText.Text += "\n\nAfter defeating the bandit, you grab his sword and continue to the cave.";
                    mountainTheme.PlayLooping();
                    if (hasSword == false)
                    {
                        hasSword = true;
                        inventoryLabel.Text += "\n\nx1 Common sword";
                    }
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "Drink potion and continue(W)";
                    break;
                case 16:
                    dialogueText.Text = "You slash him with your sword, cutting his arm clean off. He runs away screaming.";
                    mountainTheme.PlayLooping();
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "Drink potion and continue(W)";
                    break;
                case 17:
                    dialogueText.Text = "Bandit: I want that coin purse of yours....";
                    dialogueText.Text += "\n\nI am afraid its empty.";
                    dialogueText.Text += "\n\nBandit: Well see about that!";
                    option1Label.Text = "Fight him(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 18:
                    dialogueText.Text = "Bandit: You thought you could run from me? I’m going to kill you and take all of your stuff.";
                    option1Label.Text = "Fight him(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 19:
                    dialogueText.Text = "he slashes you back and deals one damage";
                    countdown--;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    option1Label.Text = "hit him back(Q)";
                    break;
                case 20://arrive at cave
                    if (hashealthpotion == true && choosetodrinkPotion == true) 
                    {
                        countdown = countdown + 5;
                        titleLabel.Text = countdown.ToString();
                        titleLabel.Text += " Health";
                        inventoryLabel.Text = "Inventory:";
                        inventoryLabel.Text += "\n\nx1 Common sword";
                        hashealthpotion = false;
                    }
                    dialogueText.Text = "You arrive at the cave. It is night time, Acikore said that it could be dangerous at night";
                    option1Label.Text = "Wait till morning(Q)";
                    option2Label.Text = "Go into the cave(W)";
                    break;
                case 21://enter cave
                    settingPicture.Image = (Properties.Resources.cave);
                    dialogueText.Text = "You enter the cave, There is a sleeping giant with a fang necklace around his neck";
                    option1Label.Text = "Try to be sneaky and take the necklace off(Q)";
                    option2Label.Text = "Stab the giant while he is sleeping and take the necklace(W)";
                    option3Label.Text = "Wake up the giant and ask for the necklace like a civilized person would.(E)";
                    break;
                case 22:
                    countdown = countdown - 3;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    settingPicture.Image = (Properties.Resources.cave);
                    dialogueText.Text = "You enter the cave after waiting till morning, As you enter you see a sleeping giant with a fang necklace around his neck.";
                    option1Label.Text = "Try to be sneaky and take the necklace off(Q)";
                    option2Label.Text = "Stab the giant while he is sleeping and take the necklace(W)";
                    option3Label.Text = "Wake up the giant and ask for the necklace like a civilized person would.(E)";
                    break;
                case 23://giant
                    dialogueText.Text = "The giant wakes up and grabs you, lifting you into the air.";
                    dialogueText.Text += "\n\nGiant: My name is Thudd. I see that you are after my necklace, but little traveler I have a riddle for you and if you correctly answer it you will get the necklace and I won't get to eat tasty human. but if you are wrong, I will use your bones for toothpicks. Smash and mash, thump, thump, thump, crash! What has eight legs, The power to decide the fate of an unweary traveler, whose bite is like venom corroding the flesh, The great queen of darkness whose very appearance would be enough to scare the most courageous of souls. What is the queen of this caverns name?";
                    option1Label.Text = "Argyrodes colubrinus(Q)";
                    option2Label.Text = "Assassin spider(W)";
                    option3Label.Text = "Argyroneta aquatica(E)";
                    option4Label.Text = "Lasiodora(R)";
                    break;
                case 24:
                    dialogueText.Text = "You attempt to stab the giant, but your sword bounces of his hard skin.";
                    dialogueText.Text += "\n\nGiant: My name is Thudd. I see that you are after my necklace, but little traveler I have a riddle for you and if you correctly answer it you will get the necklace and I won't get to eat tasty human. but if you are wrong, I will use your bones for toothpicks. Smash and mash, thump, thump, thump, crash! What has eight legs, The power to decide the fate of an unweary traveler, whose bite is like venom corroding the flesh, The great queen of darkness whose very appearance would be enough to scare the most courageous of souls. What is the queen of this caverns name?";
                    option1Label.Text = "Argyrodes colubrinus(Q)";
                    option2Label.Text = "Assassin spider(W)";
                    option3Label.Text = "Argyroneta aquatica(E)";
                    option4Label.Text = "Lasiodora(R)";
                    break;
                case 25:
                    countdown = countdown - 5;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    dialogueText.Text = "Wrong, Guess again.";
                    option1Label.Text = "Argyrodes colubrinus(Q)";
                    option2Label.Text = "Assassin spider(W)";
                    option3Label.Text = "Argyroneta aquatica(E)";
                    option4Label.Text = "Lasiodora(R)";
                    break;
                case 26://get necklace
                    dialogueText.Text = "Thudd: You beat riddle. Here pretty necklace (Hands necklace to hero). LEAVE!!!, Thudd Sleep now.";
                    inventoryLabel.Text += "\n\nx1 Enchanted Fang";
                    hasFang = true;
                    dialogueText.Text += "\n\nGoodbye Thudd. Now time to go back to Acikore and get him this Fang.";
                    option1Label.Text = "Leave cave for Acikores hut(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 27://crow
                    dialogueText.Text = "After leaving the cave you walk for about 1 minute, when all of a sudden a crow lands on a branch next to you.";
                    settingPicture.Image = (Properties.Resources.crow);
                    dialogueText.Text += "\n\nCrow: Hey, Hey meat bag, come here. Listen to what I have to say.";
                    option1Label.Text = "Swing your sword at the crow.(Q)";
                    option2Label.Text = "Listen to the crow(W)";
                    option3Label.Text = "Keep walking and pretend you didn’t just hear a crow talk like the ignorant snob you are.(E)";
                    break;
                case 28:
                    dialogueText.Text = "Crow: Fine meat bag, I wont tell you what I have to say (crow flies away)";
                    option1Label.Text = "Continue to Acikores hut(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 29:
                    dialogueText.Text = "Crow: Meat bag, all wizards I’ve known only help themselves. wizards are not to be trusted.(crow flies away)";
                    option1Label.Text = "Continue to Acikores hut(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 30:
                    dialogueText.Text = "Crow: Meat bag I know you can hear me.";
                    option1Label.Text = "Keep walking and continue to Acikores hut(Q)";
                    option2Label.Text = "Stop and listen to the crow(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 31://return necklace
                    dialogueText.Text = "Acikore: Hero you have returned with the fang. I had no doubts that you would in your abilities.";
                    settingPicture.Image = (Properties.Resources.mountain_range);
                    dialogueText.Text += "\n\nHello Acikore, Yes I have the fang, but The strangest thing happened to me on my walk back from the cave.";
                    dialogueText.Text += "\n\nAcikore: Yes hero what would that be?";
                    option1Label.Text = "Tell him about the crow(Q)";
                    option2Label.Text = "Tell him you saw a unicorn (lie)(W)";
                    option3Label.Text = "Tell him that it doesnt matter, nevermind(E)";

                    break;
                case 32:
                    dialogueText.Text = "This crow talked to me and told me that he has never met a wizard that was trustworthy.";
                    dialogueText.Text += "\n\nAcikore: A talking crow told you not to trust me? I think maybe the illness is making you hallucinate.";
                    dialogueText.Text += "\n\nAcikore: Anyways Hero you need to now go and get sour milk for the next part of the cure.";
                    dialogueText.Text += "\n\nThat can’t be too hard milk goes bad all the time.";
                    dialogueText.Text += "\n\nAcikore: no you fool, this milk is from a cow that is not very to friendly to anyone and produces the sourest of milk.";
                    dialogueText.Text += "\n\nWell, where can I find this angry cow?";
                    dialogueText.Text += "\n\nAcikore: you will find her in a field near Horgardalsa. She will not let you just milk her you must find a way so that she doesn’t attack you.";
                    dialogueText.Text += "\n\nOkay I’ll be back with sour milk!";
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 33://get next quest
                    dialogueText.Text = "There was a unicorn walking off the trail and I ran after it but it was too fast and ran away from me.";
                    dialogueText.Text = "\n\nAcikore: That’s very interesting. maybe the illness is more serious than I thought and is making you hallucinate.";
                    dialogueText.Text += "\n\nAcikore: Anyways Hero you need to now go and get sour milk for the next part of the cure.";
                    dialogueText.Text += "\n\nThat can’t be too hard milk goes bad all the time.";
                    dialogueText.Text += "\n\nAcikore: no you fool, this milk is from a cow that is not very to friendly to anyone and produces the sourest of milk.";
                    dialogueText.Text += "\n\nWell, where can I find this angry cow?";
                    dialogueText.Text += "\n\nAcikore: you will find her in a field near Horgardalsa. She will not let you just milk her you must find a way so that she doesn’t attack you.";
                    dialogueText.Text += "\n\nOkay I’ll be back with sour milk!";
                    option1Label.Text = "Continue (Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 34:
                    dialogueText.Text = "Acikore: you’re wasting my time.";
                    dialogueText.Text += "\n\nAcikore: Anyways Hero you need to now go and get sour milk for the next part of the cure.";
                    dialogueText.Text += "\n\nThat can’t be too hard milk goes bad all the time.";
                    dialogueText.Text += "\n\nAcikore: no you fool, this milk is from a cow that is not very to friendly to anyone and produces the sourest of milk.";
                    dialogueText.Text += "\n\nWell, where can I find this angry cow?";
                    dialogueText.Text += "\n\nAcikore: you will find her in a field near Horgardalsa. She will not let you just milk her you must find a way so that she doesn’t attack you.";
                    dialogueText.Text += "\n\nOkay I’ll be back with sour milk!";
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 35:
                    dialogueText.Text = "Acikore: Anyways Hero you need to now go and get sour milk for the next part of the cure.";
                    dialogueText.Text += "\n\nThat can’t be too hard milk goes bad all the time.";
                    dialogueText.Text += "\n\nAcikore: no you fool, this milk is from a cow that is not very to friendly to anyone and produces the sourest of milk.";
                    dialogueText.Text += "\n\nWell, where can I find this angry cow?";
                    dialogueText.Text += "\n\nAcikore: you will find her in a field near Horgardalsa. She will not let you just milk her you must find a way so that she doesn’t attack you.";
                    dialogueText.Text += "\n\nOkay I’ll be back with sour milk!";
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 36://leave for sour milk
                    mainTheme.PlayLooping();
                    settingPicture.Image = (Properties.Resources.forest);
                    dialogueText.Text = "You walk for a bit and see a cave to the side of the road";
                    option1Label.Text = "Go in the cave(Q)";
                    option2Label.Text = "Continue walking(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 37:
                    dialogueText.Text = "You enter the cave, and a huge swarm of Fanged Cave Bats fly out of the darkness, you can hear the sound of a fire and laughing.";
                    option1Label.Text = "Continue towards sound(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 38:
                    dialogueText.Text = "You continue on the path passing the cave. You begin to see a settling in the distance";
                    if (hashealthpotion == true && choosetodrinkPotion == true)
                    {
                        countdown = countdown + 5;
                        titleLabel.Text = countdown.ToString();
                        inventoryLabel.Text = "Inventory:";
                        inventoryLabel.Text += "\n\nx1 Common sword";
                        inventoryLabel.Text += "\n\nx1 Enchanted fang";
                        titleLabel.Text += " Health";
                        hashealthpotion = false;
                    }
                    
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 39://to do add logic for combat
                    dialogueText.Text = "As you approach it becomes obvious that the sound is from a cave goblin. It sees you and charges at you with its club";
                    battleTheme.PlayLooping();
                    option1Label.Text = "Slash him with your sword(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 40:
                    countdown--;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    dialogueText.Text = "The goblin hits you back";
                    option1Label.Text = "Slash again(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 41:
                    dialogueText.Text = "You slash the goblin, chopping his head clean off";
                    mainTheme.PlayLooping();
                    option1Label.Text = "Leave cave(Q)";
                    option2Label.Text = "Drink potion and leave cave(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                //ask around the town for info
                case 42:
                    settingPicture.Image = (Properties.Resources.village);
                    dialogueText.Text = "You get closer to the settlement and see this huge pasture filled with cows of all types. They are all lazily eating the grass.";
                    dialogueText.Text += "\n\nAs you arrive at the settlement you see a marketplace filled with people";
                    dialogueText.Text += "\n\nI could ask some people if they know if a angry cow that lives in the pasture. Who do I ask?";
                    option1Label.Text = "A priest(Q)";
                    option2Label.Text = "A store clerk working at the market(W)";
                    option3Label.Text = "A vagabond standing in the shadows(E)";
                    option4Label.Text = "An old lady(R)";
                    break;

                case 43://ask priest
                    dialogueText.Text = "Priest: Hello my son. Have you come to find your place serving Gwyn? this is the right place.";
                    dialogueText.Text += "\n\nNo I'm sorry, I came to ask you if you knew about an angry cow that produces sour milk.";
                    dialogueText.Text += "\n\nPriest: no my son every creature of the saviour is kind";
                    option1Label.Text = "Ask someone else(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 44://ask clerk
                    dialogueText.Text = "Do you know where I can find an angry cow?";
                    dialogueText.Text += "\n\nStore clerk: I only talk business please leave your driving my customers away.";
                    option1Label.Text = "Ask someone else(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 45://ask vagabond
                    dialogueText.Text = "Do you know where an angry cow is?";
                    dialogueText.Text += "\n\nVagabond: Yes come with me she lives out by this huge tree where the best shade is! come follow me!";
                    option1Label.Text = "Follow him(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 46://ask old lady
                    dialogueText.Text = "Hello old lady, have you seen an angry cow that produces sourest milk?";
                    dialogueText.Text += "\n\nOld lady: An angry cow? why would I know where an angry cow is? I haven't seen a cow with my eyes for years!";
                    option1Label.Text = "Ask someone else(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 47://follow vagabond
                    dialogueText.Text = "You follow the Vagabond to a pasture. you see this huge cow that is sleeping in the shadow of a tree.";
                    option1Label.Text = "Examine the cow.(Q)";
                    option2Label.Text = "Tip the cow on it’s side and milk it as fast as you can.(W)";
                    option3Label.Text = "Tell the vagabond to hold down the cow’s head while you milk the cow.(E)";

                    break;

                case 48:
                    dialogueText.Text = "You see that there is a sharp stick in the side of the cow.";
                    option1Label.Text = "Shove it further into the cow’s side.(Q)";
                    option2Label.Text = "Tell the cow in a gentle voice you are here to help and to remove the stick.(W)";
                    option3Label.Text = "Rip the stick outta the cow’s side.(E)";
                    option4Label.Text = "";
                    break;

                case 49:
                    dialogueText.Text = "The cow is stronger than you thought. It runs and turns around. It starts coming at you with it’s point at you.";
                    option1Label.Text = "Jump out of the way and calm it down(Q)";
                    option2Label.Text = "Slice cows head off(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 50:
                    dialogueText.Text = "The cow wakes up and stabs the vagabond in the gut with its horns. then runs away.";
                    dialogueText.Text += "\n\nVagabond: Saviour you’ve forsaken me. (dies)";
                    dialogueText.Text += "\n\nAcikore: you’ve failed (you get warped back in time)";
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 51:
                    dialogueText.Text = "The cow cries and then falls silent. you try to milk the now dead cow and nothing comes out.";
                    dialogueText.Text += "\n\nAcikore: you’ve failed (you get warped back in time)";
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 52:
                    dialogueText.Text = "The cow stays still and you gently take it out.";
                    dialogueText.Text += "\n\nCow: Thank you stranger you’ve helped me out greatly. Your reward for helping me is a bottle of my sourest milk.";
                    option1Label.Text = "Milk cow(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 53:
                    dialogueText.Text = "Cow: Ouch that hurt. but you still helped me so I guess i’ll help you and give you my milk.";
                    option1Label.Text = "Milk cow(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 54://milk cow
                    dialogueText.Text = "The cow lets you take milk from it";
                    inventoryLabel.Text += "\n\nx1 Sour milk";
                    hasMilk = true;
                    dialogueText.Text += "\n\nWe have the milk!! thank you vagabond you’ve helped me with my journey.";
                    dialogueText.Text += "\n\nVagabond: well I guess you don’t need me anymore.";
                    option1Label.Text = "Invite him to come with you(Q)";
                    option2Label.Text = "Leave him(W)";
                    option3Label.Text = "Threaten him(E)";
                    option4Label.Text = "";
                    break;

                case 55:
                    dialogueText.Text = "Would you like to come with me?";
                    dialogueText.Text += "\n\nVagabond: of course I’ll come with you.";
                    vagabondinparty = true;
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 56:
                    dialogueText.Text = "Okay well thanks for the help, have a nice life!";
                    dialogueText.Text += "\n\nVagabond: Okay I will!";
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 57:
                    dialogueText.Text = "Get out of here you loser before I murder you!";
                    dialogueText.Text = "\n\nVagabond: Fine i'll leave but you don’t have to be so rude.";
                    option1Label.Text = "Continue(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 58://return with sour milk
                    mountainTheme.PlayLooping();
                    settingPicture.Image = (Properties.Resources.mountain_range);
                    if (vagabondinparty == true)
                    {
                        dialogueText.Text = "Acikore we have returned with the sourmilk!";
                        dialogueText.Text += "\nAcikore: That’s good to hear boy. now for the last and most important piece of the cure;Therian extract. You’ll find therian plants in the desert of Seeth. bring the whole plant intact or the extract will be useless";
                        dialogueText.Text += "\nhow do you want us to get it here then?";
                        dialogueText.Text += "Acikore: that’s for you to figure out not me.";
                    }
                    else
                    {
                        dialogueText.Text = "Acikore I have returned with the sourmilk!";
                        dialogueText.Text += "\nAcikore: That’s good to hear boy. now for the last and most important piece of the cure;Therian extract. You’ll find therian plants in the desert of Seeth. bring the whole plant intact or the extract will be useless";
                        dialogueText.Text += "\nhow do you want me to get it here then?";
                        dialogueText.Text += "Acikore: that’s for you to figure out not me.";
                    }
                    option1Label.Text = "Continue to the desert of Seeth(Q)";
                    break;

                case 59://continue to desert
                    desertTheme.PlayLooping();
                    settingPicture.Image = (Properties.Resources.desert);
                    if (vagabondinparty)
                    {
                        dialogueText.Text = "This heat is insane! we need to find this plant before a storm comes.";
                        dialogueText.Text += "\nCrow: Listen to me. There is a storm coming your way. If you want to this plant you are going to need my help!";
                        option1Label.Text = "Why would you help us?(Q)";
                        option2Label.Text = "YES please help us!(W)";
                        option3Label.Text = "I don’t need help from a stupid crow. I got my vagabond to help.(E)";
                    }
                    else
                    {
                        dialogueText.Text = "This heat is insane! I need to find this plant before a storm comes.";
                        dialogueText.Text += "\nCrow: Listen to me. There is a storm coming your way. If you want to this plant you are going to need my help!";
                        option1Label.Text = "Why would you help me?(Q)";
                        option2Label.Text = "YES please help me!(W)";
                        option3Label.Text = "I don’t need help from a stupid crow.(E)";
                    }
                    break;

                case 60://ask crow why
                    dialogueText.Text = "Crow: I don’t want to see you struggle.";
                    option1Label.Text = "Let him help(Q)";
                    option2Label.Text = "Say no(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 61://ask crow to help
                    dialogueText.Text = "Crow: Alright I’ll get it for you just wait here.";
                    option1Label.Text = "Wait(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 62://refuse help
                    dialogueText.Text = "Crow: Fine I’ll just fly around and take all of the plants for myself.";
                    option1Label.Text = "Search for the plant yourself(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                case 63:
                    dialogueText.Text = "The crow comes back with a Therian plants.";
                    inventoryLabel.Text += "\n\nx1 Therian Plant";
                    hasExtract = true;
                    dialogueText.Text += "\nCrow: now that I helped you can you help me?";
                    option1Label.Text = "I need to get this back to Acikore, I don’t have time to help.(Q)";
                    option2Label.Text = "yeah I’ll help you. what do you need help with?(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 64:
                    if (vagabondinparty == true)
                    {
                        dialogueText.Text = "you and the vagabond split up to find the plant. a sand storm comes and you must wait five minutes.";
                    }
                    else
                    {
                        dialogueText.Text = "you go to find the plant. a sand storm comes and you must wait five minutes.";
                    }                       
                    countdown = countdown - 5;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    inventoryLabel.Text += "\n\nx1 Therian Plant";
                    dialogueText.Text += "\nCrow: now that you have it can you help me?";
                    option1Label.Text = "I need to get his back to Acikore, I don’t have time to help.(Q)";
                    option2Label.Text = "Yeah I’ll help you. what do you need help with?(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 65:
                    dialogueText.Text = "Crow: Fine I’m taking my plants back.";
                    dialogueText.Text += "\nFine! I'll help, if you gotta be that way";
                    option1Label.Text = "Help(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 66:
                    dialogueText.Text = "Crow: Good. when you get back to the wizard after he is done making the cure kill him.";
                    option1Label.Text = "Alright(Q)";
                    option2Label.Text = "I don’t know if i can do that(W)";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 67:
                    dialogueText.Text = "Crow: Good. when you get back to the wizard after he is done making the cure kill him.";
                    option1Label.Text = "Go to Acikore's hut(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 68:
                    dialogueText.Text = "Crow: Fine, your loss.";
                    option1Label.Text = "Go to Acikore's hut(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 69://bring all stuff to acikore
                    settingPicture.Image = (Properties.Resources.mountain_range);
                    mountainTheme.PlayLooping();
                    dialogueText.Text = "Acikore I have come back with the last part of the cure. Will you please make me this cure?";
                    dialogueText.Text += "\nAcikore: Since you asked nicely. It will only take a moment.";
                    inventoryLabel.Text = "Inventory";
                    inventoryLabel.Text += "\n\nx1 Common sword";
                    if (hashealthpotion == true) 
                    {
                        inventoryLabel.Text += "\n\nx1Basic health potion";
                    }
                    inventoryLabel.Text += "\n\nx1Cure";
                    tilldeathTimer.Stop();
                    option1Label.Text = "Kill Acikore(Q)";
                    option2Label.Text = "Hug him and leave(W)";
                    option3Label.Text = "Lock his doors and start a fire.(E)";
                    option4Label.Text = "";
                    break;

                case 70:
                    dialogueText.Text = "You stab Acikore with your sword.";
                    dialogueText.Text += "\nAcikore: why?";
                    dialogueText.Text += "\nyou walk to your village and see that there are bodies everywhere. the disease that you were fighting spread throughout your village and killed everyone.";
                    settingPicture.Image = (Properties.Resources.foggy_marsh);
                    sadTheme.PlayLooping();
                    option1Label.Text = "End(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 71:
                    dialogueText.Text = "you hug him and then walk home. you see in the sky a huge dragon approach your village. One big breath of fire sets all the huts up in flames Screams boom through the air. You drop to your knees and cry. Everyone you love is dead.";
                    settingPicture.Image = (Properties.Resources.foggy_marsh);
                    sadTheme.PlayLooping();
                    option1Label.Text = "End(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;

                case 72:
                    dialogueText.Text = "You lock his doors and throw a flaming stick on a pile of hay. You hear screaming then a big pop. the roof shatters to bits. \nA dragon hurdles through the air and comes back and lands in front of you. \nAcikore: Who do you think you are trying to kill me. It’s time to die.";
                    settingPicture.Image = (Properties.Resources.burning__hut);
                    sadTheme.PlayLooping();
                    option1Label.Text = "Fight him(Q)";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option4Label.Text = "";
                    break;
                    
                case 73:
                    settingPicture.Image = (Properties.Resources.dragon);
                    bossTheme.PlayLooping();
                    dialogueText.Text = "The dragon breaths fire";
                    countdown = countdown - 5;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    option1Label.Text = "Strike it with your sword(Q)";
                    break;

                case 74:
                    dialogueText.Text = "You strike the dragon with your sword, but it bounces back. More fire rains down.";
                    countdown = countdown - 5;
                    titleLabel.Text = countdown.ToString();
                    titleLabel.Text += " Health";
                    option1Label.Text = "Swing again!(Q)";
                    break;

                case 75:
                    dialogueText.Text = "You swing your sword with might! it plunges into the dragons skull.";
                    option1Label.Text = "End(Q)";
                    break;
                default:
                    break;
            }
        }

        private void tilldeathTimer_Tick(object sender, EventArgs e)//countdown till death
        {
            countdown--;
            titleLabel.Text = countdown.ToString();
            titleLabel.Text += " Health";
        }
        /// Starts credits
        /// 
        /// 
        public void Credits()
        {
            creditTheme.Play();
            logopicBox.Visible = true;
            creditLabel.Visible = true;
            dialogueText.BackColor = Color.Black;
            creditLabel.Text = "A game by Dream team Inc.";
            
            Refresh();
            creditLabel.Text = "Lead programmer: Daniel Clarke";
            Thread.Sleep(5000);
            Refresh();
            creditLabel.Text = "Script: Jesse Graves and Dylan Sherwood";
            Thread.Sleep(5000);
            Refresh();
            creditLabel.Text = "Music provided by Free Play music";
            Thread.Sleep(5000);
            Refresh();
            creditLabel.Text = "Images provided by Pixabay";
            Thread.Sleep(5000);
            Refresh();
            creditLabel.Text = "End.";
            Thread.Sleep(5000);
            Refresh();
            Thread.Sleep(12500);
            this.Close();
        }
    }
}

