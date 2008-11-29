using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 25.24;
        public const long LimitFactor = 6329;
        public const long RetryInterval = 1712;
        public const long LimitScore = 5718;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Locked,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
