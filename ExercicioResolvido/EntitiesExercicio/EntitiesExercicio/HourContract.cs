using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoNove.ExercicioResolvido.EntitiesExercicio
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {            
        }

        public HourContract(DateTime externalDate, double valueHour, int externarlHour)
        {
            Date = externalDate;
            ValuePerHour = valueHour;
            Hours = externarlHour;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour; 
        }
    }
}