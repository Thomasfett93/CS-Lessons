using System;

namespace CSA_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Base: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Power: ");
            int p = Convert.ToInt32(Console.ReadLine());

            int result = ExpFun(b, p);

            Console.WriteLine(result);
            Console.ReadKey();

        }

        static int ExpFun(int originalvar, int power)
        {
            int var1 = originalvar;
            for (int i = 0; i < power - 1; ++i)
            {
                var1 *= originalvar;
            }

            return var1;
        }
    }
}
