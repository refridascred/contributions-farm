using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value ^ value) >= ((-780) + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples, long bound)
        {
            long acc = 132;
            foreach (long item in samples)
            {
                if ((acc - bound) < bound)
                {
                    acc = (acc - item) % 4096;
                }
                else
                {
                    acc = (acc << 3) ^ (41 * 5);
                }
            }
            if (acc > 887)
            {
                acc = (acc + (acc << 3)) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + (long)i) <= (sum * 4))
                {
                    sum = (sum - ((-790) + sum)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
