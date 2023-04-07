using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            for (int num = 0; num < numbers.Length; num++)
            {
                sum = (numbers[num] % 2 == 0) ? (sum + numbers[num]) : (sum - numbers[num]);
            }
            return sum;


        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lengthList = new List<int>();

            lengthList.Add(str1.Length);
            lengthList.Add(str2.Length);
            lengthList.Add(str3.Length);
            lengthList.Add(str4.Length);

            lengthList.Sort();

            return lengthList[0];

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            
           return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var lengthList = new List<int>{ sideLength1, sideLength2, sideLength3 };
            lengthList.Sort();


            bool longLineOfCode = ((sideLength1 <= 0) || (sideLength2 <= 0) || (sideLength3 <= 0)) ? false : (((lengthList[0] + lengthList[1]) > lengthList[2]) ? true : false);
            return longLineOfCode;
        }

        public bool IsStringANumber(string input)
        {
            bool tOrF = true;
            var test = (double.TryParse(input, out double num)) ? tOrF = true : tOrF = false;
            return tOrF;            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int isNull = 0;
            int notNull = 0;

            foreach (var item in objs)
            {
                int counter = (item == null) ? (isNull += 1) : (notNull += 1);
            }

            if (isNull > notNull)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double evenCount = 0.0;
            double evenSum = 0.0;

            if (numbers != null)
            {
                foreach (var num in numbers)
                {
                    var evenNums = (num % 2 == 0) ? evenSum += num : evenSum += 0;
                    var evenCounter = (num % 2 == 0) ? evenCount += 1 : evenCount += 0;

                }
                if (evenSum == 0.0 || evenCount == 0.0)
                {
                    return 0;
                }

                else
                {
                    return evenSum / evenCount;
                }
            }
            
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            else if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            else
            {
                int factorial = 1;
                for (int i = number; i > 0; i--)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
    }
}
