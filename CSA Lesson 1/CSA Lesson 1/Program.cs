using System;

namespace CSA_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverse = ToReverse(Console.ReadLine());
            Console.WriteLine(reverse);
            Console.ReadKey();

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
