using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6.Controller
{
    public class BreedLogic
    {
        private DBContext animalContext = new DBContext();

        public List<Breed> GetAllBreeds()
        {
            return animalContext.Breeds.ToList();
        }
        public string GetBreedById(int id)
        {
            return animalContext.Breeds.Find(id).BreedName;
        }

    }
}
