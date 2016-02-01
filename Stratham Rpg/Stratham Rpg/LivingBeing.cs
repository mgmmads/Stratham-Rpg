using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratham_Rpg
{
    class LivingBeing //Class only for inheriting
    {
        protected string Name { get; set; }
        protected double MaxHP { get; set; }
        protected double CurrentHP { get; set; }
        protected bool IsAlive { get; set; }
        protected double Damage { get; set; }
        protected double Level { get; set; }

        public double TakeDamage(double damage)
        {
            CurrentHP = CurrentHP - damage;
            if (CurrentHP <= 0)
            {
                IsAlive = false;
            }
            return CurrentHP;
        }

        public double HealHP(double healing)
        {
            CurrentHP = CurrentHP + healing;
            if (CurrentHP >= MaxHP)
            {
                CurrentHP = MaxHP;
            }
            return CurrentHP;
        }

        public string GetName()
        {
            return Name;
        }

        public bool CheckIfDead()
        {
            if (IsAlive == false)
            {
                return true; //If dead, returns true.
            }
            return false; //If still alive, returns false.
        }

        public double DoDamage(double damage)
        {
            return Damage;
        }
    }
}
