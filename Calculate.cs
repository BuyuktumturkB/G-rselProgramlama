using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public static double Calculation(double x, double y, string operatorMath) 
        {
            double result = 0;
            switch (operatorMath) 
            {
                case "/":
                    result = x / y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "x":
                    result = x * y;
                    break;
                case "+":
                    result = x + y;
                    break;
                default:
                    break;
            }
            return result;

        }
    }
}
