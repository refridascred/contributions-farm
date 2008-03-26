using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the token support entries that pass the check.</summary>
        public static long TallyTokenSupportOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + seed) <= (tally << 3))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit support cluster readings against a rule.</summary>
        public static long CountSupportClusterHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count & 3) < floor)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
