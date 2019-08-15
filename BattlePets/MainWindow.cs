using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattlePets
{
    public partial class MainWindow : Form
    {

        public delegate void WorkProgressHandler();
        public event WorkProgressHandler WorkProgress;
        public BattlePet pet;
        public BattlePet wildPet1;
        public BattlePet wildPet2;
        public BattlePet wildPet3;
        public int maxcounter, counter;
        int healtime = 299;             //healtime interval is 300 seconds, or 5 minutes
        int spawntime = 9;              //spawntime interval is 10 seconds
        public List<BattlePet> currentplayers = new List<BattlePet>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnableDoubleBuffer(Panel panel1)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pet = new BattlePet();                                      //instance of new BattlPet on the screen to represent the player
            pet.affiliated = true;                                      //pet is part of a team, so the affiliated property is set to true
            pet.Crash += new EventHandler(CrashHandler);                //wiring of the crash handler
            lblPet.Image = BattlePets.Properties.Resources.trainerSouth;
            this.KeyPreview = true;
            menuStrip1.BackColor = Color.SteelBlue;
            petTeamButton.BackColor = Color.SteelBlue;
            currentplayers.Add(pet);
            instructionMsg();
        }

        private void CrashHandler(object sender, EventArgs e)
        {
            MessageBox.Show("You don't wanna go over there!");
        }

        public void generateRandPet()           //spawn a random enemy
        {
            int maxXPos = 200;      //size of the grid X
            int maxYPos = 200;      //size of the grid Y
            Random random = new Random();   //new random variable for the position of the new pet
            int X = random.Next(15, maxXPos);//set random number for X value
            int Y = random.Next(45, maxYPos);//set random number for Y value
            Point p = new Point(X, Y);      //create a new point according to values
            if (!isOccupied(p))     //if the point is not occupied by a BattlePet already
            {
                if (lblwildPet1.Visible == false)   //if the first wild pet is not visible (not yet spawned)
                {
                    BattlePet wildPet1 = new BattlePet(X, Y);
                    MovePetToLocation(p, wildPet1, lblwildPet1);
                    wildPet1.affiliated = false;
                    wildPet1.wildpetlabel = 1;
                    wildPet1.starter = false;
                    lblwildPet1.Visible = true;
                    currentplayers.Add(wildPet1);
                }
                else if (lblwildPet2.Visible == false)  //if the second wild pet is not visible (not yet spawned)
                {
                    BattlePet wildPet2 = new BattlePet(X, Y);
                    MovePetToLocation(p, wildPet2, lblwildPet2);
                    wildPet2.affiliated = false;
                    wildPet2.wildpetlabel = 2;
                    wildPet2.starter = false;
                    lblwildPet2.Visible = true;
                    currentplayers.Add(wildPet2);
                }
                else if (lblwildPet3.Visible == false) //if the third wild pet is not visible (not yet spawned)
                {
                    BattlePet wildPet3 = new BattlePet(X, Y);
                    MovePetToLocation(p, wildPet3, lblwildPet3);
                    wildPet3.affiliated = false;
                    wildPet3.wildpetlabel = 3;
                    wildPet3.starter = false;
                    lblwildPet3.Visible = true;
                    currentplayers.Add(wildPet3);
                }               
            }
            else
            {
                generateRandPet();  //else, begin program over again to generate a new point
            }

        }
        
        public bool isOccupied(Point p)     //check if the square is already occupied by another BattlePet
        {
            bool occupied = false;          //default that the square is empty
            foreach(BattlePet doggo in currentplayers)  //loop through all players on the screen
            {
                if (doggo.Position.Equals(p))           //compare positions of each
                {
                    occupied = true;                    //if the positions are the same, change the property to true
                }
            }
            return occupied;                            //return value
        }

        private void MovePet(int units)     //move the main pet by a number of pixels
        {
            pet.Go(units);
            Point rp = pet.Position;
            lblPet.Location = new Point(rp.X + 100, -rp.Y + 100); //adjust for panel pixels
        }

        private void MovePetToLocation(Point p, BattlePet doggo, Label lbl) //move a wild pet to a particular position and label
        {
            doggo.set_Position(p.X, p.Y);   //set the battlepet position according to point
            lbl.Location = p;               //change the location of the label according to point
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)  //event triggered when a key is pressed
        {
            e.Handled = true;
            if (e.KeyCode == Keys.W)        //when the W button is pressed, move up
            {
                pet.Direction = BattlePet.Directions.N;
                lblPet.Image = BattlePets.Properties.Resources.trainerNorth;
                this.MovePet(5);
                int t = battleAvailable(pet);
            }
            if (e.KeyCode == Keys.S)        //when the S button is pressed, move down
            {
                pet.Direction = BattlePet.Directions.S;
                lblPet.Image = BattlePets.Properties.Resources.trainerSouth;
                this.MovePet(5);
                int t = battleAvailable(pet);
            }
            if (e.KeyCode == Keys.A)        //when the A button is pressed, move left
            {
                pet.Direction = BattlePet.Directions.W;
                lblPet.Image = BattlePets.Properties.Resources.trainerWest;
                this.MovePet(5);
                int t = battleAvailable(pet);
            }
            if (e.KeyCode == Keys.D)        //when the D button is pressed, move right
            {
                pet.Direction = BattlePet.Directions.E;
                lblPet.Image = BattlePets.Properties.Resources.trainerEast;
                this.MovePet(5);
                int t = battleAvailable(pet);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)  //Exit button clicked
        {
            var result = MessageBox.Show("Are you sure you want to exit Battle Pets?", "Prompt", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnS_Click(object sender, EventArgs e)     //Down button clicked
        {

            pet.Direction = BattlePet.Directions.S;
            lblPet.Image = BattlePets.Properties.Resources.trainerSouth;
            this.MovePet(5);
            int t = battleAvailable(pet);
        }

        private void btnN_Click(object sender, EventArgs e)     //Up button clicked
        {
            pet.Direction = BattlePet.Directions.N;
            lblPet.Image = BattlePets.Properties.Resources.trainerNorth;
            this.MovePet(5);
            int t = battleAvailable(pet);
        }

        private void btnE_Click(object sender, EventArgs e)     //Right button clicked
        {
            pet.Direction = BattlePet.Directions.E;
            lblPet.Image = BattlePets.Properties.Resources.trainerEast;
            this.MovePet(5);
            int t = battleAvailable(pet);
        }

        private void btnW_Click(object sender, EventArgs e)     //Left button clicked
        {
            pet.Direction = BattlePet.Directions.W;
            lblPet.Image = BattlePets.Properties.Resources.trainerWest;
            this.MovePet(5);
            int t = battleAvailable(pet);
        }
        private void petJournalToolStripMenuItem1_Click(object sender, EventArgs e) //user selects the "Pet Journal" section in the dropdown menu
        {
            PetJournal journal = new PetJournal();  //create a new PetJournal instance
            journal.ShowDialog(this);               //launch new PetJournal instance
        }

        private void petInfoToolStripMenuItem_Click(object sender, EventArgs e) //user selects the "Pet Info" section in the dropdown menu
        {
            PetInfo info = new PetInfo();           //create a new PetInfo instance
            info.ShowDialog(this);                  //launch new PetInfo instance
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)   //user selects the "About" section in the dropdown menu
        {
            //display game information in a basic messagebox
            instructionMsg();
        }
        void instructionMsg()
        {
            string msgstring = "\t\tWelcome, young warrior, to Battle Pets!\n\n"    //string of game information to display to the user
               + "To explore the world around you, use the arrow keys at the bottom left of the screen. You may also use the WASD buttons on your keyboard.\n\n"
               + "When you are standing next to a Battle Pet, launch a battle by clicking on the battle button in the bottom right. To heal, click on the heal button to the left of it.\n\n"
               + "Select the 'File' dropdown menu to view basic game options, and select the 'View' dropdown menu to review information on your team.\n\n"
               + "You may take 3 Battle Pets into battle and each Pet has 3 abilities.\n\n"
               + "And a word to the wise...It's dangerous to go alone. So we have given you a Clockwork Gnome!";
            MessageBox.Show(msgstring, "About | Battle Pets");
        }

        private void timer1_Tick(object sender, EventArgs e)    //5-minute timer for healing button, tick event
        {
            pbHealTimer.Value = healtime;                       //set progressbar value to toal heal time
            string healtimeText = Convert.ToString(healtime);
            lblhealtime.Text = healtimeText + " seconds remaining"; //update healtime text to let user know the amount of time left
            pbHealTimer.Text = healtimeText;
            if (healtime > 0)                           //if there is still time left for healing,
            {
                healtime -= 1;                              //decrement the time left by 1 second
            }
            else                                        //else there is no time left for healing
            {
                timerHeal.Stop();                           //stop the heal timer
                btnHeal.Enabled = true;                     //re-enable the Heal button
                healtime = 299;                             //reset healtime to 300 seconds, or 5 minutes
                lblhealtime.Text = "";                      //clear healtime text label
            }
                        
        }

        private void btnHeal_Click(object sender, EventArgs e)  //user clicks Heal button to Heal pet
        {
            if (btnHeal.Enabled)            //as long as the heal button is enabled,
            {
                timerHeal.Enabled = true;   
                timerHeal.Start();          //start the 5-minute countdown timer
                btnHeal.Enabled = false;    //disable the Heal button until the 5 minutes are up
            }
        }

        private int battleAvailable(BattlePet trainer)         //check for the proximity of wild pets for battle availability
        {
            int j = 0;
            bool available = false;     //boolean placeholder to store the value
            Point rp = new Point(trainer.Position.X + 100, -trainer.Position.Y + 100);  //convert the trainer location to a normal point on the form
            for (int i = 1; i < currentplayers.Count; i++)      //loop through current pets on the field, starting with the first wild pet (currentplayers[0] is the main character)
            {
                BattlePet potential = currentplayers[i];        //empty BattlePet object at index i
                int Xdistance = Math.Abs(Math.Abs(potential.Position.X) - Math.Abs(rp.X));  //difference between X values
                int Ydistance = Math.Abs(Math.Abs(potential.Position.Y) - Math.Abs(rp.Y));  //difference between Y values
                if(Xdistance <= 22 && Ydistance <= 22)          //if the distance between the points is less than 22,
                {
                    available = true;
                    btnBattle.Enabled = true;                   //enable the battle button to allow player to launch battle with pet
                    pet.can_move = false;
                    return i;                                   //return the index of the currentplayers
                }
            }
            if(available == false)                              //if there are no battles available,
            {
                j = 0;
                btnBattle.Enabled = false;                      //disable the battle button, player not allowed to launch battle with pet
            }
            return j;                                   //return placeholder value 
        }

        private void pbHealTimer_Click(object sender, EventArgs e)
        {

        }

        private void timerSpawn_Tick(object sender, EventArgs e)    //timer that controls enemy spawn, tick event
        {
            if (spawntime > 0)
            {
                spawntime -= 1;     //decrement the 10 second timer
            }
            else
            {
                generateRandPet();  //generate an enemy
                spawntime = 9;      //reset the 10 second timer
            }
        }

        private void btnBattle_EnabledChanged(object sender, EventArgs e)  //change the battle button image according to active/inactive
        {
            if (btnBattle.Enabled)
            {
                btnBattle.BackgroundImage = BattlePets.Properties.Resources.inv_pet_battlepettraining;

            }
            if (!btnBattle.Enabled)
            {
                btnBattle.BackgroundImage = BattlePets.Properties.Resources.inv_pet_battlepettraining_greyscale;
            }
        }

        private void btnHeal_EnabledChanged(object sender, EventArgs e) //change the heal button image according to active/inactive
        {
            if (btnHeal.Enabled)
            {
                btnHeal.BackgroundImage = BattlePets.Properties.Resources.revive_battle_pets;

            }
            if(!btnHeal.Enabled)
            {
                btnHeal.BackgroundImage = BattlePets.Properties.Resources.revive_battle_pets_greyscale;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)   //Exit dropdown option selected
        {
            var result = MessageBox.Show("Are you sure you want to exit Battle Pets?", "Prompt", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void combatLogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CombatLog log = new CombatLog();
            log.ShowDialog(this);
        }

        private void petTeamButton_Click(object sender, EventArgs e)
        {
            PetTeam pt = new PetTeam();
            pt.ShowDialog(this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBattle_Click(object sender, EventArgs e)    //when the battle button is clicked
        {
            timerSpawn.Stop();
            BattlePet enemy;                        //create enemy placeholder
            int i = battleAvailable(pet);           //find index of the pet that can be battled
            if(i != 0)                              //as long as the pet is not 0, i.e. you're not trying to battle yourself
            {
                enemy = currentplayers[i];          //assign pet that can be battled to the enemy placeholder
                pet.can_move = true;                //allow the player to move now since the battle is launched
                switch(enemy.wildpetlabel)          //Switch based on whether the player is interacting with wild pet label 1, 2, or 3
                {
                    case 1:                             //if it's linked to pet label #1
                        lblwildPet1.Visible = false;        //set the label to invisible so it will spawn another
                        break;
                    case 2:                             //if it's linked to pet label #2
                        lblwildPet2.Visible = false;        //set the label to invisible so it will spawn another
                        break;
                    case 3:                             //if it's linked to pet label #3
                        lblwildPet3.Visible = false;        //set the label to invisible so it will spawn another
                        break;
                }
                BattleScreen battle = new BattleScreen(enemy, pet);   //create new BattleScreen instance
                battle.ShowDialog(this);                    //launch new BattleScreen

                currentplayers.RemoveAt(i);                 //get rid of this pet from the list of current players
            }

        }



    }
}
