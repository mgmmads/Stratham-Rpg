using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratham_Rpg
{
    class Weapon
    {
        private string WeaponName { get; set; }
        private double WeaponDamage { get; set; }
        private string SpecialAttribute { get; set; }
        private double SpecialAttributeDamage { get; set; }

        public string GetWeaponName()
        {
            return WeaponName;
        }

        public double GetWeaponDamage()
        {
            if (SpecialAttribute != "") //Checks if the weapon have any special attribute
            {
                WeaponDamage = WeaponDamage + SpecialAttributeDamage;
            }
            return WeaponDamage;
        }

        public string GetSpecialAttribute()
        {
            return SpecialAttribute;
        }

        public Weapon(string weaponName, double damage, string specialAttribute,double specialAttributeDamage)
        {
            WeaponName = weaponName;
            WeaponDamage = damage;
            SpecialAttribute = specialAttribute;
            SpecialAttributeDamage = specialAttributeDamage;
        }

        public Weapon(string weaponName, double damage) : this(weaponName, damage,"",0.0)
        {

        }
    }
}
