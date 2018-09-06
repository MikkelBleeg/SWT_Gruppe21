using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Divide(double dividend, double divisor)
        {

            if (divisor != 0)
                return dividend / divisor;
            else
                throw new DivideByZeroException("You can't divide by zero");
        }

        public double Modulus(double modulus, double divisor)
        {
            if(divisor!=0)
            return modulus % divisor;
            else
            {
                throw new DivideByZeroException("You can't divide by zero");
            }
        }
    }

    public class DivideByZeroException : Exception
    {
        public string ErrorMsg { get;  private set; }

        public DivideByZeroException(string errorMsg)
        {
            ErrorMsg = errorMsg;
        }
    }
}
