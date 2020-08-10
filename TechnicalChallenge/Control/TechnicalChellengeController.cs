using System;
using System.Linq;
using System.Collections.Generic;

namespace TechnicalChellenge.Control
{
    public class TechnicalChellengeController
    {
        private List<int> numerosDivisores = new List<int>();
        private List<int> numerosPrimos = new List<int>();

        /// <summary>
        /// Método Responsável por chamar todo o processo de cálculo
        /// </summary>
        public void Start()
        {
            //------------------------------------------------------------------------------------------
            // 1. Chamando método para validação de valores digitados
            //------------------------------------------------------------------------------------------
            //Valores a serem passados para o método
            String texto = "Por favor, digite um número inteiro: ";
            String mensagemDeErro = "Valor digitado inválido!";
            int valorDigitado = Utils.Utils.GetValorDigitado(texto, mensagemDeErro);

            //------------------------------------------------------------------------------------------
            // 2. Chamando métodos que calculam os números primos/divisores
            //------------------------------------------------------------------------------------------
            numerosPrimos = CalculoController.GetFatoresPrimos(valorDigitado);
            numerosDivisores = CalculoController.GetDivisores(valorDigitado);

            //------------------------------------------------------------------------------------------
            // 3. Retornando mensagem para o usuário
            //------------------------------------------------------------------------------------------
            Console.WriteLine("Divisores: " + string.Join(", ", numerosDivisores.OrderBy(x => x)));
            Console.WriteLine("Divisores Primos: " + string.Join(", ", numerosPrimos.OrderBy(x => x)));
            Console.ReadLine();
        }
        
    }
}
