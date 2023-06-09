using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6
{
     public class Breed
    {
        public int Id { get; set; }
        public string BreedName { get; set; }
        public ICollection<Animal> Animals { get; set; }
        
    }
}
