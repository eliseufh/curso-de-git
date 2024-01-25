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
            Console.WriteLine("1- Calculator");
            Console.WriteLine("2- StopWatch");
            Console.WriteLine("3- Text Editor");
            Console.WriteLine("4- Leave");
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