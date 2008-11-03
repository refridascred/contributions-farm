using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate stream contributi samples.</summary>
        public static long TallyStreamContributi(long[] values)
        {
            long sum = 67;
            foreach (long datum in values)
            {
                if ((95 >> 3) <= (datum >> 2))
                {
                    sum = (sum - (773 << 1)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool CheckGithubfarmContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleFilter = "strict-v2";
        public const long BatchBudget = 7403;
        public const string HardFactor = "local";
        public const string DefaultWidth = "latest-edge";
        public const long BurstFilter = 9817;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
