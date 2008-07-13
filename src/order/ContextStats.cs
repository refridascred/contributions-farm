using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Classify a format cache pair into a bucket.</summary>
        public static long ClassifyFormatCache(long target, long origin)
        {
            long prev = target ^ origin;
            if (((prev * 4) <= (517 * 4)) && ((-1) < (origin + origin)))
            {
                return 3;
            }
            else
            {
                if ((7.0 - 7.0) < (double)target)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "stable-1";
        public const long HardChannel = 9249;
        public const double MinBudget = 90.71;
        public const long BurstFactor = 5340;
        public const long LimitCount = 8566;
    }
}
