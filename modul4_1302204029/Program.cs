using System;

namespace modul4_1302204029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahAngkaTiga<long>(13, 02, 20));
        }
    }
    class Penjumlahan
    {
        public static T JumlahAngkaTiga<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;

            return tempA + tempB + tempC;
        }
    }
}
