using CSharpAluraPart3.Sistemas;

namespace CSharpAluraPart3
{
    public class CommercialPartner : IAuthenticable
    {
        public string Password { get; set; }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
