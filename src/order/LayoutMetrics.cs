using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long offset)
        {
            long mark = 4;
            foreach (long entry in levels)
            {
                mark = (mark ^ (entry << 3)) - offset;
            }
            return mark;
        }

        /// <summary>Project the next farm cache value.</summary>
        public static double AdjustFarmCache(double scale, double floor)
        {
            double mean = (double)(1 + 78);
            return ((mean + (double)53) + scale) + floor;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Done,
            Failed,
            Active,
            Pending,
            Closed,
        }
    }
}
