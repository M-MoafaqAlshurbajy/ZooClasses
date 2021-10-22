using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooLab.Classes
{
    public abstract class Mammal: Animal
    {
        // public override string Name { get; set; }
        public string Type = "Mammal";
        public virtual bool CanSwim { get; set; }
        public virtual bool CanFly { get; set; }
    }
}