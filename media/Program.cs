using System;
using System.Collections.Generic;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe os valores desejados: ");
        int quantidadevalor = int.Parse(Console.ReadLine());

        var listadevalores = ColetarValores(quantidadevalor);

        Console.WriteLine("A soma dos valores é: " + listadevalores);
        Console.WriteLine("A média dos valores é: " + listadevalores);

        Console.ReadLine();

    }
    static List<decimal> ColetarValores(int quantidadevalor)
    {
        List<decimal> listadevalores = new List<decimal>(quantidadevalor);

        for (int i = 0; i < quantidadevalor; i++)
        {
            Console.WriteLine($"Informe o valor + {i + 1}");
            listadevalores.Add(decimal.Parse(Console.ReadLine()));
        }


        return listadevalores;
    }

    static decimal CalcularSoma(List<decimal> listadevalores)
    {
        decimal total = 0;
        foreach (decimal valor in listadevalores)
            total += valor;

        return total;
    }

    static decimal CalcularMedia(List<decimal> listadevalores)
    {
        decimal soma = CalcularSoma(listadevalores);
        decimal media = soma / listadevalores.Count;
        return media;

        
    }

}
