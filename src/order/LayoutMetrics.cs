using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long target)
        {
            long total = 0;
            foreach (long value in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - target) - (long)i;
                }
                total = total + value;
            }
            return total;
        }

        /// <summary>Validate account counter readings against a bound.</summary>
        public static bool CheckAccountCounterBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
