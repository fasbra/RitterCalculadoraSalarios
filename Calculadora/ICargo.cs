using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public interface ICargo
    {
        decimal MaiorDesconto { get; }
        decimal MenorDesconto { get; }
        decimal ValorCorte { get; }
    }
}
