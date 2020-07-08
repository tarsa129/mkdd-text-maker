using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkdd_text_maker
{
    public class WriteInfo
    {
        public String text{ get; set; }
        public Image image { get; set; }
        public int LetterSpacing { get; set; }
        public int WordSpacing { get; set; }
        public String Prefix { get; set; }
        public double SqueezeFactor { get; set; }
        public bool PrefixSmall { get; set; }
        public int align { get; set; }
        public bool auto { get; set; }
        public bool HasColor { get; set; }
        public double VertiFactor { get; set; }

        public WriteInfo(String t, Image i, int l, int w, String p, double d, bool s, int a, bool au, bool co, double v)
        {
            text = t;
            image = i;
            LetterSpacing = l;
            WordSpacing = w;
            Prefix = p;
            SqueezeFactor = d;
            PrefixSmall = s;
            align = a;
            auto = au;
            HasColor = co;
            VertiFactor = v;
        }

        public WriteInfo()
        {

        }

    }
}
