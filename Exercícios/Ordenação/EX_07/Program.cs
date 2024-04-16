/*
7) Considere a classe Produto da questão 6 e faça um procedimento que receba por
parâmetro um vetor de produtos e ordene esse vetor pelo preço do produto.
Utilize o método da seleção para ordenar o vetor.
*/

namespace EX_07;

class Program
{
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[5];
        produtos[0] = new Produto();
        produtos[0].Preco = 5.0;
        produtos[1] = new Produto();
        produtos[1].Preco = 4.0;
        produtos[2] = new Produto();
        produtos[2].Preco = 3.0;
        produtos[3] = new Produto();
        produtos[3].Preco = 2.0;
        produtos[4] = new Produto();
        produtos[4].Preco = 1.0;

        SelectionSort(produtos);
    }

    static void SelectionSort(Produto[] prod)
    {
        
        double aux = 0;
        int menor = 0;        
        int menorAbsoluto = menor;

        while (menor < prod.Length - 1)
        {
            for (int i = menor + 1; i < prod.Length; i++)
            {
                if(prod[i].Preco < prod[menorAbsoluto].Preco)
                {
                    menorAbsoluto = i;
                }
            }
            aux = prod[menor].Preco;
            prod[menor].Preco = prod[menorAbsoluto].Preco;
            prod[menorAbsoluto].Preco = aux;
            menor++;
            menorAbsoluto = menor;
        }


        for (int i = 0; i < prod.Length; i++)
        {
            Console.WriteLine($"{prod[i].Preco}");
        }
    }
}
