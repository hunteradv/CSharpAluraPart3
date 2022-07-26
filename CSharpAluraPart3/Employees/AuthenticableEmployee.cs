using CSharpAluraPart3.Sistemas;

namespace CSharpAluraPart3.Funcionarios
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable 
    {
        public string Password { get; set; }

        public AuthenticableEmployee(double salary, string cpf) : base (salary, cpf)
        {

        }

        public bool Authenticate(string senha)
        {
            return Password == senha;
        }
    }
}
