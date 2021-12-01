using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aluguel_de_Carros.Entidades
{
    //Declaração da classe Veiculo, presente no espaço POO_Aluguel_de_Carros.Entidades, que será utilizado no Programa principal.
    class Veiculo
    {
        //Declaração da variável string Modelo utilizando automatic properties.
        public string Modelo { get; set; }
        //Declaração do construtor desta classe.
        public Veiculo(string modelo)
        {
            //Associação da variável Modelo dessa classe com o modelo que será definido pelo usuário através do programa principal.
            Modelo = modelo;
        }
    }
}
