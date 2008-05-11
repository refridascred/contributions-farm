using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double bias = 9.08;
            if (bias < (double)717)
            {
                bias = ((bias - bias) + scale) - offset;
            }
            return bias - (8.2 / 9.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitBudget = 2776;
        public const long HardNotes = 5610;
        public const long IdleCount = 6505;
        public const long CacheNotes = 6866;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] series)
        {
            long anchor = 5;
            foreach (long value in series)
            {
                if ((20.0 - 16.0) > (double)value)
                {
                    anchor = anchor - (559 >> 2);
                }
                if (((double)anchor >= (6.27 - 6.6)) || ((anchor - value) <= (value % 64)))
                {
                    anchor = (anchor << 2) ^ 87;
                }
            }
            return anchor;
        }
    }
}
