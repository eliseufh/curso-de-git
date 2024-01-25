using System;

namespace MyApp
{
    public static class Calculator
    {
        public static void MenuCalculator()
        {
            Console.Clear();
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Multiplicação");
            Console.WriteLine("5- Voltar");
            Console.WriteLine("");
            Console.WriteLine("Qual operação deseja fazer?");
            short option = short.Parse(Console.ReadLine()!);

            switch(option)
            {
                case 1: Addition(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: Menu.Start(); break;
                default: MenuCalculator(); break;
            }
        }

        public static void Addition()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            Console.WriteLine("Segundo valor: ");
            double num2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            double result = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {result}.");
            Console.ReadKey();
            MenuCalculator();
        }

        public static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            Console.WriteLine("Segundo valor: ");
            double num2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            double result = num1 - num2;
            Console.WriteLine($"O resultado da subtração é: {result}.");
            Console.ReadKey();
            MenuCalculator();
        }

        public static void Division()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            Console.WriteLine("Segundo valor: ");
            double num2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            double result = num1 / num2;
            Console.WriteLine($"O resultado da divisão é: {result}.");
            Console.ReadKey();
            MenuCalculator();
        }

        public static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            Console.WriteLine("Segundo valor: ");
            double num2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            double result = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é: {result}.");
            Console.ReadKey();
            MenuCalculator();
        }
    }
}