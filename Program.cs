using System;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
          DiggersAndFliers fullList = new DiggersAndFliers();


            fullList.DiggingAnimals().ForEach(digAnimal =>
            Console.WriteLine($" the {digAnimal} is walking")  );


 fullList.SwimmingAnimals().ForEach(animal => Console.WriteLine($" the {animal} is swimming"));

        }
    }
}
