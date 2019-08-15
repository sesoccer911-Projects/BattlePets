using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BattlePets.BattlePet;

namespace BattlePets
{
    public class BattleStateScript
    {
        public string _cnDB = BattlePets.Properties.Settings.Default.F2T5ConnectionString;
        public float maxProb = 1.0f; //100%
        public float baseCritProb = 0.05f;//5%
        public float fiveProb = 0.05f;
        public float fiftyProb = 0.5f;//50%
        public float thirdProb = 0.333333333f;//33.33% repeating of course
        public BattlePet newEnemy = new BattlePet();
        public List<string> enemyNames = new List<string>() { "Totalbiscut", "Hobbs", "Leeroy", "Kralnor", "Edgewalker", "Drakedog", "Alamo", "Nihilum", "Athene", "Faxmonkey" };
        public Random random;
        static T randomEnum<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random().Next(v.Length));
        }

        public BattleScreen.BattleState prepareBattle(BattlePet player)
        {
            newEnemy = CreateNew(newEnemy, 0,true);
            int i = firstTurn(player, newEnemy);
            if(i == 1)
                return BattleScreen.BattleState.PLAYERCHOICE;
            else
                return BattleScreen.BattleState.ENEMYCHOICE;
        }
       
        public BattlePet CreateNew(BattlePet en, int ID, bool enemy)  
        {
            if(enemy)
            {
                Random r = new Random();
                ID = r.Next(1, 31);                        //between 1 and 30 for the pet ID
            }

            string nme = null;                              //null values for the rest of the required BattlePet constructor parameters
            Image pic = null;
            Image por3d = null;
            int fav = 0;
            int lvl = 0;
            int h = 0;
            int a = 0;
            int s = 0;
            BattlePet.Rarity rare = BattlePet.Rarity.BRONZE;
            int exp = 0;
            int tID = 0;
            BattlePet.BattlePetType typ = BattlePet.BattlePetType.Undead;

            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Name FROM dbo.Pet WHERE PetID = @PetId", cn))        //get the name from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        cn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            nme = Convert.ToString(result);
                        }

                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT PetPic FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the pet picture from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            MemoryStream ms = new MemoryStream((byte[])result);
                            pic = Image.FromStream(ms);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Port3d FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the pet 3d port image from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            MemoryStream ms = new MemoryStream((byte[])result);
                            por3d = Image.FromStream(ms);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Favorite FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the favorite from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            fav = Convert.ToInt32(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Lvl FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the level from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            lvl = Convert.ToInt32(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Health FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the health from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            h = Convert.ToInt32(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Attack FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the attack from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            a = Convert.ToInt32(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Speed FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the speed from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            s = Convert.ToInt32(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Rarity FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the rarity from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            string g = Convert.ToString(result);
                            switch (g)
                            {
                                case "B":
                                    rare = BattlePet.Rarity.BRONZE;
                                    break;
                                case "G":
                                    rare = BattlePet.Rarity.GOLD;
                                    break;
                                case "S":
                                    rare = BattlePet.Rarity.SILVER;
                                    break;
                            }
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Experience FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the experience from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            exp = Convert.ToInt32(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT TrainerID FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the trainer ID from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            tID = Convert.ToInt32(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT TypeID FROM dbo.Pet WHERE PetID = @PetId", cn))      //get the type from the database according to the randomly generated pet ID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = ID;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            int switchint = Convert.ToInt32(result);
                            switch (switchint)
                            {
                                case (0):
                                    {
                                        typ= BattlePet.BattlePetType.Aquatic;
                                        break;
                                    }
                                case (1):
                                    {
                                        typ = BattlePet.BattlePetType.Beast;
                                        break;
                                    }
                                case (2):
                                    {
                                        typ = BattlePet.BattlePetType.Critter;
                                        break;
                                    }
                                case (3):
                                    {
                                        typ = BattlePet.BattlePetType.Dragonkin;
                                        break;
                                    }
                                case (4):
                                    {
                                        typ = BattlePet.BattlePetType.Elemental;
                                        break;
                                    }
                                case (5):
                                    {
                                        typ = BattlePet.BattlePetType.Flying;
                                        break;
                                    }
                                case (6):
                                    {
                                        typ = BattlePet.BattlePetType.Humanoid;
                                        break;
                                    }
                                case (7):
                                    {
                                        typ = BattlePet.BattlePetType.Magic;
                                        break;
                                    }
                                case (8):
                                    {
                                        typ = BattlePet.BattlePetType.Mechanical;
                                        break;
                                    }
                                case (9):
                                    {
                                        typ = BattlePet.BattlePetType.Undead;
                                        break;
                                    }

                            }
                            cn.Close();
                        }
                    }
                }

                en = new BattlePet(nme, ID, pic, por3d, fav, lvl, h, a, s, rare, exp, tID, typ);

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message.ToString());
            }
            if(enemy)
            {
                Random r = new Random();
                int i = r.Next(enemyNames.Count);
                en.name = enemyNames[i];
                en.affiliated = false;
                en.capturable = false;
                en.favorite = false;
                en.wildpetlabel = 0;
                en.starter = false;
            }
            else
            {
                en.affiliated = true;
                en.capturable = false;
                en.starter = true;
            }

            en = set_abilities(en, "Ability1s1");
            en = set_abilities(en, "Ability1s2");
            en = set_abilities(en, "Ability2s1");
            en = set_abilities(en, "Ability2s2");
            en = set_abilities(en, "Ability3s1");
            en = set_abilities(en, "Ability3s2");
            if(enemy)
            {

                Random r = new Random();
                int l = r.Next(1);
                if (l == 1)
                {
                    en.ability1slot1.prime = "true";
                    en.ability1slot2.prime = "false";
                }
                if (l == 0)
                {
                    en.ability1slot2.prime = "true";
                    en.ability1slot1.prime = "false";
                }

                l = r.Next(1);
                if (l == 1)
                {
                    en.ability2slot1.prime = "true";
                    en.ability2slot2.prime = "false";
                }
                if (l == 0)
                {
                    en.ability2slot2.prime = "true";
                    en.ability2slot1.prime = "false";
                }

                l = r.Next(1);
                if (l == 1)
                {
                    en.ability3slot1.prime = "true";
                    en.ability3slot2.prime = "false";
                }
                if (l == 0)
                {
                    en.ability3slot2.prime = "true";
                    en.ability3slot1.prime = "false";
                }
            }
            return en;
        }


        public int firstTurn(BattlePet player1, BattlePet player2)  
        {
            if (player1.speed > player2.speed)       //if player 1 has the faster pokemon
            {
               return 1;   //player choice
            }
            else if (player2.speed > player1.speed)       //if player 2 has the faster pokemon
            {
                return 2;    //enemy choice
            }
            else    //if players 1 and 2 have pokemon with equal speeds
            {
                Random rint = new Random();                     //generate a random number to decide who goes first
                int i = rint.Next(2);                        //between 0 and 1
                if (i == 0)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public Effect enemyMove(BattlePet enemy)                            //return the effect of the randomly-generated enemy move selected 
        {
            Random r = new Random();
            int k = r.Next(3);                                              //generate a random number 0, 1, or 2
            if (k == 0)                                                 //if random number is 0, 
            {
                if (enemy.ability1slot1.prime == "true")                    //if the first ability in the first ability slot is prime 
                    return enemy.ability1slot1.TypEffect;                       //return the effect of that ability
                if (enemy.ability1slot1.prime == "false")                   //if the second ability in the first ability slot is prime 
                    return enemy.ability1slot2.TypEffect;                       //return the effect of that ability
            }
            else if (k == 1)                                            //if random number is 1, 
            {
                if (enemy.ability2slot1.prime == "true")                    //if the first ability in the second ability slot is prime 
                    return enemy.ability2slot1.TypEffect;                       //return the effect of that ability
                if (enemy.ability2slot1.prime == "false")                   //if the second ability in the second ability slot is prime 
                    return enemy.ability2slot2.TypEffect;                       //return the effect of that ability
            }
            else if (k == 2)                                            //if random number is 2,
            {
                if (enemy.ability3slot1.prime == "true")                    //if the second ability in the third ability slot is prime 
                    return enemy.ability3slot1.TypEffect;                       //return the effect of that ability
                if (enemy.ability3slot1.prime == "false")                    //if the second ability in the third ability slot is prime 
                    return enemy.ability3slot2.TypEffect;                       //return the effect of that ability
            }
                return enemy.ability3slot2.TypEffect;                           //otherwise, return the second ability of the third ability slot
        }


        public BattlePet set_abilities(BattlePet en, string abilityslot)     //take in the BattlePet to be edited/returned as well as the ability and slot to be filled in
        {
            string Name = null;
            int ability_id = 0;
            int TypeID = 0;
            string Type = null;
            string Prime = null;
            int Damage = 0;
            string Description = null;
            Image Icon = null;
            Effect Effect = Effect.INVALID_MOVE;

            //determine ability ID from pet ID
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT " +abilityslot+ " FROM dbo.Pet WHERE PetID = @PetId", cn))        //get the Ability ID from Ability table according to AbilityID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@PetId", SqlDbType.Int).Value = en.petID;
                        cn.Open();
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            ability_id = Convert.ToInt32(result);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message.ToString());
            }

            //next, assign Name, TypeID, Type, Prime, Damage, Description, Icon
            try
            {
                using (SqlConnection cn = new SqlConnection(_cnDB))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT TypeID FROM dbo.Ability WHERE AbilityID = @AbilityID", cn))        //get the ability TypeID from Ability table according to AbilityID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityID", SqlDbType.Int).Value = ability_id;
                        cn.Open();                                                                                                                      //only open ONCE
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            TypeID = Convert.ToInt32(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Name FROM dbo.Ability WHERE AbilityID = @AbilityID", cn))        //get the ability Name from Ability table according to AbilityID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityID", SqlDbType.Int).Value = ability_id;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            Name = Convert.ToString(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Type FROM dbo.Ability WHERE AbilityID = @AbilityID", cn))        //get the ability Type from Ability table according to AbilityID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityID", SqlDbType.Int).Value = ability_id;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            Type = Convert.ToString(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Prime FROM dbo.Ability WHERE AbilityID = @AbilityID", cn))        //get the ability Prime from Ability table according to AbilityID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityID", SqlDbType.Int).Value = ability_id;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            Prime = Convert.ToString(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Description FROM dbo.Ability WHERE AbilityID = @AbilityID", cn))        //get the ability Description from Ability table according to AbilityID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityID", SqlDbType.Int).Value = ability_id;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            Description = Convert.ToString(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Damage FROM dbo.Ability WHERE AbilityID = @AbilityID", cn))        //get the ability Damage from Ability table according to AbilityID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityID", SqlDbType.Int).Value = ability_id;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            Damage = Convert.ToInt32(result);
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Icon FROM dbo.Ability WHERE AbilityID = @AbilityID", cn))        //get the ability Icon from Ability table according to AbilityID
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@AbilityID", SqlDbType.Int).Value = ability_id;
                        var result = cmd.ExecuteScalar();
                        if (result != System.DBNull.Value)
                        {
                            MemoryStream ms = new MemoryStream((byte[])result);
                            Icon = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message.ToString());
            }
            ability assignedability = new ability(Name, ability_id, TypeID, Type, Prime, Damage, Description, Icon, Effect);        //create the instance of ability with the correct information

            switch(abilityslot)
            {
                case "Ability1s1":
                    en.ability1slot1 = assignedability;
                    break;
                case "Ability1s2":
                    en.ability1slot2 = assignedability;
                    break;
                case "Ability2s1":
                    en.ability2slot1 = assignedability;
                    break;
                case "Ability2s2":
                    en.ability2slot2 = assignedability;
                    break;
                case "Ability3s1":
                    en.ability3slot1 = assignedability;
                    break;
                case "Ability3s2":
                    en.ability3slot2 = assignedability;
                    break;
            }
            return en;

        }

    }
    

}
