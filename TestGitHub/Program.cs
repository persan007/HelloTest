using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //New branch
            Dog dogy = new Dog("Bulldog");
            dogy.Name = "Tax";
            
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Fido"));
            dogs.Add(new Dog("Bob"));
            dogs.Add(new Dog("Adam"));
            dogs.Add(dogy);

            foreach (Dog dog in dogs)
                Console.WriteLine(dog.Describe());

            Console.ReadKey();
        }
            
    }
}
