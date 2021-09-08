using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5;

            char resposta = 'S';//caracter System.Char

            byte nivelDeAzul = 0xFF;// = 255 em decimal, não suporta negativo

            short   passageirosVoo = 230; // System.Int16 (16 bites)
            passageirosVoo = -7;

            int populacao = 1500; //System.Int32 (32 bites)
            populacao = -2300;

            long populacaoDoBrasil = 207_660_929; // +/- 207 milhões - Syetm.Int64

            sbyte niveldeBrilho = -127;// System.Sbyte

            ushort passseirosNavio = 230;//System.UInt16 - u significa que não tem sinal

            uint estoque = 1500; //System.UInt32 -  unsigned significa que não tem sinal
            ulong populacaoDoMundo = 7_000_000_000;//7 bilhões - S
        
            Console.WriteLine($"resposta: {resposta}");

          Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
          Console.WriteLine($"passageirosVoo: {passageirosVoo}");
          Console.WriteLine($"populacao: {populacao}");
          Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

          Console.WriteLine($"niveldeBrilho: {niveldeBrilho}");
          Console.WriteLine($"estoque: {estoque}");
          Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");
        }
    }
}
