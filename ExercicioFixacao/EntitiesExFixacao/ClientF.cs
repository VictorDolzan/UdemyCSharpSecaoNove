using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoNove.ExercicioFixacao.Entities.Enum;

namespace CSharpSecaoNove.ExercicioFixacao.Entities
{
    class ClientF
    {
        public string NameClient { get; set; }
        public string EmailCliente { get; set; }
        public DateTime BirthDateCliente { get; set; }

        public ClientF()
        {

        }
        public ClientF(string externalName, string externalEmail, DateTime externalBirthDate)
        {
            NameClient = externalName;
            EmailCliente = externalEmail;
            BirthDateCliente = externalBirthDate;
        }

        public override string ToString()
        {
            return NameClient
            + ", ("
            + BirthDateCliente.ToString("MM/dd/yyyy")
            + ") - "
            + EmailCliente;
        }
                
    }
}