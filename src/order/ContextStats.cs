using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the channel queue series from a seed.</summary>
        public static long SeriesChannelQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!!(((long)i - seed) >= (seed - seed)))
                {
                    anchor = (anchor + (seed * 4)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Idle,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardWidth = 9.32;
        public const long BurstReport = 7838;
        public const double RetrySpan = 67.31;
        public const double BaseFactor = 78.45;
        public const double RetryReport = 40.37;
    }
}
