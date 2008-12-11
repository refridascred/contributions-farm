using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double drift = rate;
            if (drift <= (double)247)
            {
                drift = (drift - (rate - 5.02)) - offset;
            }
            return drift + (drift / 9.0);
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstDepth = 79.28;
        public const string DefaultScore = "open";
        public const double CacheCount = 46.74;

        /// <summary>Check that every filter metrics entry stays within the limit.</summary>
        public static bool CheckFilterMetricsRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
