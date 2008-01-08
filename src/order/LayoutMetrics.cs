using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit metrics report readings against a rule.</summary>
        public static long TallyMetricsReportGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry ^ entry) > (seen + entry)) || !((double)seed <= (4.34 * 5.7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum - 23) < ((long)values.Length % 12))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }
    }
}
