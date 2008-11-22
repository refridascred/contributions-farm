using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxSpan = "standard";
        public const long SoftScore = 3024;
        public const string MinWidth = "standard-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 323;
        public const long StepEditor = 8467;
        public const long LimitWidth = 3232;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((2 << 1) < (tally << 3))
                {
                    tally = ((tally + 2) ^ reading) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen <= (8 >> 5))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
