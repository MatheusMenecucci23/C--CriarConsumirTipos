using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57; 
             
            //fazendo um boxing: colocando o número dentro da caixa;
            object caixa = numero;

            Console.WriteLine(caixa);

            //concatenando
            Console.WriteLine(string.Concat("Resposta", numero, true));
        }
    }
}
