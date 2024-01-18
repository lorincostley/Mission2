using Mission2;
using System;

class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        int numRolls = int.Parse(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.SimulateRolls(numRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / numRolls;
            Console.Write(i + ": ");
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}
