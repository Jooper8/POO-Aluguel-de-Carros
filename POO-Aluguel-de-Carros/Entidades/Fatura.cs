using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aluguel_de_Carros.Entidades
{
    //Declaração da classe Fatura, presente no espaço POO_Aluguel_de_Carros.Entidades, que será utilizado em AluguelCarro e, consequentemente, no Programa principal.
    class Fatura
    {
        //Declaração da variável double Pagamento utilizando automatic properties.
        public double Pagamento { get; set; }
        //Declaração da variável double Taxa utilizando automatic properties.
        public double Taxa { get; set; }
        //Declaração do construtor desta classe, que será utilizado em ServicoLocacao.
        public Fatura(double aluguel, double taxa)
        {
            //Associação da variável Pagamento dessa classe com o aluguel que será definido pelo usuário através do programa principal.
            Pagamento = aluguel;
            //Associação da variável Taxa dessa classe com a taxa que será definido pelo usuário através do programa principal.
            Taxa = taxa;
        }
        //Declaração do método PagamentoTotal.
        public double PagamentoTotal
        {
            //Retorna o valor inserido mais a taxa.
            get { return Pagamento + Taxa; }
        }
        //Metódo para transformar dados em string.
        public override string ToString()
        {
            //Dados a serem retornados pelo método, que será utilizado no fim do programa principal.
            return "Pagamento Básico: "
            + Pagamento.ToString("F2", CultureInfo.InvariantCulture) //Dado inserido pelo usuário final.
            + "\nTaxa: "
            + Taxa.ToString("F2", CultureInfo.InvariantCulture) //Taxa calculada automaticamente pelo programa de acordo com os dados do usuário.
            + "\nPagamento Total: "
            + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture); //Valor final mostrado ao usuário calculado em PagamentoTotal.
        }
    }
}
