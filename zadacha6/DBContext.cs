﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6
{
    public class DBContext : DbContext
    {
        public DBContext():base("DBContext")
        {

        }
       
       public  DbSet<Animal> Animals { get; set; }
       public DbSet<Breed> Breeds { get; set; }
    }
}
