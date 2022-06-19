using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Class1 reliance = new Class1("Dmart",20,20,100);
            reliance.computeEmpWage();

            Class1 Dmart = new Class1("Dmart", 20, 20, 100);
            Dmart.computeEmpWage();



        }

    }
}
