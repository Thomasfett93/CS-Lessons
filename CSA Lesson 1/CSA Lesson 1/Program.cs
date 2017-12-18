using System;
using System.Linq;

namespace CSA_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = Palindrome(Console.ReadLine());
            Console.WriteLine(response);
            Console.ReadKey();

        }

        static string Palindrome(string myString)
        {
            string reverse = ToReverse(myString);
            for (int i = 0; i < myString.Length; ++i)
            {
                if (myString[i] != reverse[i])
                {
                    return "No";
                }
            }
            return "*snaps* Yes!";
        }


        static int VowelCount(string myString)
        {
            string vowels = "aeiou";
            int num = 0;

            for (int i = 0; i < myString.Length; ++i)
            {
                if (vowels.Contains(myString[i]))
                {
                    num += 1;
                }

            }
            return num;
        }

        static string ToReverse(string myString)
        {
            string result = "";
            for (int i = myString.Length - 1; i >= 0; i--)
            {
                result += myString[i];
            }
            return result;

        }
        
        static string ToPigLatin(string myString)
        {
            string[] myArray = myString.Split(' ');

            string result = "";
            for (int i = 0; i < myArray.Length; ++i)
            {
                string temp = myArray[i];

                char first = temp[0];
                temp = temp.Substring(1);
                temp += first + "ay";
                result += temp + " ";
            }

            return result;
        }
        
        
    }
}
