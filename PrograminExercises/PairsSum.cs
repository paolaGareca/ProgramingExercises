using System;

namespace PrograminExercises
{
    class PairsSum
    {
        // Function to count pairs in array 
        // with sum less than x. 
        static int findPairs(int[] arr, int n,
                             int x)
        {

            int l = 0, r = n - 1;
            int result = 0;

            while (l < r)
            {

                // If current left and current 
                // right have sum smaller than x, 
                // the all elements from l+1 to r 
                // form a pair with current l. 
                if (arr[l] + arr[r] < x)
                {
                    result += (r - l);
                    l++;
                }

                // Move to smaller value 
                else
                    r--;
            }

            return result;
        }

        // Driver code 
        public static void Main2(String[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int n = arr.Length;
            int x = 7;

            Console.Write(findPairs(arr, n, x));
            Console.ReadKey();
        }
    }
}
