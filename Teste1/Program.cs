/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite uma string alfanumérica.
    2 - A aplicação deve remover todos os valores duplicados próximos, de forma que não hajam letras/números iguais juntos.
    Exemplo: AAABCCDDD -> Retorno : ABCD
 */

using System.Text;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Removedor de Caracteres Duplicados Consecutivos ===");

            while (true)
            {
                Console.Write("\nDigite uma string alfanumérica (ou 'sair' para encerrar): ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input) || input.ToLower() == "sair")
                {
                    Console.WriteLine("Encerrando aplicação...");
                    break;
                }

                var result = RemoveDuplicatesWords(input);

                Console.WriteLine($"String original: {input}");
                Console.WriteLine($"String processada: {result}");
            }
        }

        /// <summary>
        /// Remove caracteres duplicados que aparecem consecutivamente na string
        /// </summary>
        /// <param name="input">String de entrada</param>
        /// <returns>String sem caracteres duplicados consecutivos</returns>
        static string RemoveDuplicatesWords(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var result = new StringBuilder();

            result.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (char.ToLowerInvariant(input[i]) != char.ToLowerInvariant(input[i - 1]))
                    result.Append(input[i]);
            }

            return result.ToString();
        }
    }
}