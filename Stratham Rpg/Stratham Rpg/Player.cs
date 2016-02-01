using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratham_Rpg
{
    class Player : LivingBeing
    {
        public Weapon CurrentWeapon { get; set; } //How to add to a ToString?
        private string PlayerClass { get; set; }
        private double PlayerLevel { get; set; }
        private double MaxMana { get; set; }
        private double CurrentMana { get; set; }
        private double Intellect { get; set; }
        private double Strength { get; set; }
        private double Agility { get; set; }
        private double ExperienceForLevel { get; set; }
        private double Experience { get; set; }
        private double GoldCoins { get; set; }
        public List<Item> BackPack = new List<Item>(); //How to add to a ToString?

        public double ExperienceForNextLevel(int Level) //Gets the amount needed to reach next level
        {
            return 100 * Level;
        }

        public string PlayerInformation() //Misses "List<Item>" and Prop "Weapon CurrentWeapon"
        {
            return Name + ";" + MaxHP.ToString() + ";" + CurrentHP.ToString() + ";"
                + Damage.ToString() + ";" + Level.ToString() + PlayerClass + ";"
                + PlayerLevel.ToString() + ";" + MaxMana.ToString() + ";"
                + CurrentMana.ToString() + ";" + Intellect.ToString() + ";"
                + Strength.ToString() + ";" + Agility.ToString() + ExperienceForLevel.ToString() + ";"
                + Experience.ToString() + ";" + GoldCoins;
        }

        public void KillingMonster()
        {
            //Add gold and exprience gained
        }

        public bool CheckForLevelUp(double exprience)
        {
            Experience = Experience + exprience;
            if (Experience >= ExperienceForNextLevel(PlayerLevel))
            {
                //LevelUp(PlayerLevel); <-- Move to "KillingMonsters()"
                return true;
            }
            return false;
        }

        public void LevelUp(int level)
        {
            if (PlayerClass == "Berserker")
            {
                MaxHP = MaxHP + 2 + level / 2;
                CurrentHP = MaxHP;
                MaxMana = MaxMana + 2;
                CurrentMana = MaxMana;
                Strength = Strength + 3;
                Agility = Agility + 2;
                Intellect = Intellect + 1;
                Damage = Damage + 0.5 + Strength / 2;
            }
            else if (PlayerClass == "Mage")
            {
                MaxHP = MaxHP + 2;
                CurrentHP = MaxHP;
                MaxMana = MaxMana + 2 + level / 2;
                CurrentMana = MaxMana;
                Strength = Strength + 1;
                Agility = Agility + 1;
                Intellect = Intellect + 3;
                Damage = Damage + 0.2 + Intellect / 2;
            }
            else if (PlayerClass == "Ranger")
            {
                MaxHP = MaxHP + 2 + level / 4;
                CurrentHP = MaxHP;
                MaxMana = MaxMana + 2 + level / 4;
                CurrentMana = MaxMana;
                Strength = Strength + 1;
                Agility = Agility + 3;
                Intellect = Intellect + 1;
                Damage = Damage + 0.4 + Agility / 2;
            }

            Experience = Experience - ExperienceForNextLevel(PlayerLevel);
        }

        public Player(string playerClass, string name) //Creates the player, based on class input
        {
            Name = name;
            PlayerClass = playerClass;

            if (playerClass == "Berserker")
            {
                CurrentWeapon = CreatedWeapons.WoodenSword;
                MaxHP = 12.0;
                MaxMana = 2;
                Damage = (0.5 + Strength + (Agility / 2));
                Strength = 6;
                Agility = 3;
                Intellect = 1;
            }
            else if (playerClass == "Mage")
            {
                CurrentWeapon = CreatedWeapons.WoodenStaff;
                MaxHP = 8;
                MaxMana = 5;
                Damage = (0.5 + Agility + (Strength / 4 + (Intellect / 4)));
                Strength = 2;
                Agility = 7;
                Intellect = 3;
            }
            else if (playerClass == "Ranger")
            {
                CurrentWeapon = CreatedWeapons.WoodenBow;
                MaxHP = 9;
                MaxMana = 12;
                Damage = (0.5 + Intellect);
                Strength = 2;
                Agility = 3;
                Intellect = 9;
            }

            PlayerLevel = 1;
            CurrentHP = MaxHP;
            CurrentMana = MaxMana;
            IsAlive = true;
            ExperienceForLevel = 100 * Level;
            Experience = 0;
        }
    }
}
