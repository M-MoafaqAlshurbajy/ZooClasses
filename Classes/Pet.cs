using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooLab.Classes
{
    public abstract class Pet : Mammal
    {
        public abstract string PetName { get; set; }
        public abstract string FavFood { get; set; }

    }
}