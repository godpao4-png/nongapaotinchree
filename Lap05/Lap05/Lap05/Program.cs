namespace Lap05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==>> helldivers <<==");
            Console.WriteLine("Hero vs monster --Calculate Damage");
           
            // Input hero's HP and ATK
            Console.WriteLine("hero HP: ");
            bool heroHp = int.TryParse(Console.ReadLine(), out int HeroHp);
            Console.WriteLine("hero ATK: ");
            bool heroAtk = int.TryParse(Console.ReadLine(), out int HeroAtk);
            Console.WriteLine("hero defense: ");
            bool heroDef = int.TryParse(Console.ReadLine(), out int HeroDef);
            // Input monster's HP and ATK
            Console.WriteLine("\nMonster HP: ");
            bool monsterHp = int.TryParse(Console.ReadLine(), out int MonsterHp);
            Console.WriteLine("Monster ATK: ");
            bool monsterAtk = int.TryParse(Console.ReadLine(), out int MonsterAtk);
           Console.WriteLine("Monster defense: ");
            bool monsterDef = int.TryParse(Console.ReadLine(), out int MonsterDef);

            bool heroImputValid = heroHp && heroAtk && heroDef;
            bool monsterInputValid = monsterHp && monsterAtk && monsterDef;
            Console.WriteLine($">> Hero stats valid: {heroImputValid}");
            Console.WriteLine($">> Monster stats valid: {monsterInputValid}");
            Console.WriteLine($"[HERO] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monsterHp}, ATK: {monsterAtk}, DEF: {monsterDef}");

            //HERO DRINKS POTION BEFORE THE FIGHT
            int potionHeal = 20;
            HeroHp += potionHeal;
            Console.WriteLine($"\nHERO drinking a potion, healing {potionHeal} HP, new HP: {HeroHp}");

            int normalDamage = Math.Max(1, HeroAtk - MonsterDef);
            Console.WriteLine($"Normal damage dealt: {normalDamage}DMG");

            int powerDamage = Math.Max(1, (int)(HeroAtk * 1.5) - MonsterDef);
            Console.WriteLine($"Power damage attack dealt: {powerDamage}DMG");

            int counterDamage = Math.Max(1, MonsterAtk - HeroDef);
            Console.WriteLine($"Counter attack damage dealt: {counterDamage}DMG");
            
            // Random damage calculation
            Random rangSometing = new Random();
            int roll = rangSometing.Next(0, 10);
            bool isCritical = roll < 3; // 30% chance for critical hit
            int criDamage = normalDamage + Convert.ToInt32(isCritical ? normalDamage * 0.5 : 0);
            Console.WriteLine($"Critical damage roll: {roll}, crit?: {isCritical} DMG");
            Console.WriteLine($"IF crit, normal attack would deal: {criDamage}DMG");




        }
    }
}
