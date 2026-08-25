/*
 * Student ID :1690701253
 * Name       :ungpao
 * Section    :129B
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"critMultiplier: {critMultiplier}");
            Console.WriteLine($"isBoss: {isBoss}");
            Console.WriteLine();

            int hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percentage: {hpPercentage}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percentage: {hpPercentage}%");
        }
    }
}
