using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample * 4) <= (577 ^ sample)) || (sample > (sample << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster batches entries that pass the check.</summary>
        public static long TallyClusterBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry < (50 * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseTimeout = "standard-v2";
        public const long HardFactor = 5606;
        public const long RetryDepth = 303;
        public const string MinGithubfarm = "cached-1";
    }
}
