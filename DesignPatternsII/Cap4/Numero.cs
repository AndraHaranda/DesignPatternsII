using DesignPatternsII.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap4
{
    public class Numero : IVisitor
    {
        public int NumeroValor { get; set; }
        public Numero(int numero)
        {
            this.NumeroValor = numero;
        }

        public int Avalia()
        {
            return this.NumeroValor;
        }
        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }
    }
}
