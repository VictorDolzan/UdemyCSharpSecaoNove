using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//using CSharpSecaoNove.Entities;
//using CSharpSecaoNove.Entities.Enums;
using CSharpSecaoNove.ExercicioResolvido.EntitiesExercicio;
using CSharpSecaoNove.ExercicioResolvido.EnumsExercicio;

namespace CSharpSecaoNove.ExercicioResolvido
{
    class ExercicioExecutavel
    {
        public static void ExecutarExercicioResolvido()
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string nameWorker = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLev = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double workerSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
            Department dept = new Department(deptName);
            Worker worker1 = new Worker(nameWorker, workerLev, workerSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int totalContracts = int.Parse(Console.ReadLine());

            for(int cont = 1; cont <= totalContracts; cont++)
            {
                Console.WriteLine($"Enter #{cont} contract data: ");
                Console.Write("Date (MM/DD/YYYY): ");
                DateTime dateContract = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int durationHours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(dateContract, hourValue, durationHours);
                worker1.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring( 0, 2 ));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker1.WorkerName);
            Console.WriteLine("Department: " + worker1.Department.DepartmentName);
            Console.WriteLine("Income: " + monthAndYear + ": " + worker1.Income(year, month));
            
        }
    }
}