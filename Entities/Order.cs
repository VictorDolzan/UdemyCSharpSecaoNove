using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoNove.Entities.Enums;

namespace CSharpSecaoNove.Entities
{
    class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderMoment { get; set; }
        public OrderStatus StatusOrder { get; set; }

        

        public override string ToString()
        {
            return OrderId
            + ", "
            + OrderMoment
            + ", "
            + StatusOrder;
        }
    }
}