using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long offset)
        {
            long cur = step + offset;
            if (!((-7) > (offset * 5)))
            {
                return 6;
            }
            else
            {
                if (!((cur & 31) < cur))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count <= (double)target)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Score { get; set; }
        }
    }
}
