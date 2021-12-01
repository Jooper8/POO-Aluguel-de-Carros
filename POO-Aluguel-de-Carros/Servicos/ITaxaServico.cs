using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aluguel_de_Carros.Servicos
{
    //Declaração da interface ITaxaServico, presente no espaço POO_Aluguel_de_Carros.Servicos, que será utilizado em TaxaServicoBR e, consequentemente, no Programa principal.
    interface ITaxaServico
    {
        //Declaração do método Taxa, no qual se insere o double valor, que é utilizado para calcular o valor do pagamento final.
        double Taxa(double valor);
    }
}
