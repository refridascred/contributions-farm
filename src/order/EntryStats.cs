using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 9708;
        public const string BaseGithubfarm = "strict-1";
        public const long IdleInterval = 6826;
        public const long BurstSpan = 8693;

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftWidth = "staging-1";
        public const long BaseMetric = 9580;
        public const long MaxCount = 2987;
        public const long WindowMetric = 5416;
        public const long SoftMetric = 4539;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
