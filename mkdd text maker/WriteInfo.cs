﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkdd_text_maker
{
    public class WriteInfo
    {
        String text;
        Image image;
        int letter;
        int word; 
        String pre;
        double squeeze;
        bool small;
        int align;

        public WriteInfo(String t, Image i, int l, int w, String p, double d, bool s, int a)
        {
            text = t;
            image = i;
            letter = l;
            word = w;
            pre = p;
            squeeze = d;
            small = s;
            align = a;
        }

        public WriteInfo()
        {

        }

       public  String getText() { return text; }
        public Image getImage() { return image; }
        public String getpre() { return pre; }
        public int getletter() { return letter; }
        public int getword() { return word; }
        public double getsqueeze() { return squeeze; }
        public bool getsmall() { return small; }
        public int getalign() { return align; }
    }
}