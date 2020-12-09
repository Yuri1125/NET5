using System;

namespace NET5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class InitDemo
    {
        public string Name { get; init; }
        public int Age { get; init; }

        public InitDemo() { }
        public InitDemo(string name = "", int age = 0)
        {
            this.Name = name;
            this.Age = age;
        }

        public void ChangeName(string name)
        {
            // 这里再编译时会直接报错
            //this.Name = name;
        }
    }
}
