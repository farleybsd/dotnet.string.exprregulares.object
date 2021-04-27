using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            // regex usa os codigo da tabela ascii
            // Olá, meu nome é Guilherme e você pode entrar em contato comigo
            // através do número 8457-4456!
            // Meu nome é Guilherme, me ligue em 4784-4546

            //string padrao = "[0-9][0-9][0-9[0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4}[-][0-9]{4}"; // {4} quantidade de vezes que ira repetir [0-9] porque o modelo e 4 casas - 4 casas
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}"; // a casa antes do - pode ter de 4 a 5 digitos usando {4,5}
            string padrao = "[0-9]{4,5}-?[0-9]{4}"; // pode ser -? ou nao digitado o -
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 99105-7769";

            //Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao)); retornar true/false
            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);
            /*
            string urlTeste = "http://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("http://www.bytebank");

            Console.WriteLine(urlTeste.StartsWith("http://www.bytebank")); // inicia com
            Console.WriteLine(urlTeste.EndsWith("cambio")); // termina com
            Console.WriteLine(urlTeste.Contains("bytebank")); // se uma string comtem a outra 
            */
            /*
            string urlParametro = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extratorDeValoresmoedaOrigem = new ExtratorValorDeArgumentosURL(urlParametro);
            string valor = extratorDeValoresmoedaOrigem.GeValor("Valor");
            Console.WriteLine("Valor da moeda moedaOrigem " + valor);

            */

            /*

            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(termoBusca.ToUpper());
            Console.WriteLine(mensagemOrigem.ToLower());

            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));

            */

            /*
            string testeRemocao = "primeiraParte&ParteParRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            */


            /*
            string urlParametro = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";

            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametro);
            string valor = extratorDeValores.GeValor("moedaDestino");
            Console.WriteLine("Valor da moeda destino " +valor);
            


            
            string urlParametro2 = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";

            ExtratorValorDeArgumentosURL extratorDeValoresmoedaOrigem = new ExtratorValorDeArgumentosURL(urlParametro2);
            string valor2 = extratorDeValoresmoedaOrigem.GeValor("moedaOrigem");
            Console.WriteLine("Valor da moeda moedaOrigem " + valor2);

            string urlParametroValor = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extratorDeValor = new ExtratorValorDeArgumentosURL(urlParametroValor);
            string valorparam = extratorDeValor.GeValor("valor");
            Console.WriteLine("Valor da moeda valor " + valorparam);

            */

            // testando palavra 
            /*
                string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
                string nomeArgumento = "moedaDestino=";
                int indece = palavra.IndexOf(nomeArgumento);
                Console.WriteLine(palavra);
                Console.WriteLine(indece);
                Console.WriteLine("Tamanho da string nomeArgumento" + nomeArgumento.Length);
                Console.WriteLine(palavra.Substring(indece));
                Console.WriteLine(palavra.Substring(indece + nomeArgumento.Length ));
                Console.ReadLine();

                */



            /*
            string url = "paginas?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine($"indiceInterrogacao { indiceInterrogacao}" );

            Console.WriteLine(url);

           string argumentos  = url.Substring(indiceInterrogacao + 1); // para sair  fora do caracter ?

            Console.WriteLine(argumentos);
            */
            Console.ReadLine();
        }
    }


}
