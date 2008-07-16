using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Pending,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultFactor = 4775;
        public const long RetrySession = 7801;
        public const double CacheWidth = 80.21;
        public const long IdleTimeout = 2389;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
