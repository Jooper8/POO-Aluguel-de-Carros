using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aluguel_de_Carros.Servicos
{
    //Declaração da classe ServicoLocacao, que está presente no espaço POO_Aluguel_de_Carros.Servicos, que será utilizado no Programa principal.
    class ServicoLocacao
    {
        //Declaração da variável double PrecoPorHora utilizando automatic properties, sendo o set private, ou seja, só pode ser mudado dentro da própria classe.
        public double PrecoPorHora { get; private set; }
        //Declaração da variável double PrecoPorDia utilizando automatic properties, sendo o set private, ou seja, só pode ser mudado dentro da própria classe.
        public double PrecoPorDia { get; private set; }
        //Declaração privada, ou seja, apenas utilizavel dentro da própria classe, da ITaxaServico _taxaServico.
        private ITaxaServico _taxaServico;

        //Declaração do construtor desta classe, que será utilizado no Programa principal.
        public ServicoLocacao(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        {
            //Associação da variável PrecoPorHora dessa clase com a precoPorHora, que será preenchida pelo usuário através da variável hora no Programa principal.
            PrecoPorHora = precoPorHora;
            //Associação da variável PrecoPorDia dessa clase com a precoPorDia, que será preenchida pelo usuário através da variável dia no Programa principal.
            PrecoPorDia = precoPorDia;
            //Associação da variável _taxaServico privada dessa classe com a taxa que será calculada pelo programa.
            _taxaServico = taxaServico;
        }

        //Método utilizado para calcular a fatura.
        public void ProcessoFatura(Entidades.AluguelCarro aluguelCarro)
        {
            //Cálculo da duração da estadia do carro para ser utilizado futuramente.
            TimeSpan duracao = aluguelCarro.Checkout.Subtract(aluguelCarro.Checkin);
            //Declaração da variável pagamento, que calcula o valor que será cobrado ao usuário.
            double pagamento = 0.0;
            //Caso o total de horas seja menor que o valor desejado, será executado este if. 
            if (duracao.TotalHours <= 12.0)
            {
                //Calculo matemático do preço de acordo com o total de horas em qual o serviço foi usado.
                pagamento = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            //Caso contrário, esta ocasião será executada.
            else
            {
                //Calculo matemático do preço de acordo com o total de dias em qual o serviço foi usado.
                pagamento = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }
            //Declaração da double taxa e sua associação com o valor obtido via os calculos de _taxaServico.
            double taxa = _taxaServico.Taxa(pagamento);
            //Uso do construtor em Fatura para declarar suas variáveis.
            aluguelCarro.Fatura = new Entidades.Fatura(pagamento, taxa);
        }
    }
}
