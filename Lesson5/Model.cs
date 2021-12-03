using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    public class Model
    {
        public ulong FactorialStart(ulong number)
        {
            if (number < 0) throw new ArgumentException("Число для исчисления факториала должно быть целым неотрицательным.");
            else if (number < 2) return 1;
            else return FactorialOf(number);
        }

        public ulong FactorialOf(ulong num)
        {
            if (num == 2) return num;
            else return num * FactorialOf(num - 1);
        }

        public ulong Summa(ulong number)
        {
            if (number < 0) throw new ArgumentException("Число для исчисления суммы должно быть целым неотрицательным.");
            else if (number == 0) return 0;
            else
            {
                ulong sum = 0;
                for (ulong i = 0; i <= number; i++) sum += i;
                return sum;
            }
        }


        public int FindAllEven(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) res++;
            }
            return res;
        }

        public int FindAll3n5Aliquots(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 15 == 0) res++;
            }
            return res;
        }

        public int FindAllPrimes(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPrime(array[i])) res++;
            }
            return res;
        }

        public int FindAllPowersOfTwo(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPowerOfTwo(array[i])) res++;
            }
            return res;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            else if (number == 2) return true;
            else if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public bool IsPowerOfTwo(int number)
        {
            return (number > 0) && ((number & (number - 1)) == 0);
        }
    }
}
