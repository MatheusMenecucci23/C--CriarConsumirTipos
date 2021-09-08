using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Estruturas : IAulaItem
    {
        public void Executar()
        {
            double Latitude1 = 13.78;
            double Longitude1 = 29.51;
            double Latitude2 = 40.23;
            double Longitude2 = 17.4;
            Console.WriteLine($"Latitude1 = {Latitude1}");
            Console.WriteLine($"Longitude1 = {Longitude1}");
            Console.WriteLine($"Latitude2 = {Latitude2}");
            Console.WriteLine($"Longitude2 = {Longitude2}");


            PosicaoGPS posicao1;
            posicao1.Latitude = 13.78;
            posicao1.Longitude = 29.51;

            //CRIANDO UMA POSIÇÃOGSP COM NEW
            posicao1 = new PosicaoGPS(13.78, 29.51);
            Console.WriteLine(posicao1);
            Console.WriteLine(posicao1.EstaNoHemisferioNorte());
        }
    }
    interface IGPS
    {
        bool EstaNoHemisferioNorte();
    }

    //criando uma variavel do tipo struct

    struct PosicaoGPS: IGPS
    {
        //iniciando e definindo valores
        public double Latitude;
        public double Longitude;

        //CONTRUTOR COM PARAMETRO
        public PosicaoGPS(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        //método de implementaçaõ de interface
        public bool EstaNoHemisferioNorte()
        {
           return Latitude > 0;
        }

        //colocando um método que retorna uma saída 
        public override string ToString()
        {
            return $"Latitude:{Latitude}, Longitude:{Longitude}";
        }
    }
}
