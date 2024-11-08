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

        //exibir o resutado do sorteio
        Console.WriteLine("Gerar bilhete:");       
        
        Console.WriteLine("*******************************************************");
        Console.WriteLine("**                Bilhte da sorte!                   **");
        Console.WriteLine("**   Soterio de " + quatidadeNumeros + " numeros                            **");
        Console.WriteLine("**   De 1 a " + totalDeNumeros + "                                       **");
        Console.WriteLine("**   Números sorteados                               **");
        Console.WriteLine("**   XX XX XX XX XX XX                               **");
        Console.WriteLine("*******************************************************");
        
    }
}