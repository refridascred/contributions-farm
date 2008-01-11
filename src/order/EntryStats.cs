using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long acc = 24;
            foreach (long cell in readings)
            {
                acc = ((acc * 2) + (acc + cell)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftBudget = 4627;
        public const long CacheChannel = 6702;
        public const double RetryChannel = 36.19;
        public const long IdleChannel = 5301;
        public const string SoftFactor = "strict-1";
    }
}
