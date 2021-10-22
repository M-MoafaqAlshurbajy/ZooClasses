using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooLab.Classes
{
    public abstract class Animal
    {
        public abstract string AnimalName { get; set; }
        public abstract bool CanDomesticated { get; set; }
        public abstract void Sound();

    }
}