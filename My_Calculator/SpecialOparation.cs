using System;

namespace My_Calculator
{
    class SpecialOparation 
    {
        //Input variable
        public bool spOparationPressed = false;
        private string oparateKey;
        private double value1;
        private double value2;

        public string show;
        public double secondValue
        {
            get { return value2; }
            set
            {
                if (oparateKey != "root")
                {
                    value2 = value;
                }
                else
                {
                    value2 = 1 / value;
                }
            }
        }

        public double StartOparation(string oparationKey, double value = 0)
        {
            switch (oparationKey.ToLower())
            {
                case "sqrt":
                    show = oparationKey + "(" + value + ")";
                    value = Math.Sqrt(value);
                    break;
                case "sqr":
                    show = value + "^" + 2;
                    value = Math.Pow(value, 2);
                    break;
                case "pow":
                    show = value + oparationKey;
                    oparateKey = oparationKey;
                    value1 = value;
                    spOparationPressed = true;
                    break;
                case "root":
                    show = value + oparationKey;
                    oparateKey = oparationKey;
                    value1 = value;
                    spOparationPressed = true;
                    break;
                case "sin":
                    show = "sin " + value;
                    value = Math.Sin(value * Math.PI/180);
                    break;
                case "cos":
                    show = "cos " + value + "&deg";
                    value = Math.Cos(value * Math.PI / 180);
                    break;
                case "tan":
                    show = "Tan " + value + "&deg";
                    if (value != 90)
                    {
                        value = Math.Tan(value * Math.PI / 180);
                    }
                    else
                        value = Double.PositiveInfinity;
                    break;
                case "sin-":
                    show = "Sin- " + value;
                    value = Math.Asin(value) * 180 / Math.PI;
                    break;
                case "cos-":
                    show = "Cos- " + value;
                    value = Math.Acos(value) * 180 / Math.PI;
                    break;
                case "tan-":
                    show = "Tan- " + value;
                    value = Math.Atan(value) * 180 / Math.PI;
                    break;
                case "log10":
                    show = "Log10 ~ " + value;
                    value = Math.Log10(value);
                    break;
                case "log":
                    show = "Log " + value + "; Base: ";
                    oparateKey = oparationKey;
                    value1 = value;
                    spOparationPressed = true;
                    break;
                case "exp":
                    value = Math.Exp(value);
                    break;
                case "%":
                    show = value + "%";
                    value = value / 100;
                    break;
                case "pi":
                    show = "PI";
                    value = Math.PI;
                    break;
                case "+-":
                    value = -value;
                    break;
                default:
                    break;
            }
            return value;
        }

        public double Oparation()
        {
            spOparationPressed = false;
            switch (oparateKey)
            {
                case "pow":
                case "root":
                    return Math.Pow(value1, value2);
                case "log":
                    show += value2;
                    return Math.Log(value1, value2);
                default:
                    return 0;
            }
        }
    }
}
