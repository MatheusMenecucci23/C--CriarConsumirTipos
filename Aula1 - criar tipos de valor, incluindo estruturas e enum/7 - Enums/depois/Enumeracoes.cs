using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            const int Seg = 0;
            const int Ter = 1;
            const int Qua = 2;
            const int Qui = 3;
            const int Sex = 4;
            const int Sab = 5;

            //criando uma variável - primeiro dia - do tipo enum e atribuindo um valor ela, no caso o valor é 0, pois segunda vale 0 
            DiasDaSemana primeiroDia = DiasDaSemana.Seg;
            DiasDeTrabalho diasDeTrabalho = DiasDeTrabalho.Ter | DiasDeTrabalho.Qui | DiasDeTrabalho.Sex;

            Console.WriteLine(primeiroDia);
            Console.WriteLine(diasDeTrabalho);
        }
    }
    enum DiasDaSemana : long
    {
        //por padrão o valor da segunda feira é 0
        //porém você consegue definir um valor para cada argumento
        //ex: Seg = 3, Ter=10,
        Seg, Ter, Qua, Qui, Sex, Sab, Dom
    }
    //COM O FLAGS OS VALORES VIRAM AS VARIÁVEIS
    //ASSIM QUANDO IMPRIMIMOS OS DIASDETRABALHO SAIRÁ PARA O USUÁRIOS -SEG, TER...-
    [Flags]
    enum DiasDeTrabalho {Seg = 0, Ter = 1,Qua = 2, Qui = 4, Sex = 8, Sab = 16, Dom = 32 }

}
