using System;
using Xunit;

namespace CodeWars.Kata.FindTheOddInt
{
    public class FindTheOddIntTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(5, Kata.FindIt(new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }));
        }
    }
}
