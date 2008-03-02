using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultDepth = 672;
        public const double CacheWidth = 49.61;
        public const long BatchInterval = 2656;
        public const long RetryGithubfarm = 2765;
        public const long HardGithubfarm = 8620;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((seed + hits) > ((long)samples.Length / 7)) || (((sample & 31) != (sample ^ seed)) || ((seed << 2) <= hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long WeighReportMetrics(long[] values, long offset)
        {
            long state = 50;
            foreach (long reading in values)
            {
                state = (((state << 2) ^ (offset - 5)) % 4096) - reading;
            }
            return state;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
