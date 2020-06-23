using System.Linq;
namespace CodeWars.Kata.ArrayDiff
{
    public class ArrayDiff
    {
        public static int[] Diff(int[] a, int[] b)
            => a.Length == 0 ? 
                new int[]{ } : 
                a.Where(i => !b.Any(j => i == j))
                .ToArray();
 
    }
}