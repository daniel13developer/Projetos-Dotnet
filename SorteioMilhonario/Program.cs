using System;
using System.Collections.Generic;
using System.Linq;
class ProgamaSorteioMilhonario
{
    static void Main()
    {
        // iniciando varivel do sorteio
        int quatidadeNumeros = 6;
        int totalDeNumeros = 60; 
        int totalBilhetes = 3;

        SortearBilhetes(totalBilhetes, quatidadeNumeros, totalDeNumeros);             
        
    }

    static void MostrarResultado(List<int> ListaNumerosSorteados, int quantidade, int maxNumero)
    {
        Console.WriteLine("Gerar bilhete:");       
        
        Console.WriteLine("*******************************************************");
        Console.WriteLine("**                Bilhte da sorte!                   **");
        Console.WriteLine("**   Soterio de " + quantidade + " numeros                            **");
        Console.WriteLine("**   De 1 a " + maxNumero + "                                       **");
        Console.Write("**   Números sorteados:   ");        
          
        foreach (int numero in ListaNumerosSorteados)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("         **");     
        Console.WriteLine("*******************************************************");

    }

    static void SortearBilhetes(int numeroBilhetes, int quatidadeNumeros, int totalDeNumeros)
    {
        int quantsorteios = 0;

        while(quantsorteios < numeroBilhetes)
        {            
            List<int> numerosSorteados = SortearNumeros(quatidadeNumeros, totalDeNumeros);
            MostrarResultado(numerosSorteados, quatidadeNumeros, totalDeNumeros);
            quantsorteios ++;

        }

    }
    
    static List<int> SortearNumeros(int quantidade, int NumeroMax)
    {
        Random random = new Random();
        HashSet<int> numerosSorteados = new HashSet<int>();

        // Gera números aleatórios e garante que não haja repetição
        while (numerosSorteados.Count < quantidade)
        {
            int numeroGerado = random.Next(1, NumeroMax + 1);
            numerosSorteados.Add(numeroGerado);
        }

        return numerosSorteados.ToList();
    }
}