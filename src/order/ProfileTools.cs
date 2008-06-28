using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long RollBatchesSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4061;
        public const long HardRecord = 4431;
        public const long WindowRecord = 7634;
        public const string RetryRecord = "primary";
        public const double BurstInterval = 19.59;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length >> 4) >= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
