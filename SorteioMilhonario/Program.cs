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
        
        bool exit = false;    

            while (!exit)
            {   
                int numeroBilhetes = 0;

                Console.Clear();
                Console.WriteLine("");
                
                Console.WriteLine("*********************************************************");
                Console.WriteLine("**                  Menu Principal                     **");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("**                  Bilhte(s) da Sorte!                **");        
                Console.WriteLine("**    Selecione o numero de bilhete que desja gerar    **");
                Console.WriteLine("**                  Boa sorte!                         **");
                Console.WriteLine("*********************************************************");

                Console.WriteLine("ESCOLHA A QUANTIDADE DE BILHETE QUE SEJA MOSTRAR NA TELA:");                
                Console.WriteLine("Digite (1) para imprimir 1 bilhete");
                Console.WriteLine("Digite (2) para imprimir 2 bilhetes");
                Console.WriteLine("Digite (3) para imprimir 3 bilhetes");
                Console.WriteLine("Digite (0) para nenhum bilhete e sair");
                Console.Write(" ");

                string? choice = Console.ReadLine();               

                switch (choice)
                {                   

                    case "1":
                        Console.WriteLine("Você escolheu a Opção 1");
                        numeroBilhetes = 1;
                        break;
                    case "2":
                        Console.WriteLine("Você escolheu a Opção 2");
                        numeroBilhetes = 2;
                        break;
                    case "3":
                        Console.WriteLine("Você escolheu a Opção 3");
                        numeroBilhetes = 3;
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");                        
                        break;
                }

                 SortearBilhetes(numeroBilhetes, quatidadeNumeros, totalDeNumeros); 

                if (!exit)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
                
            }     
        
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