using DesignPatternsII.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap4
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda + resultadoDaDireita;
        }
        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSoma(this);
        }
    }
}
