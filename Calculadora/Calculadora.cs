namespace Calculadora
{
    public class Calculadora
    {
        private Funcionario _funcionario;

        public Calculadora(Funcionario funcionario)
        {
            _funcionario = funcionario;
        }

        public decimal CalculaDesconto()
        {
            var salario = _funcionario.Salario;
            var cargo = _funcionario.Cargo;

            return salario * (salario > cargo.ValorCorte ? cargo.MaiorDesconto : cargo.MenorDesconto);
        }

    }
}