using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aluguel_de_Carros.Servicos
{
    //Declaração da classe TaxaServicoBR, que utiliza a classe base ITaxaServico e está presente no espaço POO_Aluguel_de_Carros.Servicos, que será utilizado no Programa principal.
    class TaxaServicoBR : ITaxaServico
    {
        //Uso do método declarado em ITaxaServico.
        public double Taxa(double valor)
        {
            //Caso o valor inserido seja menor de 100.00, será utilizado este if.
            if (valor <= 100.00)
            {
                //Retorna o valor inserido multiplicado por um multiplicador desejado, que será a taxa cobrada no final do programa. Padrão = 0.2
                return valor * 0.2;
            }
            //Caso o requisito acima não seja verdadeiro, executar este abaixo.
            else
            {
                //Retorna o valor inserido multiplicado por um multiplicador desejado, que será a taxa cobrada no final do programa. Padrão = 0.15
                return valor * 0.15;
            }
        }
    }
}
