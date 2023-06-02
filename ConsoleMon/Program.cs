using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conselmon
{
    internal class Program
    {
        static void TestSkillFunctions()
        {
            Console.WriteLine("TestSkillFunctions");
            Consolemon casterMon = new Consolemon();
            Consolemon targetMon = new Consolemon();
            skill skill = new skill()
            {
                dam = 100,
                costenergy = 20,
            };
            skill.UseOn(targetMon, casterMon);

            Console.WriteLine(targetMon.health == -100);

            Console.WriteLine(casterMon.energy == -20);
        }
        static void TestConsolemonFunctions()
        {
            Console.WriteLine("TestConsolemonFunctions");
            Consolemon mon = new Consolemon();
            mon.TakeDamage(100);
            mon.DepleteEnergy(20);

            Console.WriteLine(mon.health == -100);

            Console.WriteLine(mon.energy == -20);
        }
        static void Main(string[] arg)
        {
            Console.WriteLine("goood bye");
            TestConsolemonFunctions();
            Console.WriteLine("no");
            TestSkillFunctions();
        }

        
    }
}