using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(12, 10);
            Console.WriteLine(retangulo.GetArea());

            Retangulo outroRetangulo = new Retangulo(10,10);
            Console.WriteLine(retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura));

            outroRetangulo = new Retangulo(5,6);
            Console.WriteLine(Retangulo.Semelhante(retangulo,outroRetangulo));

        }
    }

    //CRIANDO A CLASSE RETANGULO
    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"altura: {altura}, largura: {largura}");
        
            var area = GetArea();
            Console.WriteLine("Area:{0}",area);
        }

        //criando um método publico com um tipo de retorono double
        public double GetArea()
        {
            return Altura * Largura;
        }

        internal bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetanguloLargura / outroRetanguloAltura)) /*proporção do outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a proporção inversa*/
                (outroRetanguloLargura / outroRetanguloAltura));
        }

         internal static bool Semelhante(Retangulo retangulo,Retangulo outroRetangulo)
        {
            return
                ((retangulo.Largura / retangulo.Altura) == /*proporção deste retângulo*/
                (outroRetangulo.Largura / outroRetangulo.Altura)) /*proporção do outro retângulo*/
                ||
                ((retangulo.Altura / retangulo.Largura) == /*compara a proporção inversa*/
                (outroRetangulo.Largura / outroRetangulo.Altura));
        }
    }
}
