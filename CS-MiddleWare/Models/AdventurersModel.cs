namespace CS_MiddleWare.Models
{
    public class AdventurersModel
    {
        private MyAdventureDBContext db;

        public AdventurersModel(MyAdventureDBContext database)
        {
            db = database;
        }

        public List<Adventurer> GetAdventurers()
        {

            return db.adventurers.ToList();

        }

        public Adventurer AddAdventurer(Adventurer ad)
        {
            // return null;
             db.adventurers.Add(ad);
            db.SaveChanges();
            return ad;
        
        }

    }
}
