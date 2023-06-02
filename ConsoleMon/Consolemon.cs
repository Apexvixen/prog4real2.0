using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conselmon
{
    internal class Consolemon
    {
        public int health;
        public int energy;
        public string name;
        private List<skill> Skills = new List<skill> { };
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
