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

            // if (string.Equals(words, null) || words.Contains(null))
            //{
            //return false;
            //}

            if(words == null)
            {
                return contWord;
            }

            else if(ignoreCase == false)
            {
                // containsWord = words.Contains(word)

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
                // word = word.ToLower();
                // List<string> lc = words.Select(x => x.ToLower()).ToList();
                // containsWord = lc.Contains(word)
                

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

            // return (ignoreCase) ? words?.Select(x=>x?.ToLower()).Contains(word) ?? false : words?.Contains(word) ?? false;
            
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

            // return (num <= 1) ? false : Enumerable.Range(2, (int)Math.Sqrt(num) - 1).All(divisor => num % divisor ! = 0);
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //int index = -1;
            //bool uIndex;

            //for (var i = 0; i < str.Length; i++)
            //{
            //    uIndex = true;

            //    for (var j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j] && i != j)
            //        {
            //            uIndex = false;
            //        }
            //    }

            //    if (uIndex == true)
            //    {
            //        index = i;
            //    }
            //}

            //return index;
            return str.IndexOf(str.Distinct().Reverse().Where(x => str.Where(y => y.Equals(x)).Count() == 1).FirstOrDefault());

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            //int maxCount = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int tempCount = 1;
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            tempCount += 1;
            //            if (tempCount > maxCount)
            //            {
            //                maxCount = tempCount;
            //            }
            //        }
            //    }

            //}
            //return maxCount;

            int count = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
            
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
