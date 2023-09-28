using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator
{   public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op, double num3=0.0)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                case "MTBF":
                    result = MTBF(num1, num2);
                    break;
                case "Availability":
                    result = Availability(num1, num2);
                    break;
                case "tcrf":
                    result = CurrentFailureIntensity(num1, num2, num3);
                    break;
                case "tavgef":
                    result = AverageNumberOfExpectedFailures(num1, num2, num3);
                    break;
                case "dd":
                    result = CalculateDefectDensity(num1, num2);
                    break;
                case "ssi":
                    result = CalculateNewSSI(num1, num2, num3);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }

        // Check if a string is a valid binary representation
        public bool IsBinary(string s)
        {
            foreach (char c in s)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }

        // Convert a binary string to its decimal equivalent
        public int ConvertBinaryStringToDecimal(string num1Str, string num2Str)
        {
            if (!IsBinary(num1Str) || !IsBinary(num2Str)) {
                throw new ArgumentException("The string is not a valid binary representation.");
            }
    
            string combinedBinary = num1Str + num2Str;
            return Convert.ToInt32(combinedBinary, 2);
        }

        public double Add(double num1, double num2)
        {
            // Convert the numbers to strings without any decimal points
            string num1Str = num1.ToString("F0");
            string num2Str = num2.ToString("F0");
            
            if (IsBinary(num1Str) && IsBinary(num2Str)) // If both can be converted to binary sequence return their decimal sequence
            {
                int result = ConvertBinaryStringToDecimal(num1Str, num2Str);
                return result;
            }

            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                // Both numbers are 0
                return 1;
            }

            if (num2 == 0)
            {
                // Quotient is non-zero and Divisor is 0 
                return double.PositiveInfinity;
            }

            if (num1 == 0)
            {
                return 0;
            }

            return num1 / num2;
        }

        public double Factorial(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            
            if (num % 1 != 0)
            {
                throw new ArgumentException("Factorial cannot contain decimal point.");
            }
   
            if (num == 0)
            {
                return 1; // Factorial of 0 is defined as 1.
            }

            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }

        public double CalculateTriangleArea(double height, double length)
        {
            if (height < 0 || length < 0)
            {
                throw new ArgumentException("Height and length must be non-negative.");
            }

            return 0.5 * height * length;
        }

        public double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be non-negative.");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        public double UnknownFunctionA(double a, double b)
        {
            if (a < 0 || b < 0 || (a < b))
            {
                throw new ArgumentException("Both operands must be non-negative and a cannot be smaller than b");
            }

            // Calculate the first factorial
            double factorialNum1 = Factorial(a);

            // Calculate the second factorial
            double factorialNum2 = Factorial(a - b);

            return factorialNum1 / factorialNum2;
        }

        public double UnknownFunctionB(double a, double b)
        {
            if (a < 0 || b < 0 || (a < b))
            {
                throw new ArgumentException("Both operands must be non-negative and a cannot be smaller than b");
            }

            double factorialNum1 = Factorial(a);
            double factorialNum2 = Factorial(b);
            double factorialNum3 = Factorial(a - b);
            double divisor = factorialNum2 * factorialNum3;
            return factorialNum1 / divisor;
        }

        public double MTBF(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Availability(double num1, double num2)
        {
            return Math.Round(((num1 / num2) * 100), 1);
        }
        public double CurrentFailureIntensity(double initialFailure, double averageFailure, double totalFailure)
        {
            double result = initialFailure * (1 - (averageFailure / totalFailure));
            return Math.Round(result);
        }

        public double AverageNumberOfExpectedFailures(double totalFailure, double initialFailure, double time)
        {
            double result = totalFailure * (1 - Math.Exp((-(initialFailure / totalFailure) * time)));
            return Math.Round(result);
        }

        public double CalculateDefectDensity(double totalDefects, double totalLOC)
        {
            if (totalDefects == 0)
            {
                return -1;
            }
            double defectDensity = (totalDefects / totalLOC);
           
            return defectDensity;
        }

        public double CalculateNewSSI(double previousSSI, double newLinesOfCode, double deletedLinesOfCode)
        {
            double newSSI = previousSSI + newLinesOfCode - deletedLinesOfCode;
            return newSSI;
        }
    }
}
