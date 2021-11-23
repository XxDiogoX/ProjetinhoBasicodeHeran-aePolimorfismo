using HerancaePolimorfismo.Entitites;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();

            double totalvalue = 0 ;
            Console.WriteLine("Enter the number  of tax payers:");
            Console.Write("Number: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num;  i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.WriteLine("1 - Individual or 2 - company (1/2)?");
                Console.Write("Choice: ");
                int  choice = int.Parse(Console.ReadLine());
                if(choice == 1 )
                {
                    Console.WriteLine("Enter Name:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Anual income:");
                    Console.Write("Value: ");
                    double quantiy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Health expenditures:");
                    Console.Write("Value: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(health, name, quantiy));
                  
                }
                else if(choice == 2)
                {
                    Console.WriteLine("Enter Name:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Anual income:");
                    Console.Write("Value: ");
                    double quantiy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Number of employees:");
                    Console.Write("Employees: ");
                    int emplo = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(emplo, name, quantiy));
                   
                }
                else
                {
                    Console.WriteLine("Invalid Option!!");
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(Pessoa li in lista)
            {
                Console.WriteLine(li.ToString(), CultureInfo.InvariantCulture);
                totalvalue += li.CalculateTax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {totalvalue.ToString("F2", CultureInfo.InvariantCulture)}");
            
          

        }
    }
}
