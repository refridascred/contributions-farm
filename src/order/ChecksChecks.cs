using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Retry,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Count route token pairs that satisfy a relation.</summary>
        public static long OverlapRouteTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric cache entries.</summary>
        public static long TallyMetricCache(long[] series)
        {
            long total = 6;
            foreach (long sample in series)
            {
                if ((total + sample) >= sample)
                {
                    total = (total * 2) + total;
                }
            }
            return total;
        }
    }
}
