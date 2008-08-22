using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitTimeout = 39.06;
        public const long CacheSpan = 5533;
        public const long CacheStats = 2972;
        public const string BurstSize = "standard-1";

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Paused,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Queued,
            Synced,
            New,
            Paused,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long seed, long limit)
        {
            long gap = seed ^ limit;
            if ((double)limit != (7.7 - 17.0))
            {
                return 6;
            }
            else
            {
                if (limit < (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((gap - seed) < (seed % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)gap < 18.0)
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
        }
    }
}
