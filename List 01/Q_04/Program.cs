/*
Questão 04:

Faça uma função que ordene um vetor de inteiros passado por parâmetro utilizando o método bolha e retorne o número de trocas realizadas.
*/

namespace Q_04;

class Program
{
    static void Main(string[] args)
    {
        int[] vet = {2,1,16,5,28,9,3};

        Console.WriteLine($"Houveram {CountChanges(vet)} trocas ao ordernar o vetor.");

        Console.Write("Vetor ordenado: ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write($"{vet[i]} ");
        }

        
    }

    static int CountChanges(int[] vet)
    {
        return CountChanges(vet, 0);
    }

    static int CountChanges(int[] vet, int cont)
    {
        int pos = vet.Length - 1;
        int aux, j = pos;
        bool control = true;
        
        while(control)
        {
            control = false;

            for (int i = 0; i < pos; i++)
            {
                if(vet[i] > vet[i + 1])
                {
                    aux = vet[i];
                    vet[i] = vet[i + 1];
                    vet[i + 1] = aux;
                    j = i;
                    control = true;
                    cont++;
                }
            }
            pos = j;
        }
        
        return cont;
    }
}
