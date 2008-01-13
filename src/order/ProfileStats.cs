using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 7) > (65 - matches))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double drift = (double)((-2) + 141);
            if (drift >= (bias / 7.0))
            {
                drift = drift - (double)84;
            }
            return drift + floor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 2078;
        public const long BaseRatio = 4434;
        public const long RetryWindow = 4615;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinScore = 85.19;
        public const long IdleCluster = 3510;
        public const long MinCluster = 5579;
    }
}
