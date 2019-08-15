using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlePets
{
    public class BattlePet
    {
        public string name { get; set; }
        public int petID { get; set; }
        public int trainerID { get; set; }
        public int level { get; set; }
        public BattlePetType type { get; set; }
        public int health { get; set; }
        public int attack { get; set; }
        private Image icon { get; set; }
        private Image port3d { get; set; }
        public Rarity rarity { get; set; }
        public ability ability1slot1 { get; set; }
        public ability ability1slot2 { get; set; }
        public ability ability2slot1 { get; set; }
        public ability ability2slot2 { get; set; }
        public ability ability3slot1 { get; set; }
        public ability ability3slot2 { get; set; }
        public int experience { get; set; }
        public int maxhealth { get; set; }
        public int speed { get; set; }
        public bool favorite { get; set; }
        public bool starter { get; set; }
        public bool capturable { get; set; }
        public bool affiliated { get; set; }
        public bool can_move { get; set; } = true;
        public int wildpetlabel { get; set; } = 0;
        public BattlePet(string nme, int ID, Image pic, Image por3d, int fav, int lvl, int h, int a, int s, Rarity rare, int exp, int tID, BattlePetType typ)
        {
            name = nme;
            petID = ID;
            icon = pic;
            port3d = por3d;
            if (fav == 1)
            {
                favorite = true;
            }
            else if (fav == 0)
            {
                favorite = false;
            }
            level = lvl;
            health = h;
            attack = a;
            speed = s;
            rarity = rare;
            experience = exp;
            trainerID = tID;
            type = typ;
        }



        public enum BattlePetType
        {
            Aquatic,
            Beast,
            Critter,
            Dragonkin,
            Elemental,
            Flying,
            Humanoid,
            Magic,
            Mechanical,
            Undead
        }
        public enum Directions
        {
            N,
            S,
            E,
            W
        }
        public enum Rarity
        {
            BRONZE,
            SILVER,
            GOLD
        }

        public Directions Direction;

        private int X;
        private int Y;
        const int MaxRange = 100;
        public Point Position => new Point(X, Y);
        public event EventHandler Crash;

        public BattlePet()
        {
            this.X = 0;
            this.Y = 0;
            this.Direction = Directions.N;
        }

        public BattlePet(int xvalue, int yvalue)
        {
            this.X = xvalue;
            this.Y = yvalue;
            this.Direction = Directions.N;
        }

        public void Go(int distance)
        {
            if (this.can_move)
            {
                switch (this.Direction)
                {
                    case Directions.N:
                        Y += distance;
                        if (Y > MaxRange)
                        {
                            Y = MaxRange;
                            Crash(this, EventArgs.Empty);
                        }
                        break;
                    case Directions.S:
                        Y -= distance;
                        if (Y < -MaxRange)
                        {
                            Y = -MaxRange;
                            Crash(this, EventArgs.Empty);
                        }
                        break;
                    case Directions.W:
                        X -= distance;
                        if (X < -MaxRange)
                        {
                            X = -MaxRange;
                            Crash(this, EventArgs.Empty);
                        }
                        break;
                    case Directions.E:
                        X += distance;
                        if (X > MaxRange)
                        {
                            X = MaxRange;
                            Crash(this, EventArgs.Empty);
                        }
                        break;
                }
            }
        }
        public void set_Position(int i, int j)
        {
            this.X = i;
            this.Y = j;
        }

        //public object Clone()
        //{
        //    BattlePet p = new BattlePet();
        //    name = this.name;
        //    petID = this.petID;
        //    icon = this.icon;
        //    port3d = this.port3d;
        //    favorite = this.favorite;
        //    level = this.level;
        //    health = this.health;
        //    attack = this.attack;
        //    speed = this.speed;
        //    rarity = this.rarity;
        //    experience = this.experience;
        //    trainerID = this.trainerID;
        //    type = this.type;
        //    return p;
        //}

        public bool isCapturable()      //public method that checks pet for capture option
        {
            double healthpercentage = this.health / this.maxhealth;     //calculates health as percentage of maximum health
            if (healthpercentage <= 0.35)                               //if current health is 35% or less,
            {
                this.capturable = true;                                     //this battlepet can be captured
                return true;                                                //return isCapturable = true
            }
            else                                                        //if current health is greater than 35%
            {
                this.capturable = false;                                    //this battlepet can not be captured
                return false;                                               //return isCapturable = false
            }
        }
    }

}
