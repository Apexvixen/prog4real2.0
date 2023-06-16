using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conselmon
{
    internal class ConsoleMon
    {
        public int health;
        public int energy;
        public string name;
        private List<Skill> Skills = new List<Skill> { };

        internal Element weakness; 
        internal void TakeDamage(int damage)
        {
            health -= damage;

        }
        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }

    }
}
