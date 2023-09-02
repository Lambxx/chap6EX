using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6EX
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // Write a program that impliments insertion sort 

        public void insertionSort_ex1(int[] arr) {
            for (int i = 1; i < (arr.Length - 1); i++) {
               int Key = arr[i];
                int j = i - 1;
                while ((j >= 0)&&(Key< arr[j])) {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = Key;


            
            }
        }
    }
}
