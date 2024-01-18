using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceRoller
    {
        public int[] SimulateRolls(int numRolls)
        {
            Random random = new Random();
            int[] results = new int[13]; // Index 0 is not used, results[2] to results[12] store counts for combinations 2 to 12

            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                results[sum]++;
            }

            return results;
        }
    }
}
