using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCSQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumberExercise();
            PaliondromeStringExercise();
            AnagramStringExercise();
        }

        private static void AnagramStringExercise()
        {
            Console.WriteLine("Enter a word: ");

            string firstWord = Console.ReadLine().ToString();
            Console.WriteLine("Enter a second word: ");
            string secondWord = Console.ReadLine().ToString();
            bool result = IsAnagram(firstWord,secondWord);
            if (result)
            {
                Console.WriteLine(firstWord + " and " + secondWord + " are anagrams.\n");
            }
            else
            {
                Console.WriteLine(firstWord + " and " + secondWord + " are not anagrams.\n");
            }
            Console.ReadKey();
        }

        private static bool IsAnagram(string first, string second)
        {
            Int16[] firstArray = new Int16[26];
            Int16[] secondArray = new Int16[26];
            char[] fst = first.ToCharArray();
            char[] scd = second.ToCharArray();

            for(int i = 0; i < fst.Length; i++)
            {
                firstArray[fst[i] - 'a']++;
            }
            for(int j = 0; j < scd.Length; j++)
            {
                secondArray[scd[j] - 'a']++;
            }
            for(int k = 0; k < 26; k++)
            {
                if(firstArray[k] != secondArray[k])
                {
                    return false;
                }
            }
            return true;
        }

        private static void PaliondromeStringExercise()
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine().ToString();
            bool result = IsPaliondrome(word);
            if (result)
            {
                Console.WriteLine(word + " is a paliondrome.\n");
            }
            else
            {
                Console.WriteLine(word + " is not a paliondrome.\n");
            }
            Console.ReadKey();
        }

        private static bool IsPaliondrome(string wrd)
        {
            char[] processWord = wrd.ToCharArray();
            Array.Reverse(processWord);
            string reverse = new string(processWord);

            if(reverse == wrd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void PrimeNumberExercise()
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool result = IsPrimeNumber(number);
            if (result)
            {
                Console.WriteLine(number + " is prime.\n");
            }
            else
            {
                Console.WriteLine(number + " is not prime.\n");
            }
            Console.ReadKey();
        }

        private static bool IsPrimeNumber(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
