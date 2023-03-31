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
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
