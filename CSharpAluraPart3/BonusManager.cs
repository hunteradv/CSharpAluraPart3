using CSharpAluraPart3.Funcionarios;

namespace CSharpAluraPart3
{
    public class BonusManager
    {
        private double _totalbonus;

        public void Register(Employee employee)
        {
            _totalbonus += employee.GetBonus();
        }

        public double GetTotalBonus()
        {
            return _totalbonus;
        }
    }
}
