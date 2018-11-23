using Xunit;

namespace Calculadora.Test
{
    public class FuncitonarioTest
    {
        [Fact]
        public void Funcionario_Deve_Ser_Criado()
        {
            var nome = "Felipe";
            var salario = 1000m;
            var cargo = new Desenvolvedor();

            var funcionario = new Funcionario(nome, salario, cargo);

            Assert.Equal(nome, funcionario.Nome);
            Assert.Equal(salario, funcionario.Salario);
            Assert.Equal(cargo, funcionario.Cargo);
        }
    }
}
