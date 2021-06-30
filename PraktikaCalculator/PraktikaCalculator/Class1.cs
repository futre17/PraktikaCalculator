using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaCalculator
{
    class Class1 : Form1
    {
       public static object calculator(int count)
        {
            switch (count)
            {
                case 1:
                    return new PLUS();
                case 2 :
                    return new MINUS();
                case 3:
                    return new DIVITION();
                case 4:
                    return new MULTIPLY();
                case 5:
                    return new TG();
                case 6:
                    return new CTG();
                default:
                    return 0;

            }
            
        }
    }
    interface calculator
    {
        double Calculate(double firstValue, double secondValue);
    }
    class PLUS : calculator
    {
       public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
    class MINUS : calculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
    class DIVITION : calculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
    class MULTIPLY : calculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
    class TG : calculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Tan(firstValue);
        }
    }
    class CTG : calculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return 1/Math.Tan(firstValue);
        }
    }
}
