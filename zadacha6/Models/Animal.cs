using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6
{
    public class Animal
    {
        public int Id { get;set; }
        public string Name { get;set; }
        public int Age { get;set; } 
        public string Desc { get; set; }
        public Breed Breeds { get; set; } 
        public int BreedsId { get; set; }
    }
}
