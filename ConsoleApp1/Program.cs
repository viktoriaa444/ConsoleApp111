using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        string name1 =Console.ReadLine();
        string shortName1 = Console.ReadLine();
        int number1 = Convert.ToInt32(Console.ReadLine());
        int yearAdmission1 = Convert.ToInt32(Console.ReadLine());

        dynamic t = new GroupObject(name1, shortName1, number1, yearAdmission1);
       
        Console.WriteLine(t);
    }

}
