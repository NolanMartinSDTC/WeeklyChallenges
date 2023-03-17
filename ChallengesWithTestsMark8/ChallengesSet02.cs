using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (Math.Abs(num) % 2 == 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null)
            {
                if (numbers.Sum() == 0)
                {
                    return 0;
                }


                else
                {
                    return (numbers.Min() + numbers.Max());
                }
            }

            else
            {
                return 0;
            }
        }   

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Count();
            int length2 = str2.Count();
            if (length1 > length2)
            {
                return length2;
            }
            else if (length1 < length2)
            {
                return length1;
            }
            else
            {
                return length1;
            }
        }

        public int Sum(int[] numbers)
        {
            int sumArray = 0;

            if (numbers == null)
            {
                return sumArray;
            }

            foreach(int i in numbers)
            {
                sumArray += i;
            }
            return sumArray;
        }

        public int SumEvens(int[] numbers)
        {
            int evenSum = 0;

            if (numbers == null)
            {
                return evenSum;
            }

            foreach (int number in numbers)
            {
                if (number%2 == 0)
                {
                    evenSum += number;
                }
            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        { 
            bool oddSum = false;
            if (numbers == null)
            {
                oddSum = false;
            }

            else if (Math.Abs(numbers.Sum()) % 2 == 1)
            {
                oddSum = true;
            }

            return oddSum;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

            long count = 0;

            for (int i = 1; i < number; i++)
            {
                if (i > 0 && i % 2 == 1)
                {
                    count += 1;
                }
            }
            return count; 
        }
    }
}
