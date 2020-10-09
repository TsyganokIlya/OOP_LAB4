using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class FUN
    {
        public static readonly Random rand;

        static FUN()
        {
            rand = new Random(DateTime.Now.Millisecond);
        }

        

        static void Main(string[] args)
        {
            list A = new list(rand.Next(2, 7));
            list B = new list(rand.Next(2, 7));

            Console.WriteLine($"[A] Пользователь: {A.owner}\tДата создания: {A.cDate}\n" + A);
            Console.WriteLine($"[B] Пользователь: {B.owner}\tДата создания: {B.cDate}\n" + B + "\n");

            Console.WriteLine($"Объединение: " + (A + B));
            Console.WriteLine($"Сравнение: " + (A == B));
            Console.WriteLine($"Удаление первого элемента: " + (-A));
            Console.WriteLine($"Пустой ли список: " + (~A));
        }
    }
}
