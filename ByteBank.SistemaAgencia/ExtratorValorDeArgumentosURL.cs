using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {

            URL = url;

            int indiceInterrogacao = url.IndexOf("?");

            _argumentos = url.Substring(indiceInterrogacao + 1);

            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }
        }

        public string GeValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentosEmCaixaAlta = _argumentos.ToUpper();


            string termo = nomeParametro + "=" ;
            int indiceTermo = argumentosEmCaixaAlta.IndexOf(termo);
            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }
    }
}
