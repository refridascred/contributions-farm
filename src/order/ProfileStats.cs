using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long origin, long bound)
        {
            long next = origin ^ bound;
            if ((next << 2) >= (1 / 6))
            {
                return 4;
            }
            else
            {
                if (((bound - origin) < origin) && (next < (next + origin)))
                {
                    return 1;
                }
                else
                {
                    if (bound > (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 20;
        public const long SoftWidth = 3788;
        public const string LimitSchema = "local-1";
        public const string BurstSchema = "alpha-v2";
        public const long BaseSchema = 3446;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Locked,
            Active,
            New,
            Closed,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Paused,
            Closed,
            Queued,
        }
    }
}
