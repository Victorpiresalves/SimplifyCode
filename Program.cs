using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SimplifyCode
{
    class Program
    {
        static void Main(string[] args)
        {

            var listaDeArquivos = "";

            var baseArquivo = File.ReadAllText("C:\\Users\\Victor Pires\\Source\\Repos\\SimplifyCode\\SimplifyCode\\arquivos\\arquivoGenerico.txt", Encoding.UTF7);



            var controllers =
                              "CardapioFranquiaController," +
                              "CategoriaFranquiaController," +
                              "ClienteController," +
                              "FranquiaController," +
                              "HomeController";

            var split = controllers.Split(",");


            for (int i = 0; i < split.Length; i++)
            {
                listaDeArquivos += baseArquivo.Replace("_classe", split[i]);
            }



            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
