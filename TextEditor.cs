using System;

namespace MyApp
{
    public static class TextEditor
    {
        public static void MenuTextEditor()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1- Abrir arquivo");
            Console.WriteLine("2- Criar novo arquivo");
            Console.WriteLine("3- Voltar");
            short option = short.Parse(Console.ReadLine()!);

            switch(option)
            {
                case 1: Open(); break;
                case 2: Edit(); break;
                case 3: Menu.Start(); break;
                default: MenuTextEditor(); break;
            }
        }

        public static void Open()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path!))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.ReadLine();
            MenuTextEditor();
        }

        public static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        public static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path!))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            MenuTextEditor();
        }
    }
}