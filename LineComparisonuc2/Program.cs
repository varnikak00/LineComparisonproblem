using System;

namespace LineComparisonuc2
{
    class Program
    {
        static string Main(string[] args, object line1)
        {
            string result;
            result = NewMethod(line1);
            return result;
        }

        private static string NewMethod(object line1)
        {
            string result;
        // Comparison made to same variable
             if (line1 == line1)
            // Comparison made to same variable
            {
                result = "Lines are equal";
            }
            else if (line1 > line1)
            {
                result = "line 1 is bigger line 2";
            }
            else
            {
                result = "line 2 is bigger line 1";
            }

            return result;
        }
    }
    }
}
