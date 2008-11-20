using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double drift = span;
            if (drift >= scale)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - 8.0;
            }
            return drift - (double)4;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinInterval = 90.79;
        public const long BaseTimeout = 944;
        public const long HardLevel = 2118;
        public const string CacheRatio = "local-edge";

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
