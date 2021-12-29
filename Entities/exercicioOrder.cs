using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoNove.Entities.Enums;

namespace CSharpSecaoNove.Entities
{
    class ExercicioOrder
    {
        public static void ExecutarExercicioOrder()
        {
            Order orderOne = new Order
            {
                OrderId = 1080,
                OrderMoment = DateTime.Now,
                StatusOrder = OrderStatus.PendingPayment
            };

            Console.WriteLine("Imprimindo OrderOne: " + orderOne);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine("Convertendo OrderStatus(Enum) para string: " + txt);
            Console.WriteLine("Convertendo txt para Enum: " + os);
        }
    }
}