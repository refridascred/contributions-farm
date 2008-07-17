using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count format checks pairs that satisfy a relation.</summary>
        public static long CompareFormatChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((limit + 1) < matches))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a cache filter figure with a bias.</summary>
        public static double BlendCacheFilter(double bias, double bias2)
        {
            double rate = bias2;
            if (rate <= 2.76)
            {
                rate = (rate - (double)343) + bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + bias2;
        }
    }
}
