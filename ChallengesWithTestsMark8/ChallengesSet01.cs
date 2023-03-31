using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }

            // return (num1 == num2) ? true: false;
            // return (num1 == num2);
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double subResult = minuend-subtrahend;
            return subResult;
            // return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            int addResult = number1 + number2;
            return addResult;
            // return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number2;
            }
            else if (number2 > number1)
            {
                return number1;
            }
            else
            {
                return number1;
            }

            //return (number1 < number 2) ? number1: number2;
        }

        public long Multiply(long factor1, long factor2)
        {
            long prodResult = factor1 * factor2;
            return prodResult;
            // return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }

            else
            {
                return $"Hello, {nameOfPerson}!";
            }
            //return (nameOfPerson != string.Empty) ? $"Hello, {nameOfPerson}!" : "Hello!";
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
