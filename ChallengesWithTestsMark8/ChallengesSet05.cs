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
            // return ((startNumber / n) + 1) * n;
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
            //businesses.Where(x => x.TotalRevenue == 0).ToList().ForEach(x => x.Name = "CLOSED");
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
            //return (numbers == null || numbers.Length == 0) ? false : !numbers.Skip(1).Select((item, index) => numbers[index] <= numbers[index + 1]).Any(x => x == false);
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

            // return numbers == null ? 0: numbers.Skip(1).Where((item, index) => numbers[index] % 2 == 0).Sum();

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words != null && words.Length != 0)
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
                        sent += (words[i].Replace(" ", "").Trim()) + " ";
                    }
                }

                return (sent == "") ? "" : sent.Replace("  ", " ").Trim() + ".";
            }

            else
            {
                return "";
            }

            //return (words == null || words.Length == 0 || (words.Aggregate((x,y) => x.Trim() + " " + y.Trim()) + ".").Count() == 2) ? "" : words.Aggregate((x,y) => x.Trim() + " " + y.Trim()) + ".";
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
            // return elements == null ? new double[0] : elements.Where((item, index) => (index + 1) % 4 == 0).ToArray();
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
            //return nums.Select((n1, idx) => new { n1, n2 = nums.Take(idx).FirstOrDefault(n2 => n1 + n2 == targetNumber)}).Where(pair => pair.n2 != 0);
    }
}
}
