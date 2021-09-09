using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            //criando um eletrodomestcio qualquer e instanciando ele com uma tv
            IEletrodomestico eletro1 = new Televisao();
            //liguei A TV
            eletro1.Ligar();
            //trocando a TV por uma abajur
            eletro1 = new Abajur();
            //LIGANDO O ABAJUR
            eletro1.Ligar();
        }
    }


    interface IEletrodomestico
    {
        void Ligar();
        void Desligar();
    }

    interface Ilumincação
    {
        double PotenciaDaLampada { get; set; }
    }


    //IMPLEMENTANDO UMA INTERFACE COM : 
    class Televisao : IEletrodomestico
    {
        public void Desligar()
        {
            Console.WriteLine("TV Desligado");
        }

        public void Ligar()
        {
              Console.WriteLine("TV Ligado");
        }
    }

    class Abajur : IEletrodomestico, Ilumincação
    {
        public double PotenciaDaLampada { get; set; }

         public void Desligar()
        {
            Console.WriteLine("Abjur Desligado");
        }

        public void Ligar()
        {
              Console.WriteLine("Abajur Ligado");
        }
    }

    class Lanterna : IEletrodomestico, Ilumincação
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
            Console.WriteLine("Lanterna Desligado");
        }

        public void Ligar()
        {
              Console.WriteLine(" Lanterna Ligado");
        }
    }

    class Radio : IEletrodomestico
    {
        public void Desligar()
        {
            Console.WriteLine("Radio Desligado");
        }

        public void Ligar()
        {
              Console.WriteLine("Radio Ligado");
        }
    }
}
