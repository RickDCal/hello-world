using System;

class TrabalhoIetec
{
    static void main (string[] args)
    {
        //int opcao = 0;
        double x = 0;
        double y = 0;
        double resultado = 0;

        Console.WriteLine("********************* Calculadora *********************");
        Console.Write();
        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 ---> +");
        Console.WriteLine("2 ---> -");
        Console.WriteLine("3 ---> x");
        Console.WriteLine("4 ---> /");
        Console.WriteLine("");
        int opcao = int.Parse(Console.ReadLine());
        
        while(opcao != 9)
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 ---> +");
            Console.WriteLine("2 ---> -");
            Console.WriteLine("3 ---> x");
            Console.WriteLine("4 ---> /");
            Console.WriteLine("9 ---> Sair");
            Console.WriteLine("");
            opcao = int.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1:
                {
                    Console.WriteLine("Opção: SOMA");
                    resultado = x + y;
                    Console.WriteLine("Resultado = {0}", resultado);
                };
                case 2:
                {
                    Console.WriteLine("Opção: SUBTRAÇÃO");
                    resultado = x - y;
                    Console.WriteLine("Resultado = {0}", resultado);
                };
                case 3:
                {
                    Console.WriteLine("Opção: MULTIPLICAÇÃO");
                    resultado = x * y;
                    Console.WriteLine("Resultado = {0}", resultado);
                };
                case 4:
                {
                    Console.WriteLine("Opção: DIVISÃO");
                    resultado = x / y;
                    Console.WriteLine("Resultado = {0}", resultado);
                };
                Default:
                {  
                    Console.WriteLine("Opção Inválida. Para sair, digite 9.");
                };
            }
        }
    }
}