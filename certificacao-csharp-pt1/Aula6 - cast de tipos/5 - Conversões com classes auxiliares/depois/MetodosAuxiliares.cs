using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";
            //int numeroConvertido = textoDigitado;

            int numeroConvertido = int.Parse(textoDigitado);
            Console.WriteLine(numeroConvertido);

            textoDigitado = "ABC";
            //numeroConvertido = int.Parse(textoDigitado);
            
            //Se o int.TryParse falhar, isso indica que o texto digitado não pode ser convertido para inteiro.
            if (int.TryParse(textoDigitado, out  numeroConvertido))
            {
                Console.WriteLine(numeroConvertido);
            }
            else
            {
                Console.WriteLine("Texto não é um número");
            }
            textoDigitado = "R$ 123,45";

            decimal.TryParse(textoDigitado, 
                System.Globalization.NumberStyles.Currency, //MOEDA
                System.Globalization.CultureInfo.CurrentCulture ,//PT-BR
                out decimal valorConvertido);
            Console.WriteLine(valorConvertido);
            
        }
    }
}
