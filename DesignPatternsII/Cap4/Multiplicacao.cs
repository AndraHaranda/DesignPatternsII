using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap4
{
     class Multiplicacao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direta { get; private set; }

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
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
