using System;
using System.Diagnostics;

namespace Lesson6
{
    class Program
    {
        static readonly Random rand = new Random();
        static Stopwatch timer = new Stopwatch();
        static readonly int size = 1000;

        static void Main(string[] args)
        {
            Matrix a, b, c, d;

            Console.WriteLine("Нажмите любую кнопку...\n");
            _ = Console.ReadKey(true);

            Console.WriteLine("Исходная случайная матрица 1):");
            RepresentMatrix(a = MakeRandomMatrix(size, size, ref timer));
            Console.WriteLine($"\tвремя: {timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks})");

            Console.WriteLine("\nИсходная случайная матрица 2):");
            RepresentMatrix(b = MakeRandomMatrix(size, size, ref timer));
            Console.WriteLine($"\tвремя: {timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks})");

            Console.WriteLine("\nПроизведение матриц 1) и 2) топорное:");
            timer.Restart();
            c = a * b;
            timer.Stop();
            RepresentMatrix(c);
            Console.WriteLine($"\tвремя: {timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks})");

            Console.WriteLine("\nПроизведение матриц 1) и 2) параллельное:");
            timer.Restart();
            d = Matrix.MultiplicationParallel(a, b);
            timer.Stop();
            RepresentMatrix(d);
            Console.WriteLine($"\tвремя: {timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks})");
            Console.WriteLine("\nДва результата умножения {0}равны.", c == d ? "" : "не ");
            Console.WriteLine();
        }

        public static Matrix MakeRandomMatrix(int lines, int columns, ref Stopwatch timer)
        {
            var res = new Matrix(lines, columns);

            timer.Restart();
            for (int line = 0; line < lines; line++)
            {
                for (int column = 0; column < columns; column++)
                {
                    res[line, column] = rand.Next(-9, 10);
                }
            }
            timer.Stop();
            return res;
        }

        public static void RepresentMatrix(Matrix a)
        {
            for (int line = 0; line < a.Lines; line++)
            {
                if (line > 20)
                {
                    Console.Write("\t   ...\n");
                    break;
                }

                Console.Write("\t");
                for (int column = 0; column < a.Columns; column++)
                {
                    if (Console.CursorLeft > Console.WindowWidth - 13)
                    {
                        Console.Write("...");
                        break;
                    }
                    Console.Write("{0,6}", a[line, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
