using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum << 2) ^ (limit * 4)) % 97;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits ^ hits) < hits)
                {
                    hits = ((hits + 1) + datum) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
