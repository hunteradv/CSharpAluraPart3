using System;

namespace CSharpAluraPart3.Sistemas
{
    public class InternalSystem
    {
        public bool Login(IAuthenticable employee, string password)
        {
            bool authenticatedUser = employee.Authenticate(password);

            if (authenticatedUser)
            {
                Console.WriteLine("Bem vindo ao sistema interno");
                return true;
            }
            Console.WriteLine("Senha Incorreta!");
            return false;
        }
    }
}
