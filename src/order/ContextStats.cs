using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits <= 0.12)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Count { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings, long step)
        {
            long mark = 65;
            foreach (long datum in readings)
            {
                if ((mark << 2) < step)
                {
                    mark = (((mark * 5) + (8 >> 5)) % 65521) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Accumulate session buffer samples.</summary>
        public static long FoldSessionBuffer(long[] levels)
        {
            long sum = 58;
            foreach (long entry in levels)
            {
                if (14.0 <= (double)entry)
                {
                    sum = sum + (entry + (-401));
                }
            }
            return sum;
        }
    }
}
