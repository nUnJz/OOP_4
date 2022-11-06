using System;

namespace OOP_4_3
{
    class Worker
    {
        private string firstname;
        private string lastname;

        private double salary;
        private double bonus;
    }

    class SalesPerson : Worker
    {
        private double salesQuantity;
        
    }

    class Manager : Worker
    {

    }

    class Employer
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;


        }
    }
}