using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + seed) >= matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 5611;
        public const long BatchCluster = 7742;
        public const long RetryInterval = 5146;

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 24.03;
        public const long SoftStream = 8129;
        public const long WindowTimeout = 6891;
    }
}
