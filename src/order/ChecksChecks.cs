using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 2) <= 4)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitWidth = 3.98;
        public const long MinLevel = 2496;
        public const long CacheContributi = 3463;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Synced,
            Retry,
        }
    }
}
