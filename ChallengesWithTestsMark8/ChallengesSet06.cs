using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool contWord = false;

            if(words == null)
            {
                return contWord;
            }
            else if(ignoreCase == false)
            {
                foreach (string actualWord in words)
                {
                    if (actualWord == word)
                    {
                        contWord = true;
                    }
                }
            }
            else
            {
                foreach (string actualWord in words)
                {
                    if (actualWord != null)
                    {
                        if (actualWord.ToLower() == word)
                        {
                            contWord = true;
                        }
                    }
                }
            }

            return contWord;
            
        }

        public bool IsPrimeNumber(int num)
        {
            if (num > 1)
            {
                bool isPrime = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                    }
                }

                return isPrime;
            }

            else
            {
                return false;
            }

        }

        public int IndexOfLastUniqueLetter(string str)
        {
            foreach (char let in str)
            {
                int charCount = 0;

            }
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int tempCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        tempCount += 1;
                        if (tempCount > maxCount)
                        {
                            maxCount = tempCount;
                        }
                    }
                    //else
                    //{
                    //    tempCount = 0;
                    //}
                }

            }
            return maxCount;
            
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> everyNth = new List<double>();
            if (elements == null || n < 1)
            {
                return everyNth.ToArray();
            }
            else
            {
                for (int i = n-1; i < elements.Count; i += n)
                {
                    everyNth.Add(elements[i]);
                }
                return everyNth.ToArray();
            }
        }
    }
}
