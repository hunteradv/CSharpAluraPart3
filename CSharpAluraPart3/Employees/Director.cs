using System;

namespace CSharpAluraPart3.Funcionarios
{
    public class Director : AuthenticableEmployee
    {

        public Director(string cpf) : base (5000, cpf)
        {
            Console.WriteLine("Criando diretor");

        }

        public override double GetBonus()
        {
            return Salary * 0.5;
        }

        public override void IncreaseSalary()
        {
            Salary *= 1.15;
        }
    }
}
