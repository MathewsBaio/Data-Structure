// Ordene o vetor usando Insertion, Selection e Bubble sort.

using System.Data;

namespace EX_Inventado;

class Program
{
    static void Main(string[] args)
    {
        int[] vet = {5,4,3,2,1};

        BubbleSort(vet);

        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine($"{vet[i]}");
        }
    }

    static void InsertionSort(int[] vet)
    {
        int key = vet[0];

        for(int i = 1; i < vet.Length; i++)
        {
            int j = i - 1;
            if (vet[i] < vet[i - 1])
            {
                key = vet[i];

                while (j >= 0 && vet[j] > key)
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = key;
            }
        }

    }

    static void SelectionSort(int[] vet)
    {
        int aux = 0;

        for (int pos = 0; pos < vet.Length - 1; pos++)
        {
            int menorAbsoluto = pos;

            for (int i = pos + 1; i < vet.Length; i++)
            {
                if (vet[i] < vet[menorAbsoluto])
                {
                    menorAbsoluto = i;
                }
            }
            aux = vet[pos];
            vet[pos] = vet[menorAbsoluto];
            vet[menorAbsoluto] = aux;
        }
    }

    static void BubbleSort(int[] vet)
    {
        int ultimaPos = vet.Length - 1;
        int aux = 0;
        int j = 0;
        bool control = true;

        while (control)
        {
            control = false;

            for (int i = 0; i < ultimaPos; i++)
            {
                if (vet[i] > vet[i + 1])
                {
                    aux = vet[i];
                    vet[i] = vet[i + 1];
                    vet[i + 1] = aux;
                    j = i;
                    control = true;
                }
            }
            ultimaPos = j;
        }
    }
}
