using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap6
{
    public interface IEnviador
    {
        void Envia(IMensagem);
    }
}
