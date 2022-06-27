using System;
using static AssaySortO_n_.Algorythm;

namespace AssaySortO_n_
{
    public class Tester
    {
        static void Main(string[] args)
        {

            const int LENGTH = 99999;
            int n = 1568;
            int[] sorted = new int[LENGTH];
            for (int i = 0; i < LENGTH; i++)
            {
                sorted[i] = i/2;
            }
            Console.WriteLine($"{n} is in index: " + TernarySearch(sorted, n));

            //---------------------------------------------------------------
            int[] sortedMissing = new int[] {1,2,3,4,5,6,7,8,9,10,11,13,14,15,16,17,18 };
            Console.WriteLine(MissingNumOn(sortedMissing));
            Console.WriteLine(MissingNumOlogn(sortedMissing));

            Console.ReadLine();
        }
    }
}