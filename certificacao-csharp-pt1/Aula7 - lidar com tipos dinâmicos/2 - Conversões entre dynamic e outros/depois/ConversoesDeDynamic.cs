using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            //dymanic pode receber qualquer tipo de variável
            dynamic d1 = 7;
            dynamic d2 = "essa é uma string qualquer";
            dynamic d3 = DateTime.Now;
            dynamic d4 = new List<int>() { 123, 456, 789 };

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            //eu posso converter um dynamic para um tipo estatico, desde que o tipo seja compatível
            int i = d1;
            string str = d2;
            DateTime dt = d3;
            List<int> lista = d4;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            //Erro de tempo de execução! não é possível converter string em int
            //int inteiro = d2;
        }
    }
}
