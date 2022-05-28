using DesignPatternsII.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap5
{
    public class Impressora : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.WriteLine("(");
            soma.Esquerda.Aceita(this);
            Console.WriteLine("+");
            soma.Direita.Aceita(this);
            Console.WriteLine(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.WriteLine("(");
            subtracao.Esquerda.Aceita(this);
            Console.WriteLine("-");
            subtracao.Direta.Aceita(this);
            Console.WriteLine(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.WriteLine(numero.NumeroValor);
        }
    }
}
