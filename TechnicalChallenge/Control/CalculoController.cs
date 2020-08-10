using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalChellenge.Control
{
    public class CalculoController
    {

        /// <summary>
        /// Método responsável por encontrar todos os divisores de um número x
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Lista de divisores</returns>
        public static List<int> GetDivisores(int numero)
        {
            List<int> divisoresList = new List<int>();
            int i;

            for (i = numero; i > 0; i--)//Não podemos fazer divisões com zero
            {
                if(numero%i == 0)
                    divisoresList.Add(i);
            }

            return divisoresList;
        }   
        
        /// <summary>
        /// Método responsável por retornar todos os fatores primos de um número x
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Lista de números primos</returns>
        static public List<int> GetFatoresPrimos(int numero)
        {
            List<int> primosList = new List<int>();
            List<int> vetor = new List<int>();
            int contador = 0;
            int i = 0;

            for (i = 2; i <= numero; i++)
            {
                if (IsNumeroPrimo(i) == true)
                {
                    vetor.Add(i);
                    contador++;
                }
            }

            while (true)
            {
                if (IsNumeroPrimo(numero) == true)
                {
                    if (!primosList.Contains(numero))
                        primosList.Add(numero);
                    break;
                }

                for (i = contador - 1; i >= 0; i--)
                {
                    if ((numero % vetor[i]) == 0)
                    {
                        if (!primosList.Contains(vetor[i]))
                            primosList.Add(vetor[i]);

                        numero = numero / vetor[i];
                        break;
                    }
                }
            }

            return primosList;
        }

        /// <summary>
        /// Método responsável por verificar se o número é primo 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna true ou false</returns>
        static bool IsNumeroPrimo(int numero)
        {
            bool bPrimo = true;
            int fator = numero / 2;
            int i = 0;

            for (i = 2; i <= fator; i++)
            {
                if ((numero % i) == 0)
                    bPrimo = false;
            }

            return bPrimo;
        }
    }
}