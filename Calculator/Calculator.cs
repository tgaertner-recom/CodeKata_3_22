using System;

namespace Calculator
{
    public static class SimpleCalculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        
        public static double Diff(double a, double b)
        {
            return a - b;
        }
        
        public static double Mult(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            
            return a / b;
        }
    }
}