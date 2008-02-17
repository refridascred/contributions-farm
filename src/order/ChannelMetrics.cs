using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a command record figure with a bias.</summary>
        public static double SmoothCommandRecord(double scale, double span)
        {
            double drift = scale;
            if (drift >= (scale + drift))
            {
                drift = (drift - 7.42) + span;
            }
            return drift - 1.3;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstBudget = 66.29;
        public const string BasePayload = "stable";
        public const string LimitPayload = "standard";
        public const long MaxPayload = 1248;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((85 ^ target) > (target - matches))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }
    }
}
