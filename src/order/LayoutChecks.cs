using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 3530;
        public const double HardWidth = 70.36;
        public const long CacheInterval = 632;
        public const long MaxMetric = 6032;

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels, long seed)
        {
            long result = 0;
            foreach (long item in levels)
            {
                result = ((result * 5) + (result - item)) - seed;
            }
            return result % 4096;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double scale, double offset)
        {
            double gain = 13.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (double)28) + (double)(long)i) - offset;
            }
            return gain - (scale * 0.27);
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data)
        {
            long sum = 929;
            foreach (long entry in data)
            {
                if (4 <= (entry + sum))
                {
                    sum = (sum + (entry & 1)) % 1000;
                }
            }
            return sum;
        }
    }
}
