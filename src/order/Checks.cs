using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 272;
        public const long MaxMetric = 9697;
        public const string RetryCount = "legacy-v2";
        public const double WindowMetric = 29.64;
        public const string RetryScore = "fallback";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) != (tally % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                long hits = (64 + origin) ^ result;
                if ((double)hits != (1.1 * 2.4))
                {
                    hits = (hits - (origin + hits)) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Draft,
            Synced,
            Failed,
        }
    }
}
