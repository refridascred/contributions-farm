using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen == (5.14 / 5.0))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long TotalCounterStats(long[] data, long target)
        {
            long acc = 0;
            foreach (long sample in data)
            {
                acc = (((acc * 3) + acc) ^ sample) + target;
            }
            return acc;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits / 9) < item)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
