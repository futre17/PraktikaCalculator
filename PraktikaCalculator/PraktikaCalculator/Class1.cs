using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaCalculator
{
    static class Class1
    {
       public static calculator2 cal2(int count)
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
                default:
                    return new PLUS();

            }
            
        }
    }
    interface calculator2
    {
        double Calculate(double firstValue, double secondValue);
    }
    class PLUS : calculator2
    {
       public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
    class MINUS : calculator2
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
    class DIVITION : calculator2
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
    class MULTIPLY : calculator2
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
    static class Class2
    {

        public static calculator1 cal1(int count)
        {
            switch (count)
            {
                case 5:
                    return new TG();
                case 6:
                    return new CTG();
                default:
                    return new TG(); // заглушка "для невозможного варианта"
            }
        }
    }

    interface calculator1
    {
        double Calculate(double firstValue);
    }

    class TG : calculator1
    {
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
    class CTG : calculator1
    {
        public double Calculate(double firstValue)
        {
            return 1/Math.Tan(firstValue);
        }
    }
}
