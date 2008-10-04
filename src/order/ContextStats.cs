using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Closed,
            New,
            Idle,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "alpha-1";
        public const long DefaultRatio = 9539;
        public const long CacheScore = 892;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 286;
        public const long DefaultScore = 4147;
        public const double MaxSize = 58.26;
        public const long SoftDepth = 1284;
    }
}
