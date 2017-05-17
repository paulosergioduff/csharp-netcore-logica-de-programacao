using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
        	string mensagem = "Ola variável\n"; // Expressa variável
        	/*  Aparentemente o \n funciona          */
        	string ano = "2017\n";
        	int a = 2; // Variável do tipo inteiro
        	int b = 4; // Como quase sempre, se declara variáveis para depois usar
        	int c = a+b;
            int valorComparacao = 4;
        	double testeDouble; // Declarando tipo Double
        	testeDouble = 100.5;

        	float testeFloat; //Testando Float
        	testeFloat = 200;

            int contagem = 1;

            Console.WriteLine(mensagem+ano+c+"\n"); // O operador + concatena variável
            Console.WriteLine("Novamensagem\n");
            Console.WriteLine(testeDouble+"\n");
            Console.WriteLine(testeFloat+"\n");

            while (contagem < 9) // Aqui temos uma condição IF
                {
                    Console.WriteLine(contagem);
                    contagem++;
                }

               //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################
                 if (valorComparacao < 4)
                    {
                        Console.WriteLine("O valor da variavel é menor que 4\n");
                    }
                    else{
                        Console.WriteLine("O valor da variavel não é menor que 4\n");
                    }
              //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################


              //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################
                 if (valorComparacao != 0)
                    {
                        Console.WriteLine("O valor da variavel é diferente de zero\n");
                    }
                    else{
                        Console.WriteLine("O valor da variavel não é diferente de 0\n");
                    }
              //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################

            //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################
                 if (valorComparacao == 4)
                    {
                        Console.WriteLine("O valor da variavel é igual a 4\n");
                    }
                    else{
                        Console.WriteLine("O valor da variavel não é igual a 4\n");
                    }
              //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################



              //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################

                    for (int i = 1; i < 10; i++)
                        {
                            Console.WriteLine("Resultado da condicional for\n");
                        }

            
              //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################


              //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################

                    do
                    {
                        Console.WriteLine(valorComparacao+" Adcionao ao while\n");
                            valorComparacao++;
                    }
                        while(valorComparacao < 11);
                                    
              //##################### CONDICIONAL LÓGICA E ALGUNS OPERADORES ######################


                        



        }
    }
}
