using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Cat("Jack", 3);
            var d1 = new Dog("Bool", 2);
            Speak(c1);
            Speak(d1);
        }
        static void Speak(Pet p)
        {
            Console.WriteLine(p);
            p.Speak();
        }
    }
    abstract class Pet
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Pet(string n,int a)
        {
            Name = n;
            Age = a;
        }
        public abstract void Speak();
        
        public override string ToString()
        {
            return Name;
        }
    }
    class Cat : Pet
    {
        public Cat(string n,int a):base(n,a)
        {

        }
        public override void Speak()
        {
            Console.WriteLine("MIAOMIAO");
        }
    }
    class Dog : Pet
    {
        public Dog(string n,int a):base(n,a)
        {

        }
        public override void Speak()
        {
            Console.WriteLine("WANGWANG");
        }
    }
}
