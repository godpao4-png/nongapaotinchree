namespace Lap04_mygame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "marvel spider man miles morales"; 

            var heroName = "miles morales";         
            int heroLevel = 39;
            int maxHp = 100;
            int currentHp = 275;
            float critChance = 2.15f;
            float attackPower = 12.30f;
            double staminaElectric = 50.5;  
            bool isPlayable = true;

            Console.WriteLine("<< \"=======================================================================\\n");
            Console.WriteLine("<<  \"  ____ ____ ___ ____  _____ ____    ____  ___   _   _   _   _ \\n");
            Console.WriteLine("<<  \" / ___|  _ \\_ _|  _ \\| ____|  _ \\\\  |  _ \\\\/ _ \\\\ | \\\\ | | / \\\\ | |\\");
            Console.WriteLine("<<  \" \\___ \\ |_) | || | | |  _| | |_) | | |_) | | | ||  \\\\| |/ _ \\\\| |\\n");
            Console.WriteLine(" << \"  ___) |  __/| || |_| | |___|  _ <  |  __/| |_| || |\\\\  / ___ \\\\_|\\n\"");
            Console.WriteLine(" << \" |____/|_|  |___|____/|_____|_| \\_\\ |_|    \\\\___/ |_| \\\\_/_/   \\\\_|\\n");
            Console.WriteLine(" << \" [ FRIENDLY NEIGHBORHOOD SPIDER-MAN HUD - MILES MORALES SYSTEM ]\\n");
            Console.WriteLine("<< \"=======================================================================\\n\\n\\");
           
           Console.WriteLine(" << \" | SPIDER-SUIT PROFILE                                                 |\n");  
            Console.WriteLine($" | >> HERO ALIAS  : Miles Morales (Spider-Man)                        \n");
            Console.WriteLine($" | >>Level       : {heroLevel}                                        \n        ");
            Console.WriteLine($" | >>Hp: {currentHp} / {maxHp}                                       \n        ");
            Console.WriteLine($" | >>Max HP      : {maxHp}                                            \n        ");
            Console.WriteLine($" | >>Crit Chance : {critChance}                                       \n        ");
            Console.WriteLine($" | >>Attack Power: {attackPower}                                      \n        ");
            Console.WriteLine($" | >>Stamina     : {staminaElectric}                                  \n        ");
            Console.WriteLine($" | >>Playable    : {isPlayable}                                                                  ");
            Console.WriteLine(" << \"---------------------------------------------------------------------------------------");
            Console.WriteLine();

            int hpPercentage = currentHp * 60 / maxHp;
            Console.WriteLine($"Hp Percentage: {hpPercentage}%");
            Console.WriteLine();

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHp = currentHp - 60;
            Console.WriteLine();

            double heroLevelAsDouble = heroLevel; 
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int staminachart = (int)staminaElectric;               
            int staminaRounded = Convert.ToInt32(staminaElectric);      
            Console.WriteLine($"Stamina cast (truncates)  : {staminachart}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
        }
    }
}
            