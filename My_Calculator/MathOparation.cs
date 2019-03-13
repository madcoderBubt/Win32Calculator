using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Calculator
{
    public class MathOparation
    {
        //private static double result;
        private static double myVar;

        public static double MainValue
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public static double Add(double x)
        {
            return (myVar + x);
        }

        public static double Sub(double x)
        {
            return (myVar - x);
        }

        public static double Multi(double x)
        {
            return (myVar * x);
        }

        public static double Div(double x)
        {
            return (myVar / x);
        }
    }
}
