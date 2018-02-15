using System;
using System.Text;

namespace Dumm2
{
    public class Fibonacci
    {
        public static string GetDefaultSequence()
        {
            var result = new StringBuilder();
            int a = 0;
            int b = 1;

            for (int i = 0; i < 10; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                var toAppend = a.ToString();
                result.Append(toAppend);
                if (i < 9)
                {
                    result.Append(", ");
                }
            }


            return result.ToString();
        }

        public static string GetSequenceByNumber(int number)
        {
            var result = new StringBuilder();
            int a = 0;
            int b = 1;

            for (int i = 0; i <= number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                var toAppend = a.ToString();
                result.Append(toAppend);
                if (i < number)
                {
                    result.Append(", ");
                }
            }


            return result.ToString();
        }

    }
}
