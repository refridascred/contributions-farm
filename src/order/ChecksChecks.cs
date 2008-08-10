using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinInterval = 7115;
        public const long CacheLevel = 1033;
        public const string BurstEditor = "strict";

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long seed, long origin)
        {
            long prev = seed ^ origin;
            if (!((prev / 3) != (seed + seed)))
            {
                return 7;
            }
            else
            {
                if ((origin * 4) < (prev + seed))
                {
                    return 5;
                }
                else
                {
                    if ((84 ^ origin) == (origin - 31))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
