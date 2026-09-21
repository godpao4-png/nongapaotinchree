

namespace Lap06

//Student ID : 1690701253
//Name       : PIYAWAT THANTHONG
//Section    : 129B
//No.        :
//Course     : GI113 Computer Programming (GI113)

{
    internal class Program
    {
        static void Main(string[] args)
        {

            int charecterHP = 100;
            int monter1HP = 120;
            int monter2HP = 150;
            int monter3HP = 80;

            Console.WriteLine("Game TITLE: HELLDIVER 2");
            Console.WriteLine("Character BRAIN ENCOUNTER A MONSTER");
            Console.WriteLine("ACTION 1: ATTACK");
            Console.WriteLine("ACTION 2: DRINK POTION HP");
            Console.WriteLine("ACTION 3: RELOAD AMMO");
            Console.WriteLine("ACTION 4: CALL FOR BACKUP ");

            Console.WriteLine("CHOOSE YOUR ACTION (1-4): ");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int action);
            if (!isInputValid ==true || action < 1 || action > 4)
            {
                Console.WriteLine("You idiot, it only lets you choose 1 to 4. Go back and choose again.");
            }
            else if (action == 1)
            {
                Console.WriteLine("You attack the monster!");
                monter1HP -= 20;
                Console.WriteLine($"Monster 1 HP: {monter1HP}");
            }
            else if (action == 2)
            {
                Console.WriteLine("You drink a potion and restore your HP!");
                charecterHP += 30;
                Console.WriteLine($"Character HP: {charecterHP}");
            }
            else if (action == 3)
            {
                Console.WriteLine("You reload your ammo.");
            }
            else if (action == 4)
            {
                Console.WriteLine("You call for backup!");
            }
            else
            {
                Console.WriteLine("You win the game, but your friend killed you ");
            }
            


        }

    }
    
    
}


