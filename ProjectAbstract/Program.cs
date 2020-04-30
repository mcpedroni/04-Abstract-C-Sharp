using System;
using System.Globalization;
using System.Collections.Generic;
using ProjectAbstract.Entities;

namespace ProjectAbstract {

    class Program {

        static void Main(string[] args) {

            List<TaxPayer> listTaxPayer = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Tax payer #" + i + " data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listTaxPayer.Add(new Individual(name, annualIncome, healthExp));
                } else {
                    Console.Write("Number of employees: ");
                    int numEmployees = int.Parse(Console.ReadLine());
                    listTaxPayer.Add(new Company(name, annualIncome, numEmployees));
                }                
            }
            Console.WriteLine();
            double totalTaxes = 0.0;

            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer tp in listTaxPayer) {
                double tax = tp.Tax();
                Console.WriteLine(tp.name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
