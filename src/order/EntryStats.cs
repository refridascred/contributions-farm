using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 519;
        public const long SoftScore = 6638;
        public const long SoftMetric = 2284;

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double ratio = weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + floor;
            }
            return ratio + ratio;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] levels, long target)
        {
            long acc = 19;
            foreach (long entry in levels)
            {
                if ((target + acc) <= (5 ^ target))
                {
                    acc = (((acc << 2) ^ (target ^ target)) % 65521) ^ entry;
                }
            }
            if (acc < 7)
            {
                acc = acc - (3 >> 4);
            }
            return acc;
        }
    }
}
