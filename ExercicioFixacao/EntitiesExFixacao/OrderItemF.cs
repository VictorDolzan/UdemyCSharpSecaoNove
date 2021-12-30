using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoNove.ExercicioFixacao.Entities.Enum;

namespace CSharpSecaoNove.ExercicioFixacao.Entities
{
    class OrderItemF
    {
        public int QuantityOrder { get; set; }
        public double PriceOrder { get; set; }
        public ProductF product { get; set; }

        public OrderItemF()
        {

        }
        public OrderItemF(int externalQuantityOrder, double externalPriceOrder, ProductF externalProduct)
        {
            QuantityOrder = externalQuantityOrder;
            PriceOrder = externalPriceOrder;
            product = externalProduct;
        }

        public double SubTotal()
        {
            PriceOrder = product.ProductPrice;

            return PriceOrder * QuantityOrder;
        }

         public override string ToString()
        {
            return product.ProductName
                + ", $"
                + PriceOrder.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + QuantityOrder
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }     
        
    }
}