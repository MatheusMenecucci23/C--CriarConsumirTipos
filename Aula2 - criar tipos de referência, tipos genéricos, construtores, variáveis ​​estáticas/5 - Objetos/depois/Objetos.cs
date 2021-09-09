using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"pontuacao: {pontuacao}");

            Console.WriteLine("OBJETC COM VALOR PRIMITIVO");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"meuObjeto:{meuObjeto}");
            Console.WriteLine();
                
            Console.WriteLine("OBJECT COM REFERÊNCIA DE OBJETO");

            meuObjeto = new Jogador();
            //tipando a variável classRef com Jogador
            Jogador classRef;
            classRef = (Jogador)meuObjeto; //conversão explícita - (Jogador) - , ou "cast"


            Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
