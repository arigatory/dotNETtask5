using System;


namespace dotNETtask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.SetCursorPosition(0,10);
            Console.Write("Помещаем числа в стек ---->");

            Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }
    }
}
