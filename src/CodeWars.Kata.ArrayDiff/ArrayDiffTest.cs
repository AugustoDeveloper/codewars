using System;
using Xunit;

namespace CodeWars.Kata.ArrayDiff
{
    public class ArrayDiffTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(new int[] {2},       ArrayDiff.Diff(new int[] {1, 2},    new int[] {1}));
            Assert.Equal(new int[] {2, 2},    ArrayDiff.Diff(new int[] {1, 2, 2}, new int[] {1}));
            Assert.Equal(new int[] {1},       ArrayDiff.Diff(new int[] {1, 2, 2}, new int[] {2}));
            Assert.Equal(new int[] {1, 2, 2}, ArrayDiff.Diff(new int[] {1, 2, 2}, new int[] {}));
            Assert.Equal(new int[] {},        ArrayDiff.Diff(new int[] {},        new int[] {1, 2}));
        }
    }
}
