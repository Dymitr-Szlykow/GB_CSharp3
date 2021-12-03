using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static readonly Random rand = new Random();
        static Stopwatch timer = new Stopwatch();
        static readonly int size = 1000;

        static string[] filenames = { "data1.txt", "data2.txt", "data3.txt", "data4.txt", "data5.txt", "data6.txt", "data7.txt" };
        static int linesNumber = 1000;

        static void Main(string[] args)
        {
            Task1();
            _ = Console.ReadLine();
            Console.Clear();
            Task2();
            _ = Console.ReadLine();
        }

        public static void Task1()
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

            Console.WriteLine("\nПроизведение матриц топорное:");
            timer.Restart();
            c = a * b;
            timer.Stop();
            RepresentMatrix(c);
            Console.WriteLine($"\tвремя: {timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks})");

            Console.WriteLine("\nПроизведение матриц параллельное:");
            timer.Restart();
            d = Matrix.MultiplicationParallel(a, b);
            timer.Stop();
            RepresentMatrix(d);
            Console.WriteLine($"\tвремя: {timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks})");
            Console.WriteLine("\nДва результата умножения {0}равны.", c == d ? "" : "не ");
            Console.WriteLine();
        }

        public static void Task2()
        {
            _ = Parallel.For(0, filenames.Length, i =>
            {
                if (File.Exists(filenames[i])) LoadFile(filenames[i]);
                else
                {
                    GenerateFile(filenames[i]);
                }
            });

        }

        #region ЗАДАЧА 1
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
        #endregion

        #region ЗАДАЧА 2
        public static void LoadFile(string path)
        {
            timer.Restart();
            var res = new List<double>(linesNumber);
            using var reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + path);
            while (!reader.EndOfStream)
            {
                string[] temp = reader.ReadLine().Split(' ');
                if (!double.TryParse(temp[1], out double a)) throw new FormatException();
                else if (!double.TryParse(temp[2], out double b)) throw new FormatException();
                else
                {
                    if (temp[0] == "1") res.Add(a * b);
                    else if (temp[0] == "2") res.Add(a / b);
                    else throw new FormatException();
                }
            }
            timer.Stop();
            Console.WriteLine($"Файл {path} обработан за {timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks})");
        }

        public static void GenerateFile(string path)
        {
            timer.Restart();
            var random = new Random();
            string[] senselessData = new string[linesNumber];

            for (int i = 0; i < linesNumber; i++)
            {
                senselessData[i] = string.Format($"{rand.Next(1,3)} {rand.NextDouble()} {rand.NextDouble()}");
            }
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + path, senselessData);

            timer.Stop();
            Console.WriteLine($"Файл создан за {timer.ElapsedMilliseconds} мс ({timer.ElapsedTicks})");
        }
        #endregion
    }
}
