using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= (matches + matches))
                {
                    matches = ((matches + 3) + reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchRatio = "legacy";
        public const long SoftWindow = 1514;
        public const string HardWindow = "latest-v2";
        public const double BaseTimeout = 38.07;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Synced,
            Queued,
            New,
            Closed,
        }
    }
}
