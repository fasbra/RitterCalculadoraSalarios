using Xunit;

namespace Calculadora.Test
{
    public class CalculadoraTest
    {
        [Fact]
        public void Calculadora_Deve_Gerar_Desconto_Desenvolvedor()
        {
            var funcionario = new Funcionario("Felipe", 1000m, Cargo.Desenvolvedor);

            var calculadora = new Calculadora(funcionario);
        }
    }
}
