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
                case 2: Create(); break;
                default: Menu(); break;
            }

            Console.WriteLine();
            Console.ReadKey();
            Menu();
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("What is the file path?");

            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
        }

        static void Create()
        {
            Console.Clear();
            Console.WriteLine("Enter your text below (ESC to leave)");
            Console.WriteLine("------------------");

            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("What is the path to save the file?");
            var path = Console.ReadLine();
            //abre e fecha o arquivo ou conexao de bd etc
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
                Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            }
        }
    }
}
