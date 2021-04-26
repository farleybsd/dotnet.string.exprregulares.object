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

        public string GeTValor(string nomeParametro)
        {
            return "";
        }
    }
}
