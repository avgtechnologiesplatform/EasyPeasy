using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyPeasyWebApp
{
    enum enumOp
    {
        Add = 0,
        Sub,
        Mul,
        Div
    };

    public class Calc
    {
        public Calc()
        { }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return Add(a, -1 * b);
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}