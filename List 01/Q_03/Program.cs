/*
Questão 03:

Faça um procedimento que receba o montante reservado para a aposentadoria de uma pessoa e a quantia que ela pretende retirar por mês. O montante reservado é corrigido a cada mês com a taxa de 0,55%, aplicada logo após a retirada. O procedimento deve imprimir o montante (após a retirada e correção), mês a mês. O procedimento também deve imprimir o número de meses em que a pessoa conseguirá fazer a sua retirada. Restrição: não utilize comandos de repetição.
*/

namespace Q_03;

class Program
{
    static void Main(string[] args)
    {
        Retirement(320000, 2200);
    }

    static void Retirement(double total, double salary)
    {
        Retirement(total, salary, 1);
    }

    static void Retirement(double total, double salary, int month)
    {
        if(total - salary < 0)
        {
            Console.WriteLine($"\n\nThese savings will last {month - 1} months");
            return;
        }

        
        total = total - salary;
        total = total - (total * 0.0055);
        Console.WriteLine($"\nMonth {month} - Amount in cash after withdraw: {total:C2}");
        Retirement(total, salary, month + 1);
    }

}
