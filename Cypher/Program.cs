using System;
using System.Text;

namespace Cypher
{
    public class Program
    {
        public static Random rand = new Random();

        public static string GetCypher(string toCypher, int key) => GetCypher(toCypher, key, null);
        public static string GetCypher(string toCypher, int key, int? expectedCapacity)
        {
            StringBuilder res;
            if (expectedCapacity == null) res = new StringBuilder();
            else res = new StringBuilder(expectedCapacity.Value);

            foreach (char ch in toCypher)
            {
                if (char.IsLetter(ch)) _ = res.Append((char)(ch + key));
                else _ = res.Append(ch);
            }
            return res.ToString();
        }


        static void Main(string[] args)
        {
            ProcessCypher();
            //Console.ReadLine();
        }

        public static void ProcessCypher()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GetCypher("Hello World!", rand.Next(1, 6)));
            Console.WriteLine(GetCypher("Hello World!", rand.Next(1, 6)));
            Console.WriteLine(GetCypher("Hello World!", rand.Next(1, 6)));
            Console.WriteLine(GetCypher("Hello World!", rand.Next(1, 6)));
        }
    }
}
