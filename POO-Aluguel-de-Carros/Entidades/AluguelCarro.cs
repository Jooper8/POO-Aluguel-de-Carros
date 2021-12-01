using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aluguel_de_Carros.Entidades
{
    //Declaração da classe AluguelCarro, presente no espaço POO_Aluguel_de_Carros.Entidades, que será utilizado em ServicoLocacao e no Programa principal.
    class AluguelCarro
    {
        //Declaração da variável DateTime Checkin utilizando automatic properties.
        public DateTime Checkin { get; set; }
        //Declaração da variável DateTime Checkout utilizando automatic properties.
        public DateTime Checkout { get; set; }
        //Declaração da variável Veiculo Veiculo utilizando automatic properties, sendo o set private, ou seja, só pode ser mudado dentro da própria classe.
        public Veiculo Veiculo { get; private set; }
        //Declaração da variável Fatura Fatura utilizando automatic properties.
        public Fatura Fatura { get; set; }

        //Declaração do construtor desta classe, que será utilizado em ServicoLocacao e no Programa principal.
        public AluguelCarro(DateTime checkin, DateTime checkout, Veiculo veiculo)
        {
            //Associação da variável Checkin dessa classe com o checkin que será definido pelo usuário através do programa principal.
            Checkin = checkin;
            //Associação da variável Checkout dessa classe com o checkout que será definido pelo usuário através do programa principal.
            Checkout = checkout;
            //Associação da variável Veiculo dessa classe com o veiculo que será definido pelo usuário através do programa principal.
            Veiculo = veiculo;
            //Declaração da Fatura como nula.
            Fatura = null;
        }
    }
}
