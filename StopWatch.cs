using System;

namespace MyApp
{
    public static class StopWatch
    {
        public static void MenuStopWatch()
        {
            Console.Clear();
            Console.WriteLine("S- Segundos(Exemplo: 10s)");
            Console.WriteLine("M- Minutos(Exemplo: 1m)");
            Console.WriteLine("0- Voltar");
            Console.WriteLine("");
            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine()!.ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                Menu.Start();

            PreStart(time * multiplier);
        }

        public static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go!");
            Thread.Sleep(1000);

            Start(time);
        }
        
        public static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.WriteLine("");
            Console.WriteLine("Cronômetro Finalizado.");
            Console.ReadKey();
            MenuStopWatch();
        }
    }
}