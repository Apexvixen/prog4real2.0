using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace conselmon
{
    internal class Skill
    {

        public int damage;
        public int energyCost;
        public string name;
        internal Element element;
        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
            if (element == target.weakness)
            {
                target.TakeDamage(damage/2);
            }
        }

    }
}
