using System;

namespace ReadLineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name:");
            String usrName = Console.ReadLine();
            Console.Write("Age:");
            int usrAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gender (M/F):");
            char usrGender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Name:" + usrName);
            Console.WriteLine("Age:" + usrAge);
            Console.WriteLine("Gender:" + usrGender);
        }
    }
}