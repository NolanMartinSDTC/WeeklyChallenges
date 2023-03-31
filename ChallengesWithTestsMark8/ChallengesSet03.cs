using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool tf in vals)
            {
                if (tf == false)
                {
                    return true;
                    
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int oddSum = 0;

            if (numbers == null)
            {
                return false;
            }

            foreach (int i in numbers)
            {
                if (Math.Abs(i % 2) == 1)
                {
                    oddSum += i;
                }
            }
            
            return (Math.Abs(oddSum) % 2 == 1);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;

            foreach (char letter in password)
            {
                if (char.IsUpper(letter))
                {
                    containsUpper = true;
                }
                else if (char.IsLower(letter))
                {
                    containsLower = true;
                }
                else if (char.IsNumber(letter))
                {
                    containsNumber = true;
                }
            }

            return ((containsUpper == true) && (containsLower == true) && (containsNumber == true));
           
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            

            return (divisor == 0) ? 0: dividend / divisor;

            // (-inf, 0) or (0, inf) divided by zero yields +/- infinity, not zero
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int count = 0;
            int[] oddsBelow100 = new int[50];

            for (int num = 1; num < 100; num++)
            {
                if (num % 2 == 1)
                {
                    oddsBelow100[count] = num;
                    count++;
                }
            }
            return oddsBelow100;
        }


        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToString().ToUpper();
            }
            

                        
        }
    }
}
