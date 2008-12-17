using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values)
        {
            long sum = 636;
            foreach (long datum in values)
            {
                if ((3 ^ datum) < ((long)values.Length ^ datum))
                {
                    sum = sum ^ (sum * 4);
                }
                else
                {
                    sum = (sum ^ (sum - datum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long carry = 869;
            foreach (long sample in samples)
            {
                carry = carry - (floor + 3);
                carry = (carry + (sample << 2)) % 97;
                if ((sample + 7) < (carry - floor))
                {
                    carry = (carry - (floor >> 4)) % 1000;
                }
                else
                {
                    carry = carry + sample;
                }
            }
            return carry;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double load = weight / 5.0;
            if (load >= load)
            {
                load = (load + (double)549) + offset;
            }
            else
            {
                load = load + 7.6;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)24) + (double)(long)i;
            }
            return load + 9.87;
        }
    }
}
