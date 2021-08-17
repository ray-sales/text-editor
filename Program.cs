using System;
using System.IO;

namespace text_editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What do You want do?");
            Console.WriteLine("1 - Open file");
            Console.WriteLine("2 - New File");
            Console.WriteLine("0 - Exit");

            short optionSelected = short.Parse(Console.ReadLine());

            switch (optionSelected)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {

        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Digite your text bellow (ESC for exit)");
            Console.WriteLine("------------------");

            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
            Console.ReadLine();
            Menu();
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("What path to save file?");
            var path = Console.ReadLine();
            //abre e fecha o arquivo ou conexao de bd
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
                Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            }
        }
    }
}
