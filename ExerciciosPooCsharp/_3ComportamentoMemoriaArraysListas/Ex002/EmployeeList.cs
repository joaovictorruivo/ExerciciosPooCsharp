using ExerciciosPooCsharp._3ComportamentoMemoriaArraysListas.Ex001;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExerciciosPooCsharp._3ComportamentoMemoriaArraysListas.Ex002
{
    internal class EmployeeList
    {
        public static void Executar()
        {
            Console.Write("How many employees will be registred? ");
            int x = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Employee #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee funcio = list.Find(x => x.Id == searchId);
            if(funcio != null)
            {
                Console.Write("Enter the percentage: ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcio.IncreaseSalary(porcent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);

            }
        }
    }
}
