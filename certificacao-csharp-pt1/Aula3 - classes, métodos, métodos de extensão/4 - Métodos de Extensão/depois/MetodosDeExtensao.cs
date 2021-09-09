using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            // \r\ é quebra de linha
            Impressora impressora = new Impressora("Este é\r\no meu documento");

            impressora.ImprimirDocumento();

            ImprimirDocumentoHtml(impressora.Documento);

            //extensão
            impressora.ExtensaoImprimirDocumentoHtml();
        }
         void ImprimirDocumentoHtml(string documento)
        {
            Console.WriteLine($"<html><body>{documento}</body></html>");
        }
       
    }

    class Impressora
    {
        public string Documento { get; }

        public Impressora(string documento)
        {
            this.Documento = documento;
        }

        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }
        //public void ImprimirDocumentoHtml()
        //{
        //    Console.WriteLine($"<html><body>{Documento}</body></html>");
        //}
       
    }

    //criando um método de extensão
    static class ImpressoraExtensions
    {   
        //com o this, eu estou estendendo a minha classe impressora com o método ImprimirDocumentoHtml
        public static void ExtensaoImprimirDocumentoHtml(this Impressora impressora)
        {
            Console.WriteLine($"<html><body>{impressora.Documento} EM HTML</body></html>");
        }
       
    }
}


