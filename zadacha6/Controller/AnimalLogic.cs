using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6.Controller
{
    internal class AnimalLogic
    {
        private DBContext animalContext = new DBContext();
        public List<Animal> GetALL()
        {
            using (animalContext = new DBContext())
            {
                List<Animal> listAnimals = animalContext.Animals.ToList();
                return listAnimals;
            }
        }
        public Animal Get(int id)
        {
            using (animalContext = new DBContext())
            {
                Animal foundAnimal = animalContext.Animals.Find(id);
                if (foundAnimal != null)
                {
                    animalContext.Entry(foundAnimal).Reference(x => x.Breeds).Load();
                }
                return foundAnimal;
            }

        }
        public void Create(Animal animal)
        {
            using (animalContext = new DBContext())
            {
                animalContext.Animals.Add(animal);
                animalContext.SaveChanges();

            }
        }
        public void Update(int id, Animal animal)
        {
            Animal foundAnimal = animalContext.Animals.Find(id);
            if (foundAnimal == null)
            {
                return;
            }
            foundAnimal.Age = animal.Age;
            foundAnimal.Name = animal.Name;
            foundAnimal.BreedsId = animal.BreedsId;
            animalContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Animal foundAimal = animalContext.Animals.Find(id);
            animalContext.Animals.Remove(foundAimal);
            animalContext.SaveChanges();
        }
    }
}
