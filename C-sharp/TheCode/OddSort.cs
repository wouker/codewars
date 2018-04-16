using System.Linq;

namespace TheCode
{
    public class OddSort
    {
        /*
         You have an array of numbers.
         Your task is to sort ascending odd numbers but even numbers must be on their places.
         Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.
         */

        public static int[] SortArray(int[] array)
        {
            var list = array.ToList();
            var result = list.Where(a => a % 2 != 0).OrderBy(a => a).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var nmbr = list[i];
                if (nmbr % 2 == 0)
                    result.Insert(i, nmbr);
            }
            return result.ToArray();
        }

        /*
            Best solution:

            Queue<int> odds = new Queue<int>(array.Where(e => e%2 == 1).OrderBy(e => e));
            return array.Select(e => e%2 == 1 ? odds.Dequeue() : e).ToArray();
         */
    }
}
