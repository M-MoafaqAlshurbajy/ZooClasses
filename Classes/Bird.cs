using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooLab.Classes
{
    public class Bird : Pet
    {
        public override string AnimalName { get; set; } = "Bird";
        public override string PetName { get; set; }
        public override bool CanDomesticated { get; set; } = true;

        public override void Sound()
        {
           // Console.WriteLine("Tweet Tweet");
            Console.WriteLine("Dinosaur whisper");//åãÓÉ ÇáÏíäÇÕæÑ 
        }
        public override string FavFood { get; set; }
        public string feathers { get; set; }
        public override bool CanFly { get => base.CanFly; set => base.CanFly = value; }
    }
}