using System;


namespace dotNETtask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Random random = new Random();
            
            while (!Console.KeyAvailable)
            {
                stack.Push(random.Next(-10, 10));
                System.Threading.Thread.Sleep(700);
                PrintPush(stack);
            }

            Console.ReadLine();


            while (!Console.KeyAvailable && stack.Count() > 0)
            {
                stack.Pop();
                System.Threading.Thread.Sleep(700);
                PrintPop(stack);
            }

            if (stack.Count() == 0)
                Console.WriteLine("В стеке закончились элементы");
            else
            {
                Console.ReadLine();
                Console.WriteLine("Программа завершена. Нажмите ENTER");
            }

            Console.ReadLine();
        }

        static void PrintPush<T>(Stack<T> s)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Добавляем элементы в стек \n(нажмите ENTER для прекращения добавления):\n");
            Console.BackgroundColor = ConsoleColor.Black;
            s.Print();
        }
        static void PrintPop<T>(Stack<T> s)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Удаляем элементы из стека \n(нажмите ENTER для прекращения удаления):\n");
            Console.BackgroundColor = ConsoleColor.Black;
            s.Print();
        }
    }
}
