using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Matrix
    {
        private int[,] values;
        public int Lines { get => values.GetLength(0); }
        public int Columns { get => values.GetLength(1); }

        public int this[int line, int column]
        {
            get => values[line, column];
            set => values[line, column] = value;
        }

        public Matrix(int lines, int columns)
        {
            values = new int[lines, columns];

            for (int line = 0; line < Lines; line++)  // проход по строкам результирующей матрицы
            {
                for (int column = 0; column < Columns; column++)  // проход по столбцам результирующей матрицы
                {
                    this[line, column] = 0;
                }
            }
        }

        public static Matrix Multiplication(Matrix first, Matrix second)
        {
            if (first.Columns != second.Lines) throw new ArgumentException("Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В.");
            var res = new Matrix(first.Lines, second.Columns);

            for (int line = 0; line < res.Lines; line++)  // проход по строкам результирующей матрицы
            {
                for (int column = 0; column < res.Columns; column++)  // проход по столбцам результирующей матрицы
                {
                    int value = 0;
                    for (int i = 0; i < first.Columns; i++)  // вычисление значения ячейки результирующей матрицы
                    {
                        value += first[line, i] * second[i, column];
                    }
                    res[line, column] = value;
                }
            }

            return res;
        }

        public static Matrix MultiplicationParallel(Matrix first, Matrix second, int? inRows = null, int? inColumns = null, int? inSuboperations = null)
        {
            if (first.Columns != second.Lines) throw new ArgumentException("Произведение двух матриц АВ имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В.");
            var res = new Matrix(first.Lines, second.Columns);

            if (res.Lines > 500)
                Parallel.For(0, res.Lines, (inLine) => res.Multiply_ProcessALine(first, second, inLine));
            else for (int line = 0; line < res.Lines; line++)  // проход по строкам результирующей матрицы
                {
                    res.Multiply_ProcessALine(first, second, line);
                }

            return res;
        }

        private void Multiply_ProcessALine(Matrix first, Matrix second, int inLine)
        {
            if (second.Columns > 500)
                Parallel.For(0, this.Columns, (inColumn) => this.Multiply_ProcessAColumn(first, second, inLine, inColumn));
            else for (int column = 0; column < this.Columns; column++)  // проход по строкам результирующей матрицы
                {
                    this.Multiply_ProcessAColumn(first, second, inLine, column);
                }
        }

        private void Multiply_ProcessAColumn(Matrix first, Matrix second, int inLine, int inColumn)
        {
            //if (first.Columns > 500)
            //    Parallel.For(0, first.Columns, (i) => this[inLine, inColumn] += first[inLine, i] * second[i, inColumn]);
            //else
                for(int i = 0; i < first.Columns; i++)
                {
                    this[inLine, inColumn] += first[inLine, i] * second[i, inColumn];
                }
        }

        private static int Multiply_ProcessAPair(Matrix first, Matrix second, int inLine, int inColumn, int pair)
        {
            return first[inLine, pair] * second[pair, inColumn];
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            return Multiplication(first, second);
        }

        public static bool operator ==(Matrix left, Matrix right)
        {
            if (left.Lines != right.Lines || left.Columns != right.Columns) throw new ArgumentException("Сравниваться должны равноразмерные матрицы.");

            for (int line = 0; line < left.Lines; line++)  // проход по строкам результирующей матрицы
            {
                for (int column = 0; column < left.Columns; column++)  // проход по столбцам результирующей матрицы
                {
                    if (left[line, column] != right[line, column]) return false;
                }
            }
            return true;
        }
        public static bool operator !=(Matrix left, Matrix right)
        {
            if (left.Lines != right.Lines || left.Columns != right.Columns) throw new ArgumentException("Сравниваться должны равноразмерные матрицы.");

            for (int line = 0; line < left.Lines; line++)  // проход по строкам результирующей матрицы
            {
                for (int column = 0; column < left.Columns; column++)  // проход по столбцам результирующей матрицы
                {
                    if (left[line, column] != right[line, column]) return true;
                }
            }
            return false;
        }
    }
}
