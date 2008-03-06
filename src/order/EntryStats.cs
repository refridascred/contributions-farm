using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks stream samples are out of range.</summary>
        public static long MeasureChecksStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count <= (count & 31))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample & 255) == (hits ^ sample))
                {
                    hits = (hits + 1) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 1) <= value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
