﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb1
{
    class Complex
    {
        int a;
        int b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }//added 
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex res = new Complex(0, 0);

            res.a = c1.a + c2.a;
            res.b = c1.b + c2.b;

            return res;
        }
        public override string ToString()
        {
            return string.Format("{0} + {1}i", a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(5, 6);
            Console.WriteLine(c);
        }
    }
}