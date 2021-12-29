using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoNove.ExercicioResolvido.EnumsExercicio;

namespace CSharpSecaoNove.ExercicioResolvido.EntitiesExercicio
{
    class Worker
    {
        public string WorkerName { get; set; }
        public WorkerLevel LevelWorker { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {

        }
        public Worker(string externalWorkerName, WorkerLevel externalWorkerLevel, double externalBaseSalary, Department externalDepartment)
        {
            WorkerName = externalWorkerName;
            LevelWorker = externalWorkerLevel;
            BaseSalary = externalBaseSalary;
            Department = externalDepartment;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}