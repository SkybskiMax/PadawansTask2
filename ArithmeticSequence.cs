using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException();
            }
            checked
            {
                int answer = 0;
                for (int i = 0; i < count; i++)
                {
                    answer = answer + number;
                    for (int j = 0; j < i; j++)
                    {
                        answer = answer + add;
                    }
                }
                return answer;
            }
        }
    }
}
