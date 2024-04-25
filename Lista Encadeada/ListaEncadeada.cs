class ListaEncadeada
{
    public void AdicionarNoInicio(int valor)
    {
        var novoNo = new No { Valor = valor };

        novoNo.Proximo = primeiro;
        primeiro = novoNo;
    }

    public void AdicionarNoFinal(int valor)
    {
        var novoNo = new No { Valor = valor };

        if (primeiro == null)
            primeiro = novoNo;
        else
        {
            No ultimo = primeiro;

            while (ultimo.Proximo != null)
            {
                ultimo = ultimo.Proximo;
            }

            ultimo.Proximo = novoNo;
        }
    }

    public void RemoverNoInicio()
    {
        if (primeiro == null)
            throw new Exception("Não é possível remover um elemeno de uma lista vazia.");

        primeiro = primeiro.Proximo;
    }

    public void RemoverNoFinal()
    {
        if (primeiro == null)
            throw new Exception("Não é possível remover um elemeno de uma lista vazia.");

        if (primeiro.Proximo == null)
        {
            primeiro = null;
        }
        else
        {
            No penultimo = primeiro;

            while (penultimo?.Proximo?.Proximo != null)
            {
                penultimo = penultimo.Proximo;
            }

            if (penultimo != null)
                penultimo.Proximo = null;
        }
    }

    public No? Primeiro { get { return primeiro; } }

    private No? primeiro = null;
}