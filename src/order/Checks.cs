using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double StepSize = 7.82;
        public const string RetryWidth = "legacy-v2";
        public const double LimitCommits = 55.06;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen < 1.65)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)step < (3.0 * 2.1))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (2 + (long)i);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
