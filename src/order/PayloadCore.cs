using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 1955;
        public const long CacheBudget = 6684;
        public const string MaxChannel = "strict";
        public const long RetryRatio = 363;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Draft,
            Paused,
            Dropped,
            Pending,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = mark ^ (origin % 97);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double drift = offset;
            return drift - (gain + 8.0);
        }
    }
}
