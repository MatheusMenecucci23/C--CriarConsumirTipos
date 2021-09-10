using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            //tipo é definido na compilação
            string s = "Certificação C#";
            //tipo é definido na compilação (por inferência)
            var v = "Certificação C#";
            //tipo é definido na compilação
            object o = "Certificação C#";

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            //transformando em uppercase
            s = s.ToUpper();
            v = v.ToUpper();
            //convertendo o O em string a aí transformando em upercase
            o = ((string)o).ToUpper();

            Console.WriteLine(s);
            Console.WriteLine(v);
            Console.WriteLine(o);

            //s = 123;
            //v = 123;
            //só o objeto pode receber o valor do tipo int
            o = 123;

            //fazendo o cast para o O par conseguir somar
            o = (int)o + 4;

            Console.WriteLine(o);

            //tipo é definido somente na execução
            //tipo dinamico pode-se atribuir qualquer tipo de variável
            dynamic d = "Certificação C#";
            Console.WriteLine(d);
            d = d.ToUpper();
            Console.WriteLine(d);
            d = 123;
            Console.WriteLine(d);
            d = d + 4;
            Console.WriteLine(d);
        }
    }
}
