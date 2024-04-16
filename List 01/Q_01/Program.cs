/*
Questão 1: 

Faça um procedimento que receba um número n inteiro e positivo. O procedimento deve imprimir todos os números do intervalo entre 0 e n que são divisíveis por 2 e por 3 (simultaneamente). Restrição: não utilize comandos de repetição.
*/

namespace Q_01;

class Program
{
    static void Main(string[] args)
    {
        PrintNumbers(100);
    }

    static void PrintNumbers(int n)
    {
        PrintNumbers(n, 0);
    }

    static void PrintNumbers(int n, int number)
    {
        if (n < 0)
        {
            n = n * -1;
        }

        if (number == n)
        {
            if (number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine(number);
            }
            return;
        }

        if (number % 2 == 0 && number % 3 == 0)
        {
            Console.WriteLine(number);
        }

        PrintNumbers(n, number + 1);
    }
}
