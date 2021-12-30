using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoNove.ExercicioFixacao.Entities;
using CSharpSecaoNove.ExercicioFixacao.Entities.Enum;

namespace CSharpSecaoNove.ExercicioFixacao
{
    class ExercicioFixacao
    {
        public static void ExecutarExercicioFixacao()
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string cName = Console.ReadLine();
            Console.Write("Email: ");
            string cEmail = Console.ReadLine();
            Console.Write("Birth date (MM/DD/YYYY):");
            DateTime cBirthDate = DateTime.Parse(Console.ReadLine());

            ClientF c1 = new ClientF(cName, cEmail, cBirthDate);

            Console.WriteLine("Enter order Data: ");
            Console.Write("Status : ");
            OrderStatus os1 = Enum.Parse<OrderStatus>(Console.ReadLine());           

            OrderF o1 = new OrderF(DateTime.Now, os1, c1);

             Console.Write("How many ietms to this order: ");
            int qItems = int.Parse(Console.ReadLine());

            for(int cont1 = 1; cont1 <= qItems; cont1++)
            {
                Console.WriteLine($"Enter #{cont1} tem data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product Price: ");
                double prodPrice = double.Parse(Console.ReadLine());

                ProductF prod = new ProductF(prodName, prodPrice);
                Console.Write("Quantity: ");

                int qntProd = int.Parse(Console.ReadLine());

                
                OrderItemF orderItems = new OrderItemF(qntProd,prodPrice, prod);
                o1.AddItem(orderItems);
            }

            Console.WriteLine();
            Console.Write("ORDER SUMMARY: ");
            Console.WriteLine(o1);
           

        }
    }
}