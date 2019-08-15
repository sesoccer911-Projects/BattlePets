using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace BattlePets
{
    public partial class BattleScreen : Form
    {
        public BattleScreen()
        {
            InitializeComponent();
        }

        public BattleScreen(BattlePet enemyPet, BattlePet playerPet)
        {
            InitializeComponent();
            this.enemy = enemyPet;
            this.player = playerPet;
        }
        private string _cnDB = BattlePets.Properties.Settings.Default.F2T5ConnectionString;

        private BattlePet enemy;                //enemy battlepet
        private BattlePet player;               //main character battlepet
        private BattleState currentState;       //current stage of the battle
        private WEATHER currentWeather;         //current weather conditions of battle
        int timeLeft = 30;                      //30 second timer for moves
        bool moveSelected = false;              //boolean to track whether or not a move was selected
        private bool hasAddedXP = false;        //boolean to check for necessary XP adjustments
        private BattleStateScript battleStateSstartScript = new BattleStateScript();

        private void BattleScreen_Load(object sender, EventArgs e)  //load data from f2T5DataSet    
        {
            // TODO: This line of code loads data into the 'f2T5DataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.f2T5DataSet.Type);
            // TODO: This line of code loads data into the 'f2T5DataSet.Pet' table. You can move, or remove it, as needed.
            //this.petTableAdapter.Fill(this.f2T5DataSet.Pet);
            DialogResult dialogResult = MessageBox.Show("ARE YOU READY?!", "A NEW CHALLENGER APPROACHES!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("TOO BAD!", "TIME TO FIGHT!", MessageBoxButtons.OK);
            }
            player = battleStateSstartScript.CreateNew(player, 25, false);

            about();
            update();

        }

        private void BattleScreen_leave(object sender, EventArgs e) //pause timer when BattleScreen loses focus 
        {
            tmrBattle.Stop();
        }

        public enum WEATHER                                         //public enumeration for weather options    
        {
            FOREST,
            ARCANESTORM,
            BLIZZARD,
            DARKNESS,
            LIGHTNINGSTORM,
            MOONLIGHT,
            MUDSLIDE,
            CLEANSINGRAIN,
            SANDSTORM,
            SCORCHEDEARTH,
            SUNNYDAY
        }

        public enum BattleState                                     //public enumeration for battle states  
        {
            START,
            PLAYERCHOICE,
            ENEMYCHOICE,
            CALCDAMAGE,
            ADDSTATUSEFFECTS,
            LOSE,
            WIN              
        }

        void Start()                                                //enable all buttons    
        {
            btnAbility1.Enabled = true;
            btnAbility2.Enabled = true;
            btnAbility3.Enabled = true;
            if(enemy.isCapturable())
            {
                btnCapture.Enabled = true;
            }
            else if(!enemy.isCapturable())
            {
                btnCapture.Enabled = false;
            }
            btnPet1.Enabled = true;
            btnPet2.Enabled = true;
            btnPet3.Enabled = true;
            btnSwap.Enabled = true;
            BtnRun.Enabled = true;
            btnSubmit.Enabled = true;
            btnPass.Enabled = true;
            timeLeft = 30;
            hasAddedXP = false;
            moveSelected = false;
            
            if (player.ability1slot1.prime == "true")
            {
                btnAbility1.Image = LoadAbilityImage(player.ability1slot1.abilityID);
            }
            else
            {
                btnAbility1.Image = LoadAbilityImage(player.ability1slot2.abilityID);
            }
            if (player.ability2slot1.prime == "true")
            {
                btnAbility1.Image = LoadAbilityImage(player.ability2slot1.abilityID);
            }
            else
            {
                btnAbility1.Image = LoadAbilityImage(player.ability2slot2.abilityID);
            }
            if (player.ability3slot1.prime == "true")
            {
                btnAbility1.Image = LoadAbilityImage(player.ability3slot1.abilityID);
            }
            else
            {
                btnAbility1.Image = LoadAbilityImage(player.ability3slot2.abilityID);
            }

        }

        void Stop()                                                 //disable all buttons   
        {
            btnAbility1.Enabled = false;
            btnAbility2.Enabled = false;
            btnAbility3.Enabled = false;
            btnCapture.Enabled = false;
            btnPet1.Enabled = false;
            btnPet2.Enabled = false;
            btnPet3.Enabled = false;
            btnSwap.Enabled = false;
            BtnRun.Enabled = false;
            btnSubmit.Enabled = false;
            btnPass.Enabled = false;
        }

        void Lose()
        {



        }

        void Win()
        {
            if (!hasAddedXP)
                //IncreaseExperience.AddExperience();
                hasAddedXP = true;
        }

        void update()
        {
            switch(currentState)
            {
                case (BattleState.START):
                    this.currentState = battleStateSstartScript.prepareBattle(player);  // creates a new enemy and returns the next battlestate (player or enemy choice) based on who goes first which is based on speed
                    moveSelected = false;
                    break;
                case (BattleState.PLAYERCHOICE):
                    Start();                                                            //enables all button options for player choice
                    break;
                case (BattleState.ENEMYCHOICE):
                    Stop();                                                             //disables all button options for enemy choice
                    Effect enemyeffect = battleStateSstartScript.enemyMove(enemy);      //selects an ability at random for the enemy to make and returns the effect of that ability
                    break;
                case (BattleState.CALCDAMAGE):                                          //calculate damage done by current pet then looks for status effects that modify damage then add that damage

                    break;

                case (BattleState.ADDSTATUSEFFECTS):                                    //try to add status effects if it exists

                    break;

                case (BattleState.LOSE):

                    Lose();
                    break;

                case (BattleState.WIN):

                    Win();
                    break;
            }
        }

        public void foo()       //method that holds weather background options 
        {
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.forest;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.ArcaneStorm;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.Blizzard;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.ArcaneStorm;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.Darkness;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.LightningStorm;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.Moonlight;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.CleansingRain;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.sandstorm;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.ScorchedEarth;
            grpbxWeather.BackgroundImage = this.BackgroundImage = Properties.Resources.SunnyDay;
        }

        public void about()
        {
            string msgstring = "This is the BattleScreen, where you test your might against other pets!\n\n"    // string of game information to display to the user
               + "Initiative (who goes first) is determined based on the speed of each team's primary pet.\n\n"
               + "Each player has 30 seconds maximum to select a move. You may choose to attack the enemy by clicking 1 of the 3 abilities of your primary pet, then clicking submit. "
               + "You may make a different pet your primary by clicking on swap and then clicking on the pet you would like."
               + " You may also choose to skip your turn by selecting the corresponding button and submit, or forfeit the game by clicking run away and then submit.\n\n"
               + " When your enemy is weakened below 35% max health, you may capture it by clicking the capture button, which will add it to your team and end the game. "
               + "Your BattlePets will recover 50% damage at the conclusion of each game.";
            MessageBox.Show(msgstring, "About | How to Battle");
        }


        private void btnPass_Click(object sender, EventArgs e)      //player selects "pass"
        {
            currentState = BattleState.ENEMYCHOICE;         //pass turn, now the current battle state is enemy choice
        }

        private void BtnRun_Click(object sender, EventArgs e)       //player selects "run"
        {
            currentState = BattleState.LOSE;                //run from the battle, now the current battle state is a loss
        }

        private void btnSubmit_Click(object sender, EventArgs e)    //player selects "submit" button
        {
            if (moveSelected==true && currentState==BattleState.PLAYERCHOICE)   //as long as the player selected a move and it's their turn,
            {
                currentState = BattleState.ENEMYCHOICE;                         //change current battle state to enemy choice
            }
            else
            {

            }
        }

        public void tmrBattle_Tick(object sender, EventArgs e)      //
        {
            lblTimer.Text = timeLeft.ToString();
            
            pbTimer.Value = timeLeft;
            pbHealth1.Value = 100;
            pbHealth2.Value = 100;
            pbPet1HP.Value = 100;
            pbPet2HP.Value = 100;
            pbPet3HP.Value = 100;
            pbPet4HP.Value = 100;

            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft--;
                lblTimer.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                tmrBattle.Stop();
                lblTimer.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                currentState = BattleState.ENEMYCHOICE;
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            moveSelected = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            moveSelected = true;
        }

        private void btnAbility1_Click(object sender, EventArgs e)
        {

            moveSelected = true;
        }

        private void btnAbility2_Click(object sender, EventArgs e)
        {
            moveSelected = true;
        }

        private void btnAbility3_Click(object sender, EventArgs e)
        {
            moveSelected = true;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            moveSelected = true;
        }

        private void petBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.petBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.f2T5DataSet);

        }

        private void BattleScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrBattle.Stop();
            this.Close();
        }
        

        private void btnAbility1_EnabledChanged(object sender, EventArgs e)
        {
            if (btnAbility1.Enabled)
            {
                btnAbility1.BackgroundImage = BattlePets.Properties.Resources.ability_iyyokuk_sword_white;
            }
            if (!btnAbility1.Enabled)
            {
                btnAbility1.BackgroundImage = BattlePets.Properties.Resources.activity_greyscale;
            }
        }


        private void btnAbility2_EnabledChanged(object sender, EventArgs e)
        {
            if (btnAbility2.Enabled)
            {
                btnAbility2.BackgroundImage = BattlePets.Properties.Resources.ability_iyyokuk_sword_white;
            }
            if (!btnAbility2.Enabled)
            {
                btnAbility2.BackgroundImage = BattlePets.Properties.Resources.activity_greyscale;
            }

        }

        private void btnAbility3_EnabledChanged(object sender, EventArgs e)
        {
            if (btnAbility3.Enabled)
            {
                btnAbility3.BackgroundImage = BattlePets.Properties.Resources.ability_iyyokuk_sword_white;
            }
            if (!btnAbility3.Enabled)
            {
                btnAbility3.BackgroundImage = BattlePets.Properties.Resources.activity_greyscale;
            }
        }

        private Image LoadAbilityImage(int abilityId)
        {
            Image img = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT AbilityPic FROM dbo.Ability WHERE AbilityId = @AbilityId", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityId", SqlDbType.Int).Value = abilityId;
                        cn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            MemoryStream ms = new MemoryStream((byte[])result);
                            img = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message.ToString());
            }

            return img;
        }

    }
}
