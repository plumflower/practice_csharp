using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QuadLibray;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Quad quad = new Quad(2.0, 3.0);
            Console.WriteLine("Area is: {0}", quad.GetQuadArea());

            Person person = new Person("Jack", 20);
            person.ID = 001;
            person.ShowPersonInfo();
            Console.WriteLine("person count:{0}", Person.count);
        }
    }

    public class Person
    {
        public int ID;
        protected int age;
        private string name;
        public static int count;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            count++;
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine("Name:{0}\t Age:{1}", name, age);
        }
    }
}
