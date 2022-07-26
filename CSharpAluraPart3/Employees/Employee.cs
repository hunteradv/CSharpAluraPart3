using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAluraPart3.Funcionarios
{
    public abstract class Employee
    {

        public static int TotalEmployees { get; private set; }
        public string Name { get; set; }
        public string CPF { get; private set; }
        public double Salary { get; protected set; }

        public Employee(double salary ,string cpf)
        {
            Console.WriteLine("Criando Funcionario");

            CPF = cpf;
            Salary = salary;

            TotalEmployees++;
        }


        public abstract void IncreaseSalary();

        public abstract double GetBonus();
    }
}
