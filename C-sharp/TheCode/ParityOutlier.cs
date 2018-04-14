using System.Collections.Generic;
using System.Linq;

namespace TheCode
{
    public class ParityOutlier
    {
        /*
            You are given an array (which will have a length of at least 3, but could be very large) containing integers.
            The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. 
            Write a method that takes the array as an argument and returns this "outlier" N.
         */

        public static int Find(int[] integers)
        {
            int? result = null;
            var odds = new List<int>();
            var evens = new List<int>();
            for (int i = 0; i < integers.Length && !result.HasValue; i++)
            {
                int currInteger = integers[i];
                if (currInteger % 2 == 0)
                    evens.Add(currInteger);
                else
                    odds.Add(currInteger);

                if (evens.Count > 1)
                {
                    //N is odd
                    result = odds.Any() ? odds[0] : FindParity(integers, false);
                }
                else if (odds.Count > 1)
                {
                    //N is even
                    result = evens.Any() ? evens[0] : FindParity(integers, true);
                }

                //else: we can' determine N yet
            }

            return result ?? -1;
        }

        private static int? FindParity(int[] integers, bool findEven)
        {
            return integers.Single(i => (i % 2 == 0) == findEven);
        }

        /*
            Best found solution:

            public static int Find(int[] arr)
            {
                int n = arr.Take(3).Count(i => i % 2 == 0) > 1 ? 1 : 0;
                return arr.First(i => i % 2 == n);
            }
         */
    }
}
