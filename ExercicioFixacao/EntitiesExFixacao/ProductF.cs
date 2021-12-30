using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoNove.ExercicioFixacao.Entities.Enum;

namespace CSharpSecaoNove.ExercicioFixacao.Entities
{
    class ProductF
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public ProductF()
        {

        }
        public ProductF(string externalProdName, double externalProdPrice)
        {
            ProductName = externalProdName;
            ProductPrice = externalProdPrice;
        }

    }
}