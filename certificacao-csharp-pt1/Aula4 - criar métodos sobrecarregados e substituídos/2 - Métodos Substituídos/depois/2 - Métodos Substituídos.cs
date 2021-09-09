using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosSubstituidos : IAulaItem
    {
        public void Executar()
        {
          
            //gato é do tipo animal - classe base -  logo, os métodos da classe base serão chamados 
            Animal gato = new Gato() { Nome = "Bichano" };
            gato.Beber();//os métodos da classe base que serão chamados
            gato.Andar();
            //aqui, o método da classe gato será executado, pois no método do animal tem um virtual e no método gata tem um override
            //Com os modificadores vitrual e override o método é substituido
            gato.Comer();

            Console.WriteLine();
            
            //gata é do tipo gato, sendo assim, os método da classe gato serão chamados
            Gato gata = new Gato() { Nome = "Panntera" };
            gata.Beber();
            gata.Comer();
            gata.Andar();

        }
    }

    class Animal
    {
        public String Nome { get; set; }

        public void Beber()
        {
            Console.WriteLine("Animal.Beber");
        }

        //o método comer será chamado na classe derivada, por causa do modificador virtual
        public virtual void Comer()
        {
            Console.WriteLine("Animal.Comer");
        }

        public void Andar()
        {
            Console.WriteLine("Animal.Andar");
        }
    }

    class Gato : Animal
    {
        //observe o modificador new
        public new void Beber()
        {
            Console.WriteLine("Gato.Beber");
        }

        //modificador override
        public override void Comer()
        {
            Console.WriteLine("Gato.Comer");
        }

        public new void Andar()
        {
            Console.WriteLine("Gato.Andar");
        }
    }
}