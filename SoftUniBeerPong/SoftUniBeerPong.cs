using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniBeerPong
{
    class SoftUniBeerPong
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> listOfTeams = new Dictionary<string, Dictionary<string, int>>();

                string inputData = Console.ReadLine();

            while (inputData != "stop the game")
            {
                var data = inputData.Split('|').ToArray();

                var team = data[1];
                var name = data[0];
                var points = int.Parse(data[2]);

                if (!listOfTeams.ContainsKey(team))
                {
                    listOfTeams.Add(team, new Dictionary<string, int>());
                }
                if (listOfTeams[team].Count < 3)
                {
                listOfTeams[team].Add(name, points);

                }
                
                inputData = Console.ReadLine();
            }
            var orderedTeams = listOfTeams.Where(l => l.Value.Count == 3).OrderByDescending(l => l.Value.Sum(p => p.Value));

            int rank = 1;
            foreach (var team in orderedTeams)
            {
                string teamName = team.Key;
                var playersNames = team.Value;
                var orderdPlayersName = playersNames.OrderByDescending(p => p.Value).ToDictionary(p=>p.Key,p => p.Value);
                    
                   
                
                Console.WriteLine("{0}. {1}; Players:",rank, teamName);
                foreach (var layers in orderdPlayersName)
                {
                    Console.WriteLine($"###{layers.Key}: {layers.Value}");
                }
                rank++;
              
            }
        }
    }
}
