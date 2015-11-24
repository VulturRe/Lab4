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
            return new Str(new string(str.Value.ToCharArray().Reverse().ToArray()));
        }

        public static Str operator ++(Str str)
        {
            var st = str.Value.Split(' ');
            var min = st[0];
            foreach (var s in st.Where(s => s.Length < min.Length))
                min = s;
            return new Str(min);
        }

        public override string ToString()
        {
            return ($"{Value}");
        }
    }
}
