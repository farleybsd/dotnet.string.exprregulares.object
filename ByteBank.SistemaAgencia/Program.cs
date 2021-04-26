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

            // testando palavra 

            string palavra = "moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";
            int indece = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(palavra);
            Console.WriteLine(indece);
            Console.WriteLine("Tamanho da string nomeArgumento" + nomeArgumento.Length);
            Console.WriteLine(palavra.Substring(indece));
            Console.WriteLine(palavra.Substring(indece + nomeArgumento.Length +1));
            Console.ReadLine();
            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

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
