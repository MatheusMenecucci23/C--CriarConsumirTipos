using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            
            int inteiro = 2_123_456_789;
            long inteiroLongo = inteiro;
            Console.WriteLine(inteiroLongo);

            //não é possível fazer essa subtituição, pois o inteiro longo é muito grande para o ficar dentro do inteiro;
            //inteiro = inteiroLongo;


            //as copias sempre pegarão os tipos de suas bases, no caso a base é gato;
            Gato gato = new Gato();
            Animal animal = gato;
            //gato = animal;
            Console.WriteLine(animal.GetType());

            IAnimal Ianimal = gato;
            Console.WriteLine(Ianimal.GetType());
        }
    }
}

