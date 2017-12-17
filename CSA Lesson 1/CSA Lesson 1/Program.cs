using System;

namespace CSA_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            string CurrentWord = "";
            string Result = "";
            for (int i = 0; i < myString.Length; ++i)
            {
                if (myString[i] == ' ' || i == myString.Length - 1)
                {
                    if (i == myString.Length - 1)
                    {
                        CurrentWord += myString[i];
                    }

                    char first = CurrentWord[0];
                    CurrentWord = CurrentWord.Substring(1);
                    CurrentWord += first + "ay";
                    Result += CurrentWord + " ";
                    CurrentWord = "";
                }
                else
                {
                    CurrentWord += myString[i];
                }
            }


            Console.WriteLine(Result);
            Console.ReadKey();

        }
        
    }
}
