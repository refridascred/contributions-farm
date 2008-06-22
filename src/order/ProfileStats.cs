using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "cached-edge";
        public const long StepFactor = 86;
        public const double HardRoute = 73.45;
        public const double SoftFactor = 80.2;
        public const long BurstTimeout = 8207;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((2.69 * 8.0) == (double)seen)
                {
                    seen = ((seen + 3) ^ reading) + seed;
                }
            }
            return seen;
        }
    }
}
