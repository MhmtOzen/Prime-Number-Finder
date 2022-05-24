﻿using System;
using System.Linq;

namespace Prime_Number_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi = 0; 

            while (true)
            {
                if (IsPrime(sayi))
                    Console.WriteLine(sayi);

                sayi++;

                System.Threading.Thread.Sleep(50);
            }

        }

        static bool IsPrime(int n)
        {
            if (n > 1)
                return Enumerable.Range(1, n).Where(x => n % x == 0).SequenceEqual(new[] { 1, n });

            return false;
        }
    }
}
