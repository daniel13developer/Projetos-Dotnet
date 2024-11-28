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
                int totalBilhetes = 0;

                //Console.Clear();
                Console.WriteLine("");
                
                Console.WriteLine("*********************************************************");
                Console.WriteLine("**                  Menu Principal                     **");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("**                  Bilhete(s) da Sorte!               **");        
                Console.WriteLine("**    Selecione o número de bilhetes que desja gerar   **");
                Console.WriteLine("**                  Boa sorte!                         **");
                Console.WriteLine("*********************************************************");

                Console.WriteLine("Digite uma das opções abaixo para mostras os bilhetes: ");                
                Console.WriteLine("(1) para mostrar na tela 1 bilhete.");
                Console.WriteLine("(2) para mostrar na tela 2 bilhetes.");
                Console.WriteLine("(3) para mostrar na tela 3 bilhetes.");
                Console.WriteLine("(4) para mostrar na tela 3 bilhetes.");
                Console.WriteLine("(0) para sair da programa");
                Console.Write("Digite:  ");    

                string? choice = Console.ReadLine();               

                switch (choice)
                {                   

                    case "1":
                        Console.WriteLine("Você escolheu a Opção 1");
                        totalBilhetes = 1;
                        break;
                    case "2":
                        Console.WriteLine("Você escolheu a Opção 2");
                        totalBilhetes = 2;
                        break;
                    case "3":
                        Console.WriteLine("Você escolheu a Opção 3");
                        totalBilhetes = 3;
                        break;
                    case "4":
                        Console.WriteLine("Você escolheu a Opção 4");
                        totalBilhetes = 4;
                        break;
                    case "0":
                        Console.WriteLine("Saindo...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente!");                        
                        break;
                }

                 SortearBilhetes(totalBilhetes, quatidadeNumeros, totalDeNumeros); 

                if (!exit)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    //Console.ReadKey();
                }
                
            }     
        
    }

    static void MostrarResultado(List<int> ListaNumerosSorteados, int quantidade, int maxNumero)
    {
        
        Console.WriteLine("");
        Console.WriteLine("Bilhete Gerado:");                       
        Console.WriteLine("*******************************************************");
        Console.WriteLine("**                Bilhete da sorte!                  **");
        Console.WriteLine("**   Soterio de " + quantidade + " números                           **");
        Console.WriteLine("**   De 1 a " + maxNumero + "                                       **");
        Console.Write("**   Números gerados:    ");        
          
        foreach (int numero in ListaNumerosSorteados)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine("           **");     
        Console.WriteLine("*******************************************************");

    } 

    static void SortearBilhetes(int numeroDeBilhetes, int quatidadeDeNumeros, int totalDeNumeros)
    {
        int quantsorteios = 0;

        while(quantsorteios < numeroDeBilhetes)
        {            
            List<int> numerosSorteados = SortearNumeros(quatidadeDeNumeros, totalDeNumeros);
            MostrarResultado(numerosSorteados, quatidadeDeNumeros, totalDeNumeros);
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