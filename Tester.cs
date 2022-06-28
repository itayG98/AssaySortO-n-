using static AssaySortO_n_.Algorythm;

namespace AssaySortO_n_
{
    public class Tester
    {
        static void Main(string[] args)
        {


            int[] sorted1 = new int[] { 1,400,1000 };
            int[] sorted2 = new int[] { 0,4,5,6,7,8,9,15,20,67,400,100,200,456,1000};
            int[] sorted3 = new int[] { 1 };
            int checkn = 456;
            int[] singelDigitArr = new int[] { 1 };
            int[] sortedNotMissing = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] sortedMissing = new int[] { 1, 2, 3, 5 };


            Console.WriteLine($"{checkn} is in index: " + TernarySearch(sorted1, checkn));
            Console.WriteLine($"{checkn} is in index: " + TernarySearch(sorted2, checkn));
            Console.WriteLine($"{checkn} is in index: " + TernarySearch(sorted3, checkn));
            Console.WriteLine($"{1} is in index: " + TernarySearch(sorted1, 1));
            Console.WriteLine($"{1} is in index: " + TernarySearch(sorted2, 1));
            Console.WriteLine($"{1} is in index: " + TernarySearch(sorted3, 1));

            //---------------------------------------------------------------

            /*            Console.WriteLine(MissingNumOn(singelDigitArr));
            *//*            Console.WriteLine(MissingNumOlogn(sortedNotMissing));
                        Console.WriteLine(MissingNumOlogn(sortedMissing));*/

            //---------------------------------------------------------------
            /*
                        int[] moved = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                        Console.WriteLine(FindMax(moved));
                        moved = new int[] { 7, 8, 1, 2, 3, 4, 5, 6 };
                        Console.WriteLine(FindMax(moved));
                        moved = new int[] { 8, 3, 4, 5, 6, 7 };
                        Console.WriteLine(FindMax(moved));*/

            Console.ReadLine();
        }
    }
}