using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap6
{
    public class MensagemPorEmail : IMensagem
    {
        private string nome;

        public MensagemPorEmail(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            Console.WriteLine("Enviando mensagem por e-mail");
            Console.WriteLine("Mensagem para o usuário {0}", nome);
        }
    }
}
