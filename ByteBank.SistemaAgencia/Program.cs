using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "paginas?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine($"indiceInterrogacao { indiceInterrogacao}" );

            Console.WriteLine(url);

           string argumentos  = url.Substring(indiceInterrogacao + 1); // para sair  fora do caracter ?

            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }


}
