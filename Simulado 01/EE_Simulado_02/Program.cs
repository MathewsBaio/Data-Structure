/*

Questão 2) Faça três procedimentos. Cada procedimento deve receber um vetor de atletas e reorganizar o mesmo em ordem decrescente do peso do atleta. O primeiro procedimento deve utilizar o método bolha, o segundo o método da inserção e o terceiro o método da seleção.

*/

using System.Runtime.InteropServices;

namespace EE_Simulado_02;

class Program
{
    static void Main(string[] args)
    {
        Atleta[] atletas = new Atleta[3];

        atletas[0] = new Atleta();
        atletas[0].Name = "Zezin";
        atletas[0].Peso = 92;

        atletas[1] = new Atleta();
        atletas[1].Name = "Pedrin";
        atletas[1].Peso = 84;

        atletas[2] = new Atleta();
        atletas[2].Name = "Junin";
        atletas[2].Peso = 79;

        InsertionSort(atletas);
    }

    static void BubbleSort(Atleta[] atletas)
    {
        bool control = true;
        int lastPos = atletas.Length - 1;
        int aux = 0;
        int j = lastPos;

        while (control) {
            control = false;

            for (int i = 0; i < lastPos; i++)
            {
                if (atletas[i].Peso > atletas[i + 1].Peso)
                {
                    aux = atletas[i].Peso;
                    atletas[i].Peso = atletas[i + 1].Peso;
                    atletas[i + 1].Peso = aux;
                    j = i;
                    control = true;
                }
            }
            lastPos = j;
        }

        for (int i = 0; i < atletas.Length; i++)
        {
            Console.WriteLine($"{atletas[i].Name} - {atletas[i].Peso}");
            
        }
    }    

    static void SelectionSort(Atleta[] atletas)
    {
        int pos = 0;
        int minor = pos;
        int aux = 0;

        while(pos < atletas.Length - 1) 
        {
            for (int i = pos + 1; i < atletas.Length; i++)
            {
                if(atletas[i].Peso < atletas[minor].Peso)
                {
                    minor = i;
                    
                }
            }
            aux = atletas[pos].Peso;
            atletas[pos].Peso = atletas[minor].Peso;
            atletas[minor].Peso = aux;
            pos++;
            minor = pos;
        }

        for (int i = 0; i < atletas.Length; i++)
        {
            Console.WriteLine($"{atletas[i].Name} - {atletas[i].Peso}");
            
        }
    }

    static void InsertionSort(Atleta[] atletas)
    {
        int key = 0;

        for (int i = 1; i < atletas.Length; i++)
        {
            if(atletas[i].Peso < atletas[i - 1].Peso)
            {
                key = atletas[i].Peso;
                int j = i - 1;
                
                while (j >= 0 && atletas[j].Peso > key)
                {
                    atletas[j + 1].Peso = atletas[j].Peso;
                    j--;
                }
                atletas[j + 1].Peso = key;
            }
        }

        for (int i = 0; i < atletas.Length; i++)
        {
            Console.WriteLine($"{atletas[i].Name} - {atletas[i].Peso}");
            
        }
    }
}
