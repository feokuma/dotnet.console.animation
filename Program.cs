using System;
using System.Threading;
using System.IO;

namespace console.animation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Write("Building: ");
            char[] anims = new char[] { '/', '-', '\\', '|' };
            int animsIndex = 0;
            for (int n = 0; n < 100; n++)
            {
                Console.Write(anims[animsIndex]);
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                animsIndex++;
                if (animsIndex >= anims.Length)
                    animsIndex = 0;
            }

            Console.Write("Done!");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);
            Console.Write("     ");
            Console.SetCursorPosition(Console.CursorLeft - 5, Console.CursorTop);

            animsIndex = 0;
            for (int n = 0; n < 100; n++)
            {
                Console.Write(anims[animsIndex]);
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                animsIndex++;
                if (animsIndex >= anims.Length)
                    animsIndex = 0;
            }
        }
    }
}
