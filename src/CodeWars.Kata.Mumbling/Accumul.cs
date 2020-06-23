using System.Text;

namespace CodeWars.Kata.Mumbling
{
    static public class Accumul
    {
        static public string Accum(string s)
        {
            s = s.ToUpper();
            var builder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                var firstChar = new string(s[i],1);
                var accumChars = new string(s[i], i);
                builder
                .Append(firstChar)
                .Append(accumChars.ToLower())
                .Append(i != s.Length -1 ? "-" : "");
            }
            return builder.ToString();
        }
    }
}