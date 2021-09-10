using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            Cliente cliente = new Cliente("José da Silva", 30);
            
            Alimentar(animal); 
            Alimentar(gato);
            Alimentar(cliente);
        }

        public void Alimentar(object obj)
        {
            //"as" converte explicitamente a variável, quando a conversão não for possível o valor null é atribuido a variável
            //Animal animal = obj as Animal;
                
            //verificação do tipo is que é igual ao ==
            //retorno prematuro ou early return
            //o obj é um animal então insira o valor do obj dentro de animal
            if(obj is Animal animal)
            {   
                animal.Beber();
                animal.Comer();
                return;
            }
             Console.WriteLine("Obj não é um animal");
        }
    }
}
