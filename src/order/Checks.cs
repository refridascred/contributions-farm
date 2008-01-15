using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 6460;
        public const string MinMetrics = "cached-v2";
        public const long BurstFactor = 2160;
        public const long MinTimeout = 2445;
        public const long CacheTimeout = 9998;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            New,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            New,
            Queued,
            Closed,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
