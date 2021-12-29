using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoNove.ExercicioResolvido.EntitiesExercicio
{
    class Department
    {
        public string DepartmentName { get; set; }

        public Department()
        {            
        }
        public Department(string name)
        {
            DepartmentName = name;
        }
    }
}