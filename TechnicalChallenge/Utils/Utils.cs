using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalChellenge.Utils
{
    public class Utils
    {
        /// <summary>
        /// Método responsável por validar dados digitados pelo usuário(nesse caso necessita ser um inteiro)
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="mensagemDeErro"></param>
        /// <returns>Valor inteiro digitado pelo usuário</returns>
        public static int GetValorDigitado(String texto, String mensagemDeErro)
        {
            Console.WriteLine(texto);
            String input = Console.ReadLine();
            int valor = 0;

            if (int.TryParse(input, out valor))
            {
                return valor;
            }
            else
            {
                Console.WriteLine(mensagemDeErro);
                return GetValorDigitado(texto, mensagemDeErro);
            }
        }
    }
}
