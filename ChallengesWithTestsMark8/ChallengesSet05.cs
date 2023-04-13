using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber += 1;
            while((startNumber) % n != 0)
            {
                startNumber += 1;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            List<int> numList = new List<int>();

            if (numbers == null || numbers.Count() == 0)
            {
                return false;

            }
            else
            {
                foreach (int num in numbers)
                {
                    numList.Add(num);
                }
                numList.Sort();
                return Enumerable.SequenceEqual(numbers, numList);
            }

        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int followSum = 0;

            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i + 1 < numbers.Length)
                    {
                        var j = (numbers[i] % 2 == 0) ? followSum += numbers[i + 1] : followSum;
                    }
                }
                return followSum;
            }

            else
            {
                return 0;
            }

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words != null && words.Length !=0)
            {
                string sent = "";
                string sentScrap = "";
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == "" || words[i] == " ")
                    {
                        sentScrap += words[i];
                    }

                    else
                    {
                        sent += (words[i].Replace(" ","").Trim()) + " ";
                    }
                }

                return (sent == "") ? "": sent.Replace("  ", " ").Trim() + ".";
            }

            else
            {
                return "";
            }
            
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> everyFourth = new List<double>();

            if (elements != null)
            {
                for (int i = 3; i < elements.Count; i += 4)
                {
                    everyFourth.Add(elements[i]);
                }
                
            }
            return everyFourth.ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool isTarget = false;
       
            foreach(var num in nums)
            {
                for (int i=0; i < nums.Length; i++)
                {
                    if (Array.IndexOf(nums, num) != i)
                    {
                        if (nums[i] + num == targetNumber)
                        {
                            isTarget = true;
                        }
                    }
                    
                }
            }
            return isTarget;
           
        }
    }
}
