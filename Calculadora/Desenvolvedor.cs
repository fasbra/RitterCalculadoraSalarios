using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Desenvolvedor : ICargo
    {
        public decimal MaiorDesconto { get { return 0.20m; } }

        public decimal MenorDesconto { get { return 0.10m; } }

        public decimal ValorCorte { get { return 3000m; } }
    }
}
