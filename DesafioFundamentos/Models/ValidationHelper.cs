using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace DesafioFundamentos.Models
{
    public static class ValidationHelper
    {
        public static decimal LerDecimalComValidacao(string mensagem)
        {
            decimal valor;
            while (true)
            {
                Console.Write(mensagem);
                string input = Console.ReadLine();
                
                if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out valor) && valor >= 0)
                {
                    return valor;
                }
                
                Console.WriteLine("Valor inválido! Digite um número decimal positivo.");
            }
        }

        public static int LerInteiroComValidacao(string mensagem)
        {
            int valor;
            while (true)
            {
                Console.Write(mensagem);
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out valor) && valor >= 0)
                {
                    return valor;
                }
                
                Console.WriteLine("Valor inválido! Digite um número inteiro positivo.");
            }
        }

        public static string LerPlacaComValidacao(string mensagem)
        {
            string placa;
            while (true)
            {
                Console.Write(mensagem);
                placa = Console.ReadLine()?.Trim().ToUpper();
                
                if (!string.IsNullOrWhiteSpace(placa) && placa.Length >= 7)
                {
                    return placa;
                }
                
                Console.WriteLine("Placa inválida! Digite uma placa válida (mínimo 7 caracteres).");
            }
        }
    }
}