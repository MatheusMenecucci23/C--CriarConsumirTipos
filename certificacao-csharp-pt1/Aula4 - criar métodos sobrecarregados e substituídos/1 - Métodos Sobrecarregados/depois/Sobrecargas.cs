using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;
             
            Console.WriteLine("VolumeDoCubo: " + Volume(lado));

            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;

            Console.WriteLine("VolumeDoCilindro: "+Volume(raio,altura));

            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;

            Console.WriteLine("VolumeDoPrisma: " + Volume(largura,altura,profundidade));
        }

          //criando um método
          double Volume(double lado)
          {
             return  Math.Pow(lado, 3);
          }

        double Volume(double raio, double altura)
        {
                return altura * Math.PI * Math.Pow(raio,2);
        }
        double Volume(double largura, double altura, double profundidade)
        {
            return largura * altura * profundidade;
        }

    }
   
}
