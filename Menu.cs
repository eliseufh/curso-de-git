using System;

namespace MyApp
{
    public static class Menu
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO MENU DE PROJETOS FEITOS NO CURSO DO BALTA!");
            Console.WriteLine("made by: Eliseu Silva");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1- Calculadora");
            Console.WriteLine("2- Cronômetro");
            Console.WriteLine("3- Editor de Texto");
            Console.WriteLine("4- Sair");
            Console.WriteLine("");
            Console.WriteLine("Qual opção deseja escolher?");
            short option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1: Calculator.MenuCalculator(); break;
                case 2: StopWatch.MenuStopWatch(); break;
                case 3: TextEditor.MenuTextEditor(); break;
                case 4: System.Environment.Exit(0); break;
                default: Start(); break;
            }
        }
    }
}