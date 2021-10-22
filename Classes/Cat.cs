using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooLab.Classes
{
    public class Cat : Pet
    {
        public override string AnimalName { get; set; } = "Cat";
        public override string PetName { get; set; }
        public override bool CanDomesticated { get; set; } = true;
        public override void Sound()
        {
            Console.WriteLine("Meow Meow");
        }
        public override string FavFood { get; set; }
        public override bool CanSwim { get => base.CanSwim; set => base.CanSwim = value; }
    }
}