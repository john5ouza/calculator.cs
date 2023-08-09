using System;

namespace Calculator
{
    class Program
    {
        static void Main(){

        Menu();

        }

        static void Menu(){

            Console.Clear();

            Console.WriteLine("WELCOME TO C#LCULATOR");

            Console.WriteLine("----------------------------------");

            Console.WriteLine("TYPE [1] FOR ADDITION");
            Console.WriteLine("TYPE [2] FOR SUBTRACTION");
            Console.WriteLine("TYPE [3] FOR MULTIPLICATION");
            Console.WriteLine("TYPE [4] FOR DIVISION");
            Console.WriteLine("TYPE [5] FOR EXIT");

            Console.WriteLine("----------------------------------");

            Console.WriteLine("TYPE THE OPERATION OPTION");
            short menuOption = short.Parse(Console.ReadLine());

            switch(menuOption)
            {
                case 1: Addition(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: System.Environment.Exit(0); break;
                // case 5: Exit(); break;
                default: Menu(); break;

            }

        }

        static void Addition()
        {

            Console.Clear();

            Console.WriteLine("WELCOME TO ADDITION C#LCULATOR");

            Console.WriteLine("----------------------------------");

            Console.Write("FIRST NUMBER: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("SECOND NUMBER: ");
            float n2 = float.Parse(Console.ReadLine());

            float result = n1 + n2;

            Console.WriteLine("----------------------------------");

            Console.WriteLine($"THE RESULT ADDITION IS: {result}");

            Console.ReadKey();

            Menu();

        }

        static void Subtraction()
        {

            Console.Clear();

            Console.WriteLine("WELCOME TO SUBTRACTION C#LCULATOR");

            Console.WriteLine("----------------------------------");

            Console.Write("FIRST NUMBER: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("SECOND NUMBER: ");
            float n2 = float.Parse(Console.ReadLine());

            float result = n1 - n2;

            Console.WriteLine("----------------------------------");

            Console.WriteLine($"THE RESULT SUBTRACTION IS: {result}");

            Console.ReadKey();

            Menu();

        }

        static void Multiplication()
        {

            Console.Clear();

            Console.WriteLine("WELCOME TO MULTIPLICATION C#LCULATOR");

            Console.WriteLine("----------------------------------");

            Console.Write("FIRST NUMBER: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("SECOND NUMBER: ");
            float n2 = float.Parse(Console.ReadLine());

            float result = n1 * n2;

            Console.WriteLine("----------------------------------");

            Console.WriteLine($"THE RESULT MULTIPLICATION IS: {result}");

            Console.ReadKey();

            Menu();

        }

        static void Division()
        {

            Console.Clear();

            Console.WriteLine("WELCOME TO DIVISION C#LCULATOR");

            Console.WriteLine("----------------------------------");

            Console.Write("FIRST NUMBER: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("SECOND NUMBER: ");
            float n2 = float.Parse(Console.ReadLine());

            float result = n1 / n2;

            Console.WriteLine("----------------------------------");

            Console.WriteLine($"THE RESULT DIVISION IS: {result}");

            Console.ReadKey();

            Menu();

        }

    }
}
