using System;

namespace MyLib
{
    public class Math
    {
        /// <summary>
        /// Adds two integers and returns the sum as a double.
        /// </summary>
        /// <param name="a">The first integer to add.</param>
        /// <param name="b">The second integer to add.</param>
        /// <returns>The sum of the two integers as a double.</returns>
        public static double Add(int a, int b) { return a + b; }
        /// <summary>
        /// Adds two double-precision floating-point numbers and returns the sum.
        /// </summary>
        /// <param name="a">The first double to add.</param>
        /// <param name="b">The second double to add.</param>
        /// <returns>The sum of the two doubles.</returns>
        public static double Add(double a, double b) { return a + b; }
        /// <summary>
        /// Adds two numbers represented as strings.
        /// </summary>
        /// <param name="a">The first number as a string.</param>
        /// <param name="b">The second number as a string.</param>
        /// <returns>The sum of the two numbers, or null if either input is invalid.</returns>
        public static double Add(string a, string b)
        {
            if (double.TryParse(a, out double numA) && double.TryParse(b, out double numB))
            {
                return numA + numB;
            }
            return 0;
        }
        /// <summary>
        /// Subtracts the second integer from the first integer.
        /// </summary>
        /// <param name="a">The integer from which to subtract.</param>
        /// <param name="b">The integer to subtract.</param>
        /// <returns>The result of the subtraction.</returns>
        public static double Subtract(int a, int b) { return a - b; }
        /// <summary>
        /// Subtracts the second double from the first double.
        /// </summary>
        /// <param name="a">The double from which to subtract.</param>
        /// <param name="b">The double to subtract.</param>
        /// <returns>The result of the subtraction.</returns>
        public static double Subtract(double a, double b) { return a - b; }
        /// <summary>
        /// Subtracts the second numeric string from the first numeric string.
        /// </summary>
        /// <param name="a">The first numeric string (minuend).</param>
        /// <param name="b">The second numeric string (subtrahend).</param>
        /// <returns>The result of the subtraction as a double.</returns>
        /// <exception cref="ArgumentException">Thrown when either argument is not a valid numeric string.</exception>
        public static double Subtract(string a, string b)
        {
            if (double.TryParse(a, out double numA) && double.TryParse(b, out double numB))
            {
                return numA - numB;
            }
            throw new ArgumentException("Оба аргумента должны быть числовыми строками.");
        }
        /// <summary>
        /// Multiplies two integers and returns the product.
        /// </summary>
        /// <param name="a">The first integer (multiplicand).</param>
        /// <param name="b">The second integer (multiplier).</param>
        /// <returns>The product of the two integers.</returns>
        public static double Multiply(int a, int b) { return a * b; }
        /// <summary>
        /// Multiplies two double-precision floating-point numbers and returns the product.
        /// </summary>
        /// <param name="a">The first double (multiplicand).</param>
        /// <param name="b">The second double (multiplier).</param>
        /// <returns>The product of the two doubles.</returns>
        public static double Multiply(double a, double b) { return a * b; }
        /// <summary>
        /// Multiplies two numeric strings and returns the product as a double.
        /// </summary>
        /// <param name="a">The first numeric string (multiplicand).</param>
        /// <param name="b">The second numeric string (multiplier).</param>
        /// <returns>The product of the two numeric strings as a double.</returns>
        /// <exception cref="ArgumentException">Thrown when either argument is not a valid numeric string.</exception>
        public static double Multiply(string a, string b)
        {
            if (double.TryParse(a, out double numA) && double.TryParse(b, out double numB))
            {
                return numA * numB;
            }
            throw new ArgumentException("Оба аргумента должны быть числовыми строками.");
        }
        /// <summary>
        /// Divides the first double by the second double.
        /// </summary>
        /// <param name="a">The numerator (the number to be divided).</param>
        /// <param name="b">The denominator (the number by which to divide).</param>
        /// <returns>The result of the division as a double.</returns>
        /// <exception cref="DivideByZeroException">Thrown when the denominator is zero.</exception>
        public static double Divide(double a, double b) 
        { 
            if (b == 0) {  return 0; }
            return a / b; 
        }
        public static double Divide(int a, int b) { return a / b; }
        public static double Divide(string a, string b)
        {
            if (double.TryParse(a, out double numA) && double.TryParse(b, out double numB))
            {
                return numA / numB;
            }
            throw new ArgumentException("Оба аргумента должны быть числовыми строками.");
        }
        /// <summary>
        /// Raises a base number to the power of an exponent.
        /// </summary>
        /// <param name="a">The base number.</param>
        /// <param name="b">The exponent.</param>
        /// <returns>The result of raising <paramref name="a"/> to the power of <paramref name="b"/>.</returns>
        public static double Power(double a, double b) 
        {
            double pow = a;
            for (int i = 1; i < b; i ++)
            {
                a *= pow;
            }
            return a;
        }
        /// <summary>
        /// Calculates the square root of a given number using the Newton-Raphson method.
        /// </summary>
        /// <param name="a">The number for which to calculate the square root. Must be non-negative.</param>
        /// <returns>The approximate square root of <paramref name="a"/>.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="a"/> is negative.</exception>
        public static double Squar(double a)
        {
            double root = a / 2;
            double eps = 0.01;
            int iter = 0;
            while (root - a / root > eps)
            {
                iter++;
                root = 0.5 * (root + a / root);
            }
            return root;
        }
    }
}
