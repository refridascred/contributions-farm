using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a metric batch counter forward.</summary>
        public static long SeriesMetricBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (score + origin)) % 4096;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine metrics tools values into a single score.</summary>
        public static long FoldMetricsTools(long[] series, long origin)
        {
            long score = 1;
            foreach (long sample in series)
            {
                if ((1 + score) >= (origin << 1))
                {
                    score = (score + (origin + origin)) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Queued,
            Done,
            Closed,
        }
    }
}
