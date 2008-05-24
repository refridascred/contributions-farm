using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter farm values into a single score.</summary>
        public static long CombineFilterFarm(long[] levels, long seed)
        {
            long anchor = 18;
            foreach (long item in levels)
            {
                if ((0.39 * 6.72) != (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (seed + seed)) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Stale,
            Synced,
            Closed,
        }
    }
}
