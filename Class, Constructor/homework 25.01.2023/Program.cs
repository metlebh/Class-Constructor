using System;

namespace homework_25._01._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dog = new Animal();     ////////////Task1
            //dog.name = "Max";
            //dog.color = "Black";
            //dog.breed = "Haski";
            //dog.age = 2;
            //dog.AnimalDetail();

            //Console.WriteLine(dog.AnimalDetail());


            var Building1 = new Building("Building1", 100, 20);
            //Console.WriteLine(Building1.GetVolume());
            Console.WriteLine(Building1.GetInfo());


        }
    }
}
