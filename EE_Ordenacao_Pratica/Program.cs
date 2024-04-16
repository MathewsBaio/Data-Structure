// dotnet new console --use-program-main

internal class Program
{
    public static void Main(String[] args)
    {
        int[] vet = {3, 8, 1, 11, 4, 2, 5};

        QuickSort(vet, 0, vet.Length - 1);

        for(int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine(vet[i]);
        }
        
    }


    public static void QuickSort(int[] vet, int inicio, int fim)
    {
        
        int menor, maior, pivo;
        menor = inicio + 1;
        maior = fim;
        pivo = inicio;
        do
        {
            while (menor < vet.Length -1 && vet[menor] <= vet[pivo])
            {
                menor++;
            }

            while (maior > inicio && vet[maior] > vet[pivo])
            {
                maior--;
            }

            if (menor < maior)
            {
                trocarPos(vet, menor, maior);
            }

            
        } while (menor < maior);

        trocarPos(vet, pivo, maior);
        pivo = maior;

        if(pivo == 0 || pivo == vet.Length - 1)
        {
            return;
        }

        QuickSort(vet, 0, pivo - 1);
        QuickSort(vet, pivo + 1, vet.Length - 1);
    }


    //Troca comparando pares
    static void BubbleSort(int[] vet)
    {
        int ultimaTroca =  vet.Length - 1;
        int j = ultimaTroca;
        Boolean controle = true;
        
        while(controle)
        {
            controle = false;
            for(int i = 0; i < ultimaTroca; i++)
            {
                if(vet[i] > vet[i+1])
                {
                    trocarPos(vet, i, i + 1);
                    j = i;
                    controle = true;
                }
            }
            ultimaTroca = j;
        }
    }

    static void InsertionSort(int[] vet)
    {
        for(int i = 1; i < vet.Length; i++)
        {
            int key = vet[i];
            int j = i - 1;

            while(j >= 0 && vet[j] > key)
            {
                vet[j + 1] = vet[j];
                j--;
            }
            vet[j + 1] = key;
        }
    }

    static void trocarPos(int[] vet,int i, int j)
    {
        int aux;
        aux = vet[i];
        vet[i] = vet[j];
        vet[j] = aux;
    }

}




