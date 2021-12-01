//Frederico Guilherme Camilli Proença RA:200925

using System;
using System.Globalization;

namespace POO_Aluguel_de_Carros
{
    class Program
    {
        //Programa principal com o qual o usuário interagirá.
        static void Main(string[] args)
        {
            //Frase mostrada ao iniciar o programa.
            Console.WriteLine("Entre com os dados da locação:");
            //Interação com o usuário perguntando-o sobre o modelo.
            Console.Write("Modelo: ");
            //Declaração e inserção da string modelo.
            string modelo = Console.ReadLine();
            //Interação com o usuário perguntando-o sobre a data de começo.
            Console.Write("Check-in (dd/MM/aaaa hs:mm): ");
            //Inserção do usuário sobre a data de começo.
            DateTime checkin = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Interação com o usuário perguntando-o sobre a data final.
            Console.Write("Check-out (dd/MM/aaaa hs:mm): ");
            //Inserção do usuário sobre a data final.
            DateTime checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Interação com o usuário perguntando-o sobre o preço por hora.
            Console.Write("Entre com o preço por hora: ");
            //Declaração e inserção do usuário sobre o preço por hora.
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Interação com o usuário perguntando-o sobre o preço por dia.
            Console.Write("Entre com o preço por dia: ");
            //Declaração e inserção do usuário sobre o preço por hora.
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Declaração de um AluguelCarro, classe que vem da pasta Entidades, tendo seus dados preenchidos anteriormente pelo usuário.
            Entidades.AluguelCarro aluguelCarro = new (checkin, checkout, new Entidades.Veiculo(modelo));
            //Declaração de um ServicoLocacao, classe que vem da pasta Servicos, tendo seus dados preenchidos anteriormente pelo usuário.
            Servicos.ServicoLocacao servicoLocacao = new (hora, dia, new Servicos.TaxaServicoBR());
            //Uso do método ProcessoFatura, encontrado em ServicoLocacao, para calcular a taxa a ser paga.
            servicoLocacao.ProcessoFatura(aluguelCarro);
            //Começo da exibição da fatura.
            Console.WriteLine("FATURA: ");
            //Exibição da fatura, com pagamento inicial, taxa aplicada, e pagamento final.
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
