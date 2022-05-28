using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap4
{
    public class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direta { get; private set; }

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direta = direita;
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direta.Avalia();
            return resultadoDaEsquerda - resultadoDaDireita;
        }
    }
}
