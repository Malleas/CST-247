namespace VideoGameDIDemo
{
    internal class Sword :IWeapons
    {
        public string SwordName { get; set; }

        public Sword(string swordName)
        {
            SwordName = swordName;
        }

        public void Attack()
        {
            System.Console.WriteLine(SwordName + "slashes the enemy in half!");
        }
    }
}