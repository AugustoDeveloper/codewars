using System.Linq;

namespace CodeWars.Kata.FindTheOddInt
{
    static public class Kata
    {
        static public int FindIt(int[] sequence)
        =>  sequence
                .Select(k => new { K = k,  c = sequence.Count(x => x == k) })
                .Where(x => x.c % 2 != 0)
                .Max(x => x.K);
    }
}