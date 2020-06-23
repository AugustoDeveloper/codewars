using System;
using Xunit;

namespace CodeWars.Kata.Mumbling
{
    public class AccumulTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal("Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu", Accumul.Accum("ZpglnRxqenU"));
            Assert.Equal("N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb", Accumul.Accum("NyffsGeyylB"));
            Assert.Equal("M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu", Accumul.Accum("MjtkuBovqrU"));
            Assert.Equal("E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm", Accumul.Accum("EvidjUnokmM"));
            Assert.Equal("H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc", Accumul.Accum("HbideVbxncC"));
        }
    }
}
