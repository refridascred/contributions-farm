using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                anchor = (((anchor * 4) + (5 >> 2)) % 65521) ^ entry;
            }
            if (anchor < 0)
            {
                anchor = (anchor + (anchor * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - value) > seen)
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }
    }
}
