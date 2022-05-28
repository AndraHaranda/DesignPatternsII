using DesignPatternsII.Cap1;
using DesignPatternsII.Cap2;
using DesignPatternsII.Cap3;
using DesignPatternsII.Cap4;
using DesignPatternsII.Cap7;
using DesignPatternsII.Cap8;
using DesignPatternsII.Cap9;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace DesignPatternsII
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TesteAntigos
            #region
            //Padrão Factory
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela;";


            //FlyWeight
            NotasMusicas notas = new NotasMusicas();
            Piano piano = new Piano();
            IList<INota> doReMiFa = new List<INota>() {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa"),

                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("re"),
                notas.Pega("re"),

                notas.Pega("do"),
                notas.Pega("sol"),
                notas.Pega("fa"),
                notas.Pega("mi"),
                notas.Pega("mi"),
                notas.Pega("mi"),

                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa")
            };
            piano.Toca(doReMiFa);


            //Memento
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now, "Andra", TipoContrato.Novo);
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine(c.Tipo);

            ////Interpreter
            //IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            //IExpressao direita = new Soma(new Numero(2), new Numero(10));

            //IExpressao conta = new Soma(esquerda, direita);

            //int resultado = conta.Avalia();
            //Console.WriteLine(resultado);
        
            //Command
            Pedido pedido1 = new Pedido("Mauricio", 150.0);
            Pedido pedido2 = new Pedido("Marcelo", 250.0);

            FilaDeTrabalho fila = new FilaDeTrabalho();

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();

            //Adapter
            Cliente cliente = new Cliente();
            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            XmlSerializer serializer = new XmlSerializer(cliente.GetType());
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, cliente);
            String xml = writer.ToString();

            #endregion

            //Façade
            String cpf = "1234";
            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            Fatura fatura = new Fatura(cliente, valor);

            Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
            cobranca.Emite();

            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();

        }
    }
}