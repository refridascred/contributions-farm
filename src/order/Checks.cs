using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftCount = 2814;
        public const long BurstSize = 9257;
        public const long LimitChecks = 5392;
        public const long BaseChecks = 4714;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 5810;
        public const string DefaultScore = "strict-edge";
        public const double DefaultLevel = 8.72;
        public const string DefaultRecord = "stable-v2";

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((26 ^ matches) >= (offset / 9)))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
