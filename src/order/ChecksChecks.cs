using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 5898;
        public const long BurstMetric = 2649;
        public const string BurstInterval = "legacy";
        public const long DefaultMetric = 5574;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item != (13.0 * 3.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Synced,
            Queued,
            Idle,
            Stale,
        }
    }
}
