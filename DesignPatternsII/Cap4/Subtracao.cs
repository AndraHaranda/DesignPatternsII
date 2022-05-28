using DesignPatternsII.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap4
{
    public class Subtracao : IExpressao
    {
        public int Valor { get; private set; }
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direta { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
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
        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSubtracao(this);
        }
    }
}
