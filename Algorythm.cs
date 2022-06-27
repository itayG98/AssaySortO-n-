using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssaySortO_n_
{
    /*Itay Getahun 1070*/
    //Data Struct&Algo assay
    public static class Algorythm
    {
        public static int TernarySearch(int[] arr, int num)
        /*a----------b----------c------------d*/
        /*Ternary search Based on Binary search idea
         Assume sorted int[] arr*/
        //Time complexity of log(n/3)) == log(n)*log(1/3) == log(n)
        {
            if (num < arr[0] || num > arr[arr.Length - 1])
            {
                return -1;
            }
            int a = 0, b = arr.Length / 3, c = 2 * arr.Length / 3, d = arr.Length - 1;
            while (a <= d)
            {
                Console.WriteLine("iteration O(log(n))");
                if (d == a && a != num)
                {
                    return -1;
                }
                else if (arr[a] == num)
                {
                    return a;
                }
                else if (arr[b] == num)
                {
                    return b;
                }
                else if (arr[c] == num)
                {
                    return c;
                }
                else if (arr[d] == num)
                {
                    return d;
                }

                if (num > arr[a] && num < arr[b])
                {
                    a++;
                    d = --b;

                }
                else if (num > arr[b] && num < arr[c])
                {
                    a = b++;
                    d = --c;

                }
                else if (num > arr[c] && num < arr[d])
                {
                    a = c++;
                    --d;

                }
                b = (d - a) / 3 + a;
                c = (d - a) * 2 / 3 + a;
            }
            return -1;
        }

        public static int MissingNumOn(int[] arr)
        /*Finds the miising num in O(n)*/

        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("iteration O(n)");
                if (arr[i] - 1 != i)
                    return arr[i] - 1;
            }
            return -1;
        }
        public static int MissingNumOlogn(int[] arr)
        /*Finds the miising num in O(log(n))*/
        {
            int left = 0, right = arr.Length - 1, middle = (right + left) / 2;
            while (left <= right)
            {
                Console.WriteLine("iteration O(Log(n))");
                if (left == middle)
                {
                    if (arr[middle] + 1 == arr[right])
                        break;
                    else
                        return right + 1;
                }
                if (arr[middle] - 1 == middle)
                    left = middle;
                else
                    right = middle;
                middle = (left + right) / 2;
            }
            return -1;
        }
    }
}
