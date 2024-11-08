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

        // Gerar os numeros soltedos
        List<int> numerosSorteados = SortearNumeros(quatidadeNumeros, totalDeNumeros);
                  
        //exibir o resutado do sorteio
        Console.WriteLine("Gerar bilhete:");       
        
        Console.WriteLine("*******************************************************");
        Console.WriteLine("**                Bilhte da sorte!                   **");
        Console.WriteLine("**   Soterio de " + quatidadeNumeros + " numeros                            **");
        Console.WriteLine("**   De 1 a " + totalDeNumeros + "                                       **");
        Console.Write("**   Números sorteados:   ");        
          
        foreach (int numero in numerosSorteados)
        {
            Console.Write(numero + " ");
        }
           
        Console.WriteLine("         **");     
        Console.WriteLine("*******************************************************");
        
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