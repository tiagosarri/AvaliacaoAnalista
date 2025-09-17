/*
 Você deve implementar nessa aplicação console uma lógica que satisfaça os seguintes requisitos:
    1 - A aplicação deve solicitar ao usuário que ele digite um número.
    2 - A aplicação deve ler essa entrada e garantir que foi digitado um número inteiro, positivo, maior que 0 e menor que 20.
    3 - A aplicação deve gerar uma sequência de Fibonacci com a quantidade de repetições informada pelo usuário.
    Obs: A seguência de Fibonacci segue o padrão 1,1,2,3,5,8 e assim por diante, sendo o próximo número a soma do último número com o seu anterior.
*/

namespace Teste2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Gerador de Sequência de Fibonacci ===");
            Console.WriteLine();

            var numberOfTerms = GetValidInput();

            Console.WriteLine($"\nSequência de Fibonacci com {numberOfTerms} termos:");
            GenerateFibonacciSequence(numberOfTerms);

            Console.WriteLine("\nPrograma finalizado.");
        }

        /// <summary>
        /// Solicita e valida a entrada do usuário
        /// </summary>
        /// <returns>Número inteiro válido entre 1 e 19</returns>
        private static int GetValidInput()
        {
            var number = 0;
            var isValidInput = false;

            do
            {
                Console.Write("Digite um número inteiro entre 1 e 19: ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out number))
                {
                    if (number > 0 && number < 20)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Erro: O número deve ser maior que 0 e menor que 20.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Erro: Por favor, digite um número inteiro válido.");
                    Console.WriteLine();
                }
            } while (!isValidInput);

            return number;
        }

        /// <summary>
        /// Gera e exibe a sequência de Fibonacci
        /// </summary>
        /// <param name="count">Quantidade de termos a serem gerados</param>
        private static void GenerateFibonacciSequence(int count)
        {
            if (count <= 0)
                return;

            if (count >= 1)
                Console.Write("1");

            if (count >= 2)
                Console.Write(", 1");

            if (count > 2)
            {
                var firstTerm = 1;
                var secondTerm = 1;

                for (int i = 3; i <= count; i++)
                {
                    var nextTerm = firstTerm + secondTerm;
                    Console.Write($", {nextTerm}");

                    firstTerm = secondTerm;
                    secondTerm = nextTerm;
                }
            }

            Console.WriteLine();
        }
    }
}