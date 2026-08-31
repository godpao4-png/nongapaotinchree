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
        {   //part A Lab 02
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
           
            //part B Lab 02
            string Name = "jin rang";
            string Class = "warrior";
            int Level = 4;
            int  Hp = 200;
            float attack = 20.5f;
            double crit = 1.30;
            bool character = true;

            Console.WriteLine("===== CHARACTER STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"HP: {Hp}");
            Console.WriteLine($"Attack Power: {attack}");
            Console.WriteLine($"Crit Multiplier: {crit}");
            Console.WriteLine($"Is Character: {character}");
            Console.WriteLine();

            int hpPercentageCharacter = Hp * 100 / Hp;
            Console.WriteLine($"Hp Percentage: {hpPercentage}%");
            Console.WriteLine();

            Console.WriteLine($"jin rang takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== CHARACTER STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percentage: {hpPercentage}%");
           
            //
            string Name1 = "hopin";
            string Class1 = "mage";
            int Level1 = 4;
            int Hp1 = 200;
            float Mage = 10.5f;
            double mana = 100.0;
            bool character1 = true;

            Console.WriteLine("===== CHARACTER1 STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"Name: {Name1}");
            Console.WriteLine($"Class: {Class1}");
            Console.WriteLine($"Level: {Level1}");
            Console.WriteLine($"HP: {Hp1}");
            Console.WriteLine($"Attack Power: {Mage}");
            Console.WriteLine($":mage {mana}");
            Console.WriteLine($"Is Character: {character1   }");
            Console.WriteLine();

            int hpPercentageCharacter1 = Hp1 * 100 / Hp1;
            Console.WriteLine($"Hp Percentage: {hpPercentage}%");
            Console.WriteLine();

            Console.WriteLine($"hopin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== CHARACTER1 STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percentage: {hpPercentage}%");
            
            //
            string dammeName = "tony";
            char dammeClass = 'A';
            int dammeHp = 120;
            float attackdamme = 15.5f;
            double critdamme = 1.20;
            bool isDamme = true;

            Console.WriteLine("===== Damme STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"Name: {dammeName}");
            Console.WriteLine($"Class: {dammeClass}");
            Console.WriteLine($"HP: {dammeHp}");
            Console.WriteLine($"Attack Power: {attackdamme}");
            Console.WriteLine($"Crit Multiplier: {critdamme}");
            Console.WriteLine($"Is Character: {isDamme}");

            int hpPercentageDamme = dammeHp * 100 / dammeHp;
            Console.WriteLine($"Hp Percentage: {hpPercentageDamme}%");
            Console.WriteLine();

            Console.WriteLine($"damme takes 20 damage!");
            currentHp = currentHp - 20;
            Console.WriteLine();

            Console.WriteLine("===== DAMME STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percentage: {hpPercentage}%");
            //
            string bossName1 = "jong gun";
            char bossClass = 'S';
            int bossHp = 400;
            float attackboss = 70.0f;
            double critboss = 4.50;
            bool Boss = true;

            Console.WriteLine("===== BOSS1 STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"Name: {bossName1}");
            Console.WriteLine($"Class: {bossClass}");
            Console.WriteLine($"HP: {bossHp}");
            Console.WriteLine($"Attack Power: {attackboss}");
            Console.WriteLine($"Crit Multiplier: {critboss}");
            Console.WriteLine($"Is Boss: {Boss}");
            Console.WriteLine();

            int hpPercentageBoss = bossHp * 100 / bossHp;
            Console.WriteLine($"Hp Percentage: {hpPercentageBoss}%");
            Console.WriteLine();


            Console.WriteLine($"boss1 takes 80 damage!");
            currentHp = currentHp - 80;
            Console.WriteLine();

            Console.WriteLine("===== BOSS1 STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percentage: {hpPercentage}%");
            Console.WriteLine();
        }
    }
}
