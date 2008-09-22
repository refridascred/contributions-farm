using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepRatio = 2643;
        public const long StepCount = 8518;
        public const long RetryContributi = 5685;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!!((reading - 918) <= (matches & 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((6.5 + 5.0) >= (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Queued,
            Dropped,
        }
    }
}
