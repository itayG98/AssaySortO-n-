using System.Text;
using static AssaySortO_n_.Algorythm;

namespace AssaySortO_n_
{
    //Itay getahun 1017
    //Intro to Algo assay
    public class Tester
    {
        static void Main(string[] args)
        {

            int[] sorted1 = new int[] { 0, 400, 1000 };
            int[] sorted2 = new int[] { 1, 4, 5, 6, 7, 8, 9, 15, 20, 67, 100, 201, 456, 1000 };
            int[] sorted3 = new int[] { 1 };
            int checkn = 456;
            int[] singelDigitArr = new int[] { 1 };
            int[] sortedNotMissing = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] sortedMissing = new int[] { 1, 2, 3, 5 };
            int[] moved1 = new int[] { 9, 10, 2, 3, 4, 5, 6, 7, 8 };
            int[] moved2 = new int[] { 7, 8, 1, 2, 3, 4, 5, 6 };
            int[] moved3 = new int[] { 8, 3, 4, 5, 6, 7 };

            Console.WriteLine("Ternary search :\n--------------------");
            //---------------------------------------------------------------
            DisplayArr(sorted1);
            Console.WriteLine($"{checkn} is in index: " + TernarySearch(sorted1, checkn));
            Console.WriteLine($"{1} is in index: " + TernarySearch(sorted1, 1) + "\n");
            DisplayArr(sorted2);
            Console.WriteLine($"{checkn} is in index: " + TernarySearch(sorted2, checkn));
            Console.WriteLine($"{1} is in index: " + TernarySearch(sorted2, 1) + "\n");
            DisplayArr(sorted3);
            Console.WriteLine($"{checkn} is in index: " + TernarySearch(sorted3, checkn));
            Console.WriteLine($"{1} is in index: " + TernarySearch(sorted3, 1) + "\n");

/*            Console.WriteLine("\nSearching missin number in o(n) :\n--------------------");
            //---------------------------------------------------------------
            DisplayArr(singelDigitArr);
            Console.WriteLine(MissingNumOn(singelDigitArr));
            DisplayArr(sortedNotMissing);
            Console.WriteLine(MissingNumOn(sortedNotMissing));
            DisplayArr(sortedMissing);
            Console.WriteLine(MissingNumOn(sortedMissing));

            Console.WriteLine("\nSearching missin number in o(log(n)) :\n--------------------");
            //---------------------------------------------------------------
            DisplayArr(singelDigitArr);
            Console.WriteLine(MissingNumOlogn(singelDigitArr));
            DisplayArr(sortedNotMissing);
            Console.WriteLine(MissingNumOlogn(sortedNotMissing));
            DisplayArr(sortedMissing);
            Console.WriteLine(MissingNumOlogn(sortedMissing));


            Console.WriteLine("\nFind max :\n--------------------");
            //---------------------------------------------------------------
            DisplayArr(moved1);
            Console.WriteLine(FindMax(moved1));
            DisplayArr(moved2);
            Console.WriteLine(FindMax(moved2));
            DisplayArr(moved3);
            Console.WriteLine(FindMax(moved3));

            Console.ReadLine();*/
        }

        public static void DisplayArr(int[] arr)
        {
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}