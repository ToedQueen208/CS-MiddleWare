using CS_MiddleWare.Models;

namespace CS_MiddleWare.Services
{
    public class AdventurersService
    {
        private AdventurersModel model;

        public AdventurersService(AdventurersModel md)
        {
            model = md;
        }

        public List<Adventurer> GetAdventurers()
        {
            return model.GetAdventurers();
        }
    }
}
