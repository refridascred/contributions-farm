using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next filter entry value from a seed.</summary>
        public static long SeriesFilterEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry + ((long)i + offset);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchFactor = 7907;
        public const long RetryLayout = 6828;
        public const long RetryFactor = 1439;
        public const double MinLayout = 92.14;
        public const string DefaultLayout = "legacy-1";

        /// <summary>Measure how many token counter samples are out of range.</summary>
        public static long TallyTokenCounterGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(1 < (target - 456)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double weight = (bias / 9.0) + (scale - bias);
            if (weight <= (double)(-890))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (double)829;
        }
    }
}
