using CSharpAluraPart3.Funcionarios;
using CSharpAluraPart3.Sistemas;
using System;

namespace CSharpAluraPart3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            CalculateBonus();

            Console.ReadLine();
        }

        public static void UseSystem()
        {
            InternalSystem internalSystem = new InternalSystem();

            Director roberta = new Director("833.222.048-39");
            roberta.Name = "Roberta";
            roberta.Password = "123";

            AccountManager camila = new AccountManager("833.222.048-39");
            camila.Name = "Camila";
            camila.Password = "abc";

            CommercialPartner partner = new CommercialPartner();
            partner.Password = "1234";


            internalSystem.Login(roberta, "123");
            internalSystem.Login(camila, "abc");
            internalSystem.Login(partner, "1234");

        }

        public static void CalculateBonus()
        {
            BonusManager bonusManager = new BonusManager();

            Employee pedro = new Designer("833.222.048-39");
            pedro.Name = "Pedro";

            Employee roberta = new Director("833.222.048-39");
            roberta.Name = "Roberta";

            Employee igor = new Assistant("833.222.048-39");
            igor.Name = "Igor";

            Employee camila = new AccountManager("833.222.048-39");
            camila.Name = "Camila";

            Employee gustavo = new Developer("499.576.508-58");
            gustavo.Name = "Gustavo";

            bonusManager.Register(pedro);
            bonusManager.Register(roberta);
            bonusManager.Register(igor);
            bonusManager.Register(camila);
            bonusManager.Register(gustavo);


            Console.WriteLine("Total de bonificações do mês: " + bonusManager.GetTotalBonus());
        }
    }
}
