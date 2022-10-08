// using System;
// namespace calculator;

// Obs: static => métodos que não dependem de nenhuma variavel instânciada.
// void => Retorno vazio, o método não retorna nenhum valor.

class Project {
    static void Main(string[] args) {
       Menu();
    }

     // menu
        static void Menu() {
            Console.Clear();
            Console.WriteLine("*======== Menu da Calculadora :3 ========*\n");
            
            Console.WriteLine("O que deseja fazer?\n");
            
            Console.WriteLine("0 - Sair do Console");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação\n");
            Console.WriteLine("*=========================================*");
            Console.Write("Selecione Uma Opção >> ");
            short userAnswer = short.Parse( Console.ReadLine() );
            
            switch(userAnswer) {

                case 1: Som(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                default: Menu(); break;
            }
        }
        // Menu();

        // soma
        static void Som() {

            Console.Clear();
            Console.WriteLine("*========== Soma ==========*\n\n");

            Console.Write("Insira o Primero Valor >> ");
            double v1 = double.Parse( Console.ReadLine() );
        
            Console.Write("Insira o segundo valor >> ");
            double v2 = double.Parse( Console.ReadLine() );

            double result = v1 + v2;

            // Console.WriteLine("A soma dos valores é " + (v1 + v2));
            // Console.WriteLine("A soma dos valores é " + result);
            Console.WriteLine($"A soma dos resultados é {result}.");

            // Console.WriteLine(v1);
            // Console.WriteLine(v2);

            Console.ReadKey();
        }
        // Som();

        // Subtração
        static void Subtraction() {
            Console.Clear();
            Console.WriteLine("*========= Subtração =========*\n\n");

            Console.Write("Insira o primeiro valor >> ");
            double v1 = Double.Parse( Console.ReadLine() );

            Console.Write("Insira o segundo valor >> ");
            double v2 = Double.Parse( Console.ReadLine() );

            double result = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {result}.");
            
            Console.ReadKey();
        }
        // Subtraction();

        // Divisão
        static void Division() {
            Console.Clear();
            Console.WriteLine("*========== Divisão ==========*\n\n");

            Console.Write("Insira o primeiro valor >> ");
            double v1 = Double.Parse( Console.ReadLine() );

            Console.Write("Insira o segundo valor >> ");
            double v2 = Double.Parse( Console.ReadLine() );

            Console.WriteLine("O resultado é " + (v1 / v2) + ".");

            Console.ReadKey();

        }
        // Division();

        // multiplicação
        static void Multiplication() {
            Console.Clear();
            Console.WriteLine("*========= Multiplicação =========*\n\n");

            Console.Write("Insira o Primeiro valor >> ");
            double v1 = Double.Parse( Console.ReadLine() );

            Console.Write("Insira o segundo valor >> ");
            double v2 = Double.Parse( Console.ReadLine() );

            Console.WriteLine($"O resultado é {v1 * v2}.");
            Console.ReadKey();
        }
        // Multiplication();
}