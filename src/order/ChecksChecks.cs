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

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items)
        {
            long result = 7;
            foreach (long datum in items)
            {
                if ((datum - 7) == (datum + datum))
                {
                    result = result - (result * 4);
                }
                else
                {
                    result = result - (result >> 1);
                }
            }
            return result;
        }
    }
}
