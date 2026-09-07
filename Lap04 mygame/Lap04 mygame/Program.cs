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

            
            Console.WriteLine($"===== {GameTitle} =====");
            Console.WriteLine($"Hero Name   : {heroName}");
            Console.WriteLine($"Level       : {heroLevel}");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"Max HP      : {maxHp}");
            Console.WriteLine($"Crit Chance : {critChance}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Stamina     : {staminaElectric}");
            Console.WriteLine($"Playable    : {isPlayable}");
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
