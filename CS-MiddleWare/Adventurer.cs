namespace CS_MiddleWare
{
    public class Adventurer
    {
        public Adventurer(string name, FightingClass fightingClass)
        {
            this.name = name;
            this.fightingClass = fightingClass;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int level { get; set; } = 1;
        public int xp { get; set; } = 0;

        public FightingClass fightingClass { get; set; }




    }
}
