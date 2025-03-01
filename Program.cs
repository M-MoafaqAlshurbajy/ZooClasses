using System;
using ZooLab.Classes;

namespace ZooLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat MeshMesh = new Cat()
            {
                PetName = "MeshMesh",
                FavFood = "Fish",
                CanSwim = true
            };
            
            Console.WriteLine(MeshMesh.AnimalName);
            Console.WriteLine(MeshMesh.PetName);
            Console.WriteLine(MeshMesh.Type);
            MeshMesh.Sound();

            Bird ProfessorTweet = new Bird() { 
            PetName="Professor Tweet",
            FavFood= "Worm sanswich deluxe"// ساندويش الدودة الفاخر
            };
            Console.WriteLine();
            Console.WriteLine($"Bird Name : {ProfessorTweet.PetName}");
            Console.WriteLine($"Favorite food : {ProfessorTweet.FavFood}");
            Console.Write("Sound : ");
            ProfessorTweet.Sound();

        }
    }
}
