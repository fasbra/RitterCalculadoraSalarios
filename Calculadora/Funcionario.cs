namespace Calculadora
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public decimal Salario { get; private set; }
        public Cargo Cargo { get; private set; }

        public Funcionario(string nome, decimal salario, Cargo cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }
    }
}
