using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            bool possuiSaldo = true;
            Console.WriteLine($"possui saldo: {possuiSaldo}");

            //pegando o dia atual
            int dia = DateTime.Now.Day;
            Console.WriteLine($"dia: {dia}");

            bool diasPar = (dia % 2 ==0);

            if(diasPar == true)
            {
                Console.WriteLine("O dia é um número par");
            }
            else
            {
                Console.WriteLine("O dia é impar");
            }
        }
    }
}