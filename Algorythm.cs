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
            while (a <= d + 2)
            {
                if (num >= arr[a] && num <= arr[b])
                {
                    if (arr[a] == num)
                    {
                        return a;
                    }
                    else if (arr[b] == num)
                    {
                        return b;
                    }
                    a++;
                    d = --b;
                }
                else if (num > arr[b] && num <= arr[c])
                {
                    if (arr[c] == num)
                    {
                        return c;
                    }
                    a = b++;
                    d = --c;
                }
                else if (num > arr[c] && num <= arr[d])
                {
                    if (arr[d] == num)
                    {
                        return d;
                    }
                    a = c++;
                    --d;
                }
                else
                {
                    break;
                }
                b = (d - a) / 3 + a;
                c = (d - a) * 2 / 3 + a;
            }
            return -1;
        }

        public static int MissingNumOn(int[] arr)
        /*Finds the miising num in O(n)*/

        {
            if (arr.Length > 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] - 1 != i)
                        return arr[i] - 1;
                }
            }
            return -1;
        }
        public static int MissingNumOlogn(int[] arr)
        /*Finds the mising num in O(log(n))*/
        {
            int left = 0, right = arr.Length - 1, middle = (right + left) / 2;
            if (arr.Length > 1)
            {
                while (left <= right)
                {
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
            }
            return -1;
        }

        public static int FindMax(int[] arr)
        /*Assume sorted array moved array[i]===> array[(i+s)%Length]
         Find the max in O(log(n) Tme complexity)*/
        {
            int left = 0, right = arr.Length - 1, middle = (left + right) / 2;
            while (left <= right)
            {
                if (arr[left] > arr[middle])
                    right = middle;
                if (arr[left] < arr[middle])
                    left = middle;
                middle = (left + right) / 2;
                if (left == right - 1)
                    break;
            }
            return arr[left] > arr[right] ? arr[left] : arr[right];
        }
    }
}
