using System;

namespace text_editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("What do You want do?");
            Console.WriteLine("1 - Open file");
            Console.WriteLine("2 - New File");
            Console.WriteLine("0 - Exit");

            short optionSelected = short.Parse(Console.ReadLine());

            switch(optionSelected){
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit();break;
                default: Menu(); break;
            }
        }

        static void Open(){

        }

        static void Edit(){
            Console.Clear();
            Console.WriteLine("Digite your text bellow (ESC for exit)");
            Console.WriteLine("------------------");

            string text = "";

            while(Console.ReadKey().Key != ConsoleKey.Escape){
                
            }
            
        }
    }
}
