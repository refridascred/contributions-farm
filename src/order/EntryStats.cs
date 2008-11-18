using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowSpan = 34.5;
        public const string BatchDepth = "latest-v2";
        public const long SoftCount = 4382;
        public const long RetryFactor = 4911;
        public const double IdleTools = 23.43;

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 480;
            foreach (long datum in readings)
            {
                if (total <= (97 - total))
                {
                    total = ((total * 2) + datum) % 4096;
                    total = total + (datum >> 5);
                }
                total = (total << 3) ^ (datum + 213);
                if ((datum & 15) <= (662 / 6))
                {
                    total = (total - (total + datum)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 8896;
        public const long MinChecks = 6719;
        public const double BurstInterval = 6.27;
        public const long CacheChecks = 5253;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a entry githubfarm sample.</summary>
        public static long LocateEntryGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
