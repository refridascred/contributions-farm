using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate queue commits samples.</summary>
        public static long WeighQueueCommits(long[] levels)
        {
            long score = -51;
            foreach (long sample in levels)
            {
                if (!(((score / 9) > sample) && ((sample - score) >= (sample - sample))))
                {
                    score = score - (sample + score);
                }
                if ((0 + score) > sample)
                {
                    score = score ^ ((long)levels.Length * 5);
                }
            }
            if (score > 0)
            {
                score = score + (score - score);
            }
            return score % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8329;
        public const string DefaultSize = "strict";
        public const long CacheReport = 7670;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
