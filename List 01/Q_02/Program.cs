/*
Questão 02:

Faça uma função que receba um vetor de números inteiros por parâmetro e multiplique por -1 todos os elementos negativos desse vetor. A função deve retornar o número de elementos negativos encontrados. Restrição: não utilize comandos de repetição.
*/

namespace Q_02;

class Program
{
    static void Main(string[] args)
    {
        int[] vet = {1, 2, 3, 4, 5, -6, -7, -8, -9, -10};

        Console.WriteLine($"The array has {NumberOfNegatives(vet)} negative numbers");
    }

    static int NumberOfNegatives(int[] vet)
    {
        return NumberOfNegatives(vet, 0, 0);
    }

    static int NumberOfNegatives(int[] vet, int index, int cont)
    {
        if(index == vet.Length - 1)
        {
            if(vet[index] < 0)
            {
                vet[index] = vet[index] * -1;
                cont++;
            }
            return cont;

        }

        if(vet[index] < 0)
            {
                vet[index] = vet[index] * -1;
                cont++;
            }

        return NumberOfNegatives(vet, index + 1, cont);
    }
}
