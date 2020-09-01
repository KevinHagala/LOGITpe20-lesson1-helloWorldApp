using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello Kevin!");
            /*3.The program greets the user by their name*/
            /*2.The user enters their name*/
            /*"1.ask the user`s name "*/
            Console.WriteLine("What`s your name?");
            string Name;
            //read the input  from the user
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);
        }
    }
}