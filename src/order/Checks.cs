using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long limit)
        {
            if ((double)120 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((seed % 2) >= (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if ((limit - (-5)) < (-5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit * 3) >= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetrySize = "alpha";
        public const long SoftChannel = 6503;
        public const double BurstLevel = 15.5;
        public const long RetryWidth = 1035;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
