/*
Questão 1) Faça uma função recursiva que receba um número inteiro por parâmetro e retorne true se o número for um número perfeito ou false caso contrário. Um número perfeito é um número natural para o qual a soma de todos os seus divisores naturais próprio é igual ao próprio número. Esta função não pode utilizar comandos de repetição.
Alguns números perfeitos:	6	28	496	8128
*/

namespace EE_Simulado_01;

class Program
{
    static void Main(string[] args)
    {
        bool perfect = VerifyPerfect(8128);
        
        if(perfect)
        {
            Console.WriteLine("É número perfeito!");
        } else {
            Console.WriteLine("Não é número perfeito!");
        }
    }

    static bool VerifyPerfect(int num)
    {
        return VerifyPerfect(num,0, 1);
    }

    static bool VerifyPerfect(int number, int sum, int div)
    {
        if (div == number)
        {
            if(sum == number)
            {
                return true;
            } else 
            {
                return false;
            }

        }

        if(number % div == 0)
        {
            sum += div;
        }

        return VerifyPerfect(number, sum, div + 1);
    }


}
