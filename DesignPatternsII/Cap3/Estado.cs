using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap3
{
     class Estado
    {
        public Contrato Contrato { get; private set; }
        public Estado (Contrato contrato)
        {
            Contrato = contrato;
        }
    }
}
