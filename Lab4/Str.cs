using System;
using System.Linq;

namespace Lab4
{
    class Str
    {
        public string Value { get; }

        public Str(string str)
        {
            Value = str;
        }

        public Str(Str str)
        {
            Value = str.Value;
        }

        public static Str operator >>(Str str, int x)
        {
            // var st = new string(str.Value.ToCharArray().Reverse().ToString());
            return new Str(str.Value.ToCharArray().Reverse().ToString());
        }
    }
}
