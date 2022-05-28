using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap6
{
    public class MensagemPorSMS
    {
        private string nome;

        public MensagemPorSMS(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            Console.WriteLine("Enviando mensagem por SMS");
            Console.WriteLine("Mensagem para o usuário {0}", nome);
        }
    }
}
