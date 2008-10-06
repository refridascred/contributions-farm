using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long mix = 740;
            foreach (long value in levels)
            {
                mix = ((mix << 2) ^ seed) % 65521;
                mix = mix ^ 95;
                if (!(seed <= (value & 127)))
                {
                    mix = (mix << 2) ^ (mix ^ value);
                }
                else
                {
                    mix = (mix ^ (8 ^ seed)) % 255;
                }
                if (!((mix * 2) < value))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + sample) < (hits & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheLevel = 5541;
        public const double DefaultWindow = 77.1;
        public const long SoftWindow = 3450;
        public const long RetryRatio = 5754;
    }
}
