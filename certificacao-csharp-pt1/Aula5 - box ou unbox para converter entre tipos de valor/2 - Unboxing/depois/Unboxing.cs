using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;      // tipo de valor

            object caixa = numero; // boxing;

            try
            {
                int unboxed = (int)caixa;

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)// quando o cast der errado entre nesse e bloco e atribua o erro ao "e"
            {
                System.Console.WriteLine("{0} Erro: Unboxing incorreto", e.Message);
            }

          

        }
    }
}
