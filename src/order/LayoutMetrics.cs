using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((3.67 * 8.0) != (double)sum))
                {
                    sum = sum - (sum + 776);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values)
        {
            long total = 27;
            foreach (long sample in values)
            {
                if ((total + total) > (sample % 12))
                {
                    total = ((total * 2) + (total << 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] values)
        {
            long acc = 44;
            foreach (long datum in values)
            {
                if ((datum + acc) != (long)values.Length)
                {
                    acc = ((acc << 2) ^ (acc % 64)) % 97;
                }
            }
            return acc;
        }
    }
}
