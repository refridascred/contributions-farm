using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((1.01 <= (double)seed) && ((count * 3) == (count - count))))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((score >> 2) <= (limit + (long)i))
                {
                    score = (score * 5) + (score ^ score);
                    score = (score - (limit << 3)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
