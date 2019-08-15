using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BattlePets
{
    public class ability
    {
        public string name { get; set; }
        public int abilityID { get; set; }
        public int typeID { get; set; }
        public string type { get; set; }
        public string prime { get; set; } = "false";    //identifies whether this ability is the primary ability for this slot. only 1 primary ability per slot. default is false.
        public int damage { get; set; }
        public string description { get; set; }
        public Image icon { get; set; }
        public Effect TypEffect { get; set; }

        public ability(string Name, int AbilityID, int TypeID, string Type, string Prime, int Damage,
            string Description, Image Icon, Effect Effect)
        {
            name = Name;
            abilityID = AbilityID;
            typeID = TypeID;
            type = Type;
            prime = Prime;
            damage = Damage;
            description = Description;
            icon = Icon;
            TypEffect = Effect;
        }

        //public VARDESC F2T5DataSet(ability)://database name
        //ability[]; // all the abilities are here

        //public int Findability(int AbilityID)// call to retrieve ability data
        //{
        //    return F2T5DataSet[AbilityID];
        //}
    }
    public enum Effect { INVALID_MOVE }
    //{
    //    INVALID_MOVE,
    //    // basic attacks
    //    SIMPLEDAMAGE200,
    //    SIMPLEDAMAGE100,
    //    SIMPLEHIGHLOW100,
    //    SIMPLEDAMAGE050,
    //    ONETOTHREEDAMAGE100,
    //    NOBELOW1DAMAGE100,
    //    050CRITDAMAGE100, // 50% chance to crit
    //                            // team attacks
    //    // attacks with damage back
    //    SIMPLEDAMAGEBACK100,
    //    // attacks with conditional extra damage
    //    EXTRAATTDAMAGE100,    // extra damage if attacked
    //    EXTRAFASTDAMAGE100,    // extra damage if faster
    //    DIFFERENTFASTDAMAGE100,    // different damage if faster
    //    EXTRASLOWDAMAGE100,    // extra damage if slower
    //    DOUBLEBELOW25DAMAGE100,    // extra damage if opponent lower than 25% health
    //    DOUBLEPOISONEDDAMAGE100,           // double damage if poisoned
    //    DOUBLEBLINDEDDAMAGE100,           // double damage if blinded
    //    DOUBLESTUNNEDDAMAGE100,  // double damage if stunned
    //    EXTRACHILLEDDAMAGE100,    // extra damage if chilled
    //    EXTRABLEEDDAMAGE100,    // extra damage if bleeding
    //    EXTRABURNDAMAGE100,    // extra damage if bleeding
    //    EXTRALOWHDAMAGE100,   // extra damage if user has lower health
    //    EXTRAARCANEDAMAGE100, // extra damage if weather is arcane
    //    EXTRAFASTONETWO100,   // 1-2 hits, one more if user is first
    //    INCREASINGDAMAGE100,  // increasing damage if used consecutively
    //    FRACTION010DAMAGE100,    // hits with second hit reducing health
    //    DOUBLEWEBSPLIT2DAMAGE100,
    //    LASTHITDAMAGE100, // hits for last hit against active pet (misses if no last hit)
    //    FLASH,
    //    // attacks with conditional accuracy
    //    BLEED100DAMAGE050,    // extra hit if bleeding
    //    BLIND100DAMAGE050,    // extra hit if target blind
    //    MOONLIGHT100DAMAGE080,    // extra hit if moonlight
    //                                    // attacks with conditional speed
    //    FIRSTBLIZZARDDAMAGE050,    // first if blizzard
    //                                     // attacks with heal
    //    HEAL100DAMAGE100,     // heals 100% of the damage done
    //    HEAL050DAMAGE100,     // heals 50% of the damage done
    //    HEALKILLDAMAGE100,    // heals if attack kills the enemy
    //    HEALDOUBLEWEBDAMAGE100,     // heals 100% of the damage done
    //    HEAL1ROUNDDAMAGE100,  // heals seperate damage done + 1 round DOT/HOT
    //    PHEROMONES,
    //    DRAINBLOOD,
    //    HEALMISSDAMAGE050,         // heals if misses
    //                                     // attack that go first
    //    FASTDAMAGE100,        // goes fast (5x?)
    //    FASTDAMAGE085,        // goes fast (5x?)
    //                                // multi-round attacks
    //    GOLOWDAMAGE100,       // goes underground, then attacks
    //    GOHIGHDAMAGE100,       // goes in the air, then attacks
    //    SUBMERGEDAMAGE100,       // goes underwater, then attacks
    //    SUBMERGE2SUNS,       // goes underwater, then attacks
    //    HEALKILL2ROUNDDAMAGE100,  // heals if kills
    //    EXTRAARCANE3ROUNDDAMAGE100, // mana surge
    //    2ROUNDATTACK100,      // haywire
    //    3ROUNDATTACK100,      // rampage
    //    QUAKE,
    //    TYMPANICTANTRUM,
    //    RECHARGE2DAMAGE100,
    //    BUILDUP1DAMAGE100,
    //    // multi-attack attacks
    //    THREEATTACKSDAMAGE100,
    //    // attacks with buff/debuff
    //    1ROUNDINCDMG1ROUND100DAMAGE100, // increases opponent's damage taken by 100% (if hit) over 1 round (split damage)
    //    DECSPD425DAMAGE100,   // reduces opponents speed by 25% for 4 rounds and attacks
    //    DECSPD225DAMAGEHL100,   // reduces opponents speed by 25% for 2 rounds and attacks (slither)
    //    DECSPD225DAMAGE100,   // reduces opponents speed by 25% for 2 rounds and attacks (frost shock)
    //    DECSPD125DAMAGE100,   // reduces opponents speed by 25% for 2 rounds and attacks
    //    QUICKSAND,            // reduces opponents speed by 50% for 2 rounds and attacks
    //    DECDMG325DAMAGE100,   // reduces opponents damage by 25% for 3 rounds and attacks
    //    DECACC420DAMAGE100,   // reduces opponents accuracy by 20% for 4 rounds and attacks
    //    INCSPD100DAMAGE100,   // increase user speed by 100% next round and attacks
    //    INCSPD2100DAMAGE100,   // increase user speed by 100% next two round and attacks
    //    CENTRIFUGALHOOKS,   // increase user speed by 100% next two round and attacks
    //    INCSPD375DAMAGE100,   // increase user speed by 75% for 3 rounds and attacks
    //    INCSPD450DAMAGE100,   // increase user speed by 75% for 3 rounds and attacks
    //    INCDMG325DAMAGE100,   // increase user damage by 25% for 3 rounds
    //    INCDMGTAK25HLDAMAGE100,   // increase user taken damage by 25% for 3 rounds (reckless strike)
    //    DECDMG225INCDMG225DAMAGE100,   // reduce target damage done, increase damage done
    //    INCDMG325INCDMG350DAMAGE100,   // increase target damage by 25% for 3 rounds in ... rabies
    //    COINTOSS,           // increase target damage by 25% for 3 rounds in ... rabies
    //    INCTARDMG325DAMAGE100,   // increase target damage taken by 25% for 3 rounds
    //    DECSPD150DECDMG150DAMAGE100, // weakness
    //    HEARTBROKEN, // 
    //    DECDMG1ATTACK100,     // decrease damage from next hit (rake)
    //    2DECDMG1ATTACK100,     // decrease damage from next hit (different reduction -- bark)
    //    IRONBARK,     // decrease damage for one round
    //    DECHEAL250DAMAGE100,  // receives lower healing for 2 rounds
    //    DOTBLEED5DAMAGE100,   // attacks, dots with bleed
    //    DOTBLEED4DAMAGE100,   // attacks, dots with bleed
    //    DOTBURN2DAMAGE100,   // attacks, dots with burn
    //    DOTBURN4DAMAGE100,   // attacks, dots with burn
    //    DOTBURNI4DAMAGE100,   // attacks, dots with burn
    //    DOTBURNI24DAMAGE100,   // attacks, dots with burn
    //    FLAMEJET,
    //    CORROSION,             // + dmg, dot (aquatics??)
    //    DOTEL3DAMAGE100,      // applies an elemental dot (3 rounds) and attacks
    //    DOTEL4DAMAGE100,      // applies an elemental dot (4 rounds) and attacks
    //    DOTEL5DAMAGE100,      // applies an elemental dot (5 rounds) and attacks
    //    DOT2WINDDAMAGE100,    // wild winds
    //    DOT3OOZEDAMAGE100,    // creeping ooze
    //    DOT4ACIDDAMAGE100,    // acid touch
    //    TOXICSMOKE,           // 
    //    DOT9DEATH,            // death and decay
    //    DOT4STICKDAMAGE080,   // nut barrage & money barrage & bone barrage
    //    DOT3STICKDAMAGE050,   // rock barrage
    //    DOT2STICKDAMAGE050,   // banana barrage
    //    DOT1STICKDAMAGE050,   // egg barrage
    //    BUFFNDUMP100,         // barrel toss
    //    PUMPNDUMP100,         // pump
    //    WINDUPNDUMP100,       // pump
    //    LAUCHROCKET,          // pump
    //    DEBUFFNDUMP100,       // lock-on
    //    GRAVITY,              // gravity
    //    ROT,                  // rot
    //    BLISTERINGCOLD,       // 
    //    INCSPD020INCREASINGDAMAGE100, // progressively add speed buff
    //    ROOTED2DAMAGE100, // rooted for 2
    //    WEBBED2DAMAGE100, // rooted for 2
    //    ROOTED3DAMAGE100, // rooted for 3
    //    ROOTED5DAMAGE100, // rooted for 5 -- sticky goo only? (no)
    //    BRITTLEDAMAGE100,
    //    STUNDAMAGE100, // stun (only this round)
    //    BLINDED2100DAMAGE100, // 100% chance to partially blind
    //    BLINDED50DAMAGE100, // 50% chance to partially blind
    //    STUNNED25DAMAGE100, // 25% chance to stun
    //    SLEEPED25HIGHLOW100, // 25% chance to sleep
    //    STUNNED25DARKDAMAGE100, // 25% chance to stun, 100% if darkness
    //    STUNNED25CHILLHLDAMAGE100, // 25% chance to stun, 100% if chilled (deep freeze)
    //    STUNNEDBLINDDAMAGE100, // 100% chance to stun if blinded
    //    MOTHBALLS,
    //    SIPHONLIFE,              // dot with heal
    //    PLAGUEDBLOOD,
    //    TOUCHOFTHEANIMUS,
    //    // team attacks with debuff
    //    TEAMDECSPD425DAMAGE100,   // reduces team opponents speed by 25% for 4 rounds and attacks
    //                                    // hybrid attacks
    //    TRANSFORM125INCREASING100, // 25% chance to tranform for 1 round, increasing damage
    //    SLEEPING125INCREASING100, // 25% chance to sleep for 1 round, increasing damage
    //    3ROUNDINCDMG2ROUND100DAMAGE100, // increases opponent's damage taken by 100% (if hit) over 3 rounds (split damage)
    //    2ROUNDINCDMG1ROUND100DAMAGE100, // increases opponent's damage taken by 100% (if hit) over 2 rounds (split damage)
    //    STUNFASTER050DAMAGE100,    // 50% chance to stun if faster
    //    STUNMISSDAMAGE050,         // stuns if misses
    //    STUNSELFDAMAGE100,         // stuns self
    //    EXTRASUNRECHARGE2DAMAGE100, // extra damage if sun
    //    EXTRARAIN3ROUNDTEAMATTACK100, // bunch of crap
    //    CLEARUSERDEBUFFS, // clears almost everything from active
    //    CLEARTEAMDEBUFFS, // clears almost everything from team
    //    CORPSEEXPLOSION,
    //    EXPLODE,
    //    ARMAGEDDON,
    //    RAINDANCE,           // heal with double buff
    //    AUTUMNBREEZE,   // team heal with team hit debuff
    //    RIGHTEOUSINSPIRATION,
    //    HIGHLOWATTACKOBJECTCLEAR100, // attack and clear objects
    //    HAUNT,
    //    // switching attacks
    //    SWITCHNEXTDAMAGE100,
    //    SWITCHHIGHESTDAMAGE100,
    //    SWITCHLOWESTDAMAGE100,
    //    // basic heals
    //    SIMPLEHEAL,
    //    HEALFRACTION025,           // heals 1/4 health
    //    HEALFRACTION025FIRST,      // heals 1/4 health and goes first
    //    HEALHALFHIT,               // heals fixed amount + 1/2 last hit
    //    HEAL1ROUND,
    //    HEALALL,
    //    HEALOTHERS,
    //    HEALEQUALIZE, // life exchange
    //    HEALALLAQUATIC,
    //    HEALSELFALLMECHANICAL,
    //    HEALINCMAXHEALTH9ROUNDS,
    //    HIBERNATE,
    //    REPAIR,
    //    CONSUME_CORPSE,
    //    // straight buff/debuff
    //    DMGACTIVE5ROUND100_SWARM, // does damage to the active pet for 5 rounds
    //    GLOWINGTOXIN,
    //    CONFUSING_STING,
    //    IMMOLATION,
    //    CREEPING_FUNGUS,
    //    SPORE_SHROOMS,
    //    AGONY,                 // "increasing damage" inconsistent against aquatics (bug)
    //    MAGMATRAP,             // hate this one
    //    SNAPTRAP,              // 
    //    ICETOMB,               // ice tomb
    //    ELEMENTIUMBOLT,        // elementium bolt
    //    WHIRLPOOL,             // whirlpool
    //    EXPLOSIVEBREW,         // 
    //    STICKYGRENADE,         // 
    //    GEYSER,                // geyser
    //    BOOBYTRAPPEDPRESENTS,  // switch
    //    MINEFIELD,             // switch
    //    STUNSEED,              //
    //    ENTANGLINGROOTS,       //
    //    CHEW,                  // chew
    //    CURSEOFDOOM,           // COD
    //    BOMBINGRUN,            // 
    //    UNCANNYLUCK,           // luck
    //    STIMPACK,              // stimpack
    //    DECDMG2ROUND050,       // reduces damage against user by 50% for 2 rounds
    //    2DECDMG2ROUND050,      // reduces damage against user by 50% for 2 rounds
    //    EXTRAPLATING,      // reduces damage against user by 50% for 2 rounds
    //    DECDMG3ROUND050,       // reduces damage against user by 50% for 3 rounds (tough and cudly)
    //    INCDMG2ROUND100,       // increases damage against opponent by 100% for 2 rounds
    //    INCDMG2ROUND050,       // increase user damage by 50% for 2 rounds
    //    INNERVISION,           // increase user damage by 100% for 1 round
    //    INCCRIT425,            // increases critical strike by 25% for 4 rounds
    //    BONKERS,               // increases critical strike by 100% for 2 rounds
    //    INCCRIT250,            // increases critical strike by 50% for 2 rounds
    //    ADRENALGLANDS,            // increases critical strike by 50% for 5 rounds
    //    NIMBUS,                // increases team hit by 20% for 9 rounds
    //    ANZU,                  // accuracy + attack boost
    //    INCHIT425,             // luck?
    //    INCHIT5100,            // luck?
    //    CELESTIALBLESSING,            // 
    //    ENDURE1,               // survives the next round (health no go below 1)
    //    REBIRTH1,              // survives the next round bad bad
    //    HOT5ROUNDELEMENTAL,    // Nature's Ward
    //    HOT5ROUNDPT,           // photosyn
    //    HOT5ROUNDSM,           // five round hot
    //    HOT3ROUNDRM,           // three round hot
    //    HOT2ROUNDTQ,           // tranquillity
    //    SHIELD5ROUND,          // five round shield
    //    EPRESENCE5ROUND,       // soooh
    //    JADESKIN5ROUND,       // soooh
    //    BARKSKIN,             //
    //    STONESKIN5ROUND,       // five round shield
    //    TRIHORNSHIELD3ROUND,   // three round shield
    //    SPIKED5ROUND,          // five round shield with damage back
    //    SPIRITSPIKES,          // 
    //    LIGHTNINGSHIELD2ROUND, // two round damage back (no shield)
    //    THORNS,                // five round damage back
    //    HEATUP,                // 3 round damage back
    //    SPINYCARAPACE,         //
    //    TOXICSKIN,             //
    //    REFLECTIVESHIELD,      //
    //    INCTEAMSPD9ROUND025,   // increase team speed by 25% for 9 rounds (dazzling dance)
    //    2INCTEAMSPD9ROUND025,  // increase team speed by 25% for 9 rounds (moon dance)
    //    SHIELDSTORM,           // gives each pet a block
    //    PLANT,                 // plant
    //    CYCLONE,               // release a cyclone
    //    BUILDTURRET,           // 
    //    XE321BOOMBOT,           // 
    //    VOLCANO,               // make a volcano
    //    UNHOLYASCENSION,
    //    ADDDAMWILD,            // adds damage against target
    //    ADDDAMEXPOSED,         // adds damage against target
    //    ADDDAMCLAW,            // adds damage against target
    //    FORBODINGCURSE,        // adds damage against target and a speed debuff
    //    ADDDAMMANGLE,          // adds damage against target
    //    DODGE,                 // dodge
    //    DEFLECTION,            // deflection
    //    FADING,                // go invisible in two turns
    //    FEIGN_DEATH,           // stuff
    //    PORTAL,               // stuff
    //    FADE,                  // more stuff
    //    ETHEREAL,              // more stuff n stuff
    //    SHIELDBLOCK,           // block 1 attack
    //    BUBBLE,                // block 2 attacks
    //    DECOY,                // block 2 attacks
    //    SOULWARD,               // block 1 attack
    //    COCOONSTRIKE,          // block 1 attacks, goes second next round
    //    ICE_BARRIER,           // block 2 attacks from anyone
    //    BEAVER_DAM,            // block 2 attacks from anyone
    //    PRISMATICBARRIER,            // block 2 attacks from anyone
    //    ILLUSIONARYBARRIER,            // block 2 attacks from anyone
    //    DECCRIT4ROUND,         // lower enemy crit
    //    DECACC425,
    //    INEBRIATE,
    //    BLINDINGPOISON,
    //    NEVERMORE,
    //    CUTE_FACE,             // 
    //    FROLICK,               // 
    //    SOOTHE,                // asleep in one round if not damaged
    //    STUN,                  // stun for a round
    //    FOOD_COMA,             //
    //    INCDMG1HIT1ROUND,      // double damage, 1 hit, 1 round, (focused chi)
    //    DOMINANCE,             // double damage, 1 hit, 2 rounds
    //    SUPERCHARGE,           // double damage, 1 hit, 1 round
    //    PROWL,                 // + 150% dmg on hit, -30% on speed
    //    CRYSTAL_OVERLOAD,      // annoying ability
    //    ACIDIC_GOO,            // + 25% dmg, dot (aquatics??)
    //    SEARMAGIC,
    //    APOCALYPSE,
    //    STING6ROUND,

    //    weather
    //}; // idk what i was thinking here but I am sure it wasnt good but there is too much to toss

}
