using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conselmon
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            string[] lines = File.ReadAllLines(datafile);



            foreach (string line in lines)
            {
                string[] typeSplit = line.Split("|");
                string[] consoleMonData = typeSplit[0].Split(",");

                ConsoleMon dataMon = new ConsoleMon();

                //stats
                dataMon.name = consoleMonData[0];
                dataMon.health = int.Parse(consoleMonData[2]);
                dataMon.energy = int.Parse(consoleMonData[4]);
                dataMon.weakness = Enum.Parse<Element>(consoleMonData[6]);
                Console.WriteLine(dataMon.name);
                Console.WriteLine("Health: " + dataMon.health);
                Console.WriteLine("Energy: " + dataMon.energy);
                Console.WriteLine("Weakness: " + dataMon.weakness);

                // skills

                string[] skillData = typeSplit[1].Split(";");

                string[] skill1Data = skillData[1].Split(",");
                string[] skill2Data = skillData[2].Split(",");


            }

        }
    }
}
