using System;


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
     public class PLUS : calculator2
    {
       public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
    public class MINUS : calculator2
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
    public class DIVITION : calculator2
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
    public class MULTIPLY : calculator2
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

    public class TG : calculator1
    {
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
    public class CTG : calculator1
    {
        public double Calculate(double firstValue)
        {
            return 1/Math.Tan(firstValue);
        }
    }
}
