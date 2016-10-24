using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            if (File.Exists("test.txt"))
            {
                string content = File.ReadAllText("test.txt");
                Console.WriteLine("Följande text finns på filen:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Skriv in något nytt i filen:");
            string newContent = Console.ReadLine();
            while (newContent != "exit")
            {
                File.AppendAllText("test.txt", newContent + Environment.NewLine);
                newContent = Console.ReadLine();
            }
        }
            
    }
}
