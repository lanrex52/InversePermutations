using System;

namespace InversePermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,4,3,2 };
            int size = arr.Length;
            inversePermutation(arr, size);
        }

        static void inversePermutation(int[] arr, int size)
        {
           
            // Loop to select Elements one by one
            for (int i = 0; i < size; i++)
            {

                // Loop to print position of element
                // where we find an element
                for (int j = 0; j < size; j++)
                {

                    // checking the element in
                    // increasing order
                    if (arr[j] == i + 1)
                    {
                       
                        Console.Write(j + 1 + " ");
                        break;
                    }
                }
            }
        }
    }
}
