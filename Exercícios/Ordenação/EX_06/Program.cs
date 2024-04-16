namespace EX_06;

class Program
{
    static void Main(string[] args)
    {
        Produto[] produtos = new Produto[5];
        produtos[0] = new Produto();
        produtos[0].Codigo = 5;
        produtos[1] = new Produto();
        produtos[1].Codigo = 4;
        produtos[2] = new Produto();
        produtos[2].Codigo = 3;
        produtos[3] = new Produto();
        produtos[3].Codigo = 2;
        produtos[4] = new Produto();
        produtos[4].Codigo = 1;

        InsertionSort(produtos);
    }

    static void InsertionSort(Produto[] prod)
    {
        int j, key = 0;
        
        for (int i = 1; i < prod.Length; i++)
        {
            
            if(prod[i].Codigo < prod[i - 1].Codigo)
            {
                key = prod[i].Codigo;
                j = i - 1;

                while (j >= 0 && prod[j].Codigo > key)
                {
                    prod[j + 1].Codigo = prod[j].Codigo;
                    j--;
                }
                prod[j + 1].Codigo = key;
            }
            
        }

        for (int i = 0; i < prod.Length; i++)
        {
            Console.WriteLine($"{prod[i].Codigo}");
        }
    }
}
