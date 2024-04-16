class Produto
{
public int Codigo { get => codigo; set => codigo = value; }
public string Descricao
{
get => descricao;
set => descricao = value;
}
public double Preco { get => preco; set => preco = value; }
private int codigo;
private string descricao;
private double preco;
}