using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    //representante dos métodos
    delegate double MetodoMultiplicacao(double input);

    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }

        static double Triplicar(double input)
        {
            return input * 3;
        }

        public static void Executar()
        {

            //Executa diretamente o método
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

            //a variável metodoMultiplicacao virou o delegate MetodoMultiplicacao
            MetodoMultiplicacao metodoMultiplicacao;

            metodoMultiplicacao = Duplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));

            //Executa diretamente o método
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            metodoMultiplicacao = Triplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));

            //instanciando um delegate com um método anônimo
            MetodoMultiplicacao metodoQuadrado = delegate (double input)
            {
                return input * input;
            };

            double quadrado = metodoQuadrado(5);
            //Console.WriteLine($"Quadrado: {quadrado}")
            Console.WriteLine("Quadrado: {0}", quadrado);

            //instancia um delegado com uma expressão lambda - tipo uma arrowfunction-
            MetodoMultiplicacao metodoCubo = input => input * input * input;
        
            double cubo = metodoCubo(4.375);

            Console.WriteLine("Cubo: {0}", cubo);
        }
    }
}
