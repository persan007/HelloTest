using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Dog
    {
        private string name;

        public string Name { get; set; }

        public Dog(string name_)
        {
            Name = name_;
        }

        public string Describe()
        {
            return "Hello, I'm a dog and my name is " + this.Name;
        }
    }
}
