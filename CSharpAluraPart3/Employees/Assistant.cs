using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAluraPart3.Funcionarios
{
    public class Assistant : Employee
    {
        public Assistant (string cpf) : base (2000, cpf)
        {

        }

        public override void IncreaseSalary()
        {
            Salary *= 0.1;
        }

        public override double GetBonus()
        {
            return Salary * 0.20;
        }
    }
}
