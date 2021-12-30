using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoNove.ExercicioFixacao.Entities.Enum;

namespace CSharpSecaoNove.ExercicioFixacao.Entities
{
    class OrderF 
    {
        public DateTime OrderMoment { get; set; }
        public OrderStatus StatusOrder { get; set; }
        public List<OrderItemF> ItemsOrder { get; set; } = new List<OrderItemF>();
        public ClientF ClientOrder { get; set; }

        public OrderF()
        {

        }
        public OrderF(DateTime externalMoment, OrderStatus externalStatus, ClientF externalClient)
        {
            OrderMoment = externalMoment;
            StatusOrder = externalStatus;
            ClientOrder = externalClient;
        }
        public void AddItem( OrderItemF item)
        {
            ItemsOrder.Add(item);
        }
        public void RemoveItem(OrderItemF item)
        {
            ItemsOrder.Remove(item);
        }
        public double TotalOrder()
        {
            double sum = 0.0;
            foreach(OrderItemF os in ItemsOrder)
            {                
                sum += os.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + OrderMoment.ToString("MM/dd/yyyy HH:mm:ss "));
            sb.AppendLine("Order Status: " + StatusOrder);
            sb.AppendLine("Client: " + ClientOrder);
            sb.AppendLine("Order Items : ");
            foreach(OrderItemF item in ItemsOrder)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + TotalOrder().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
       
    }
}