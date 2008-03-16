using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Rank entry notes input into a small class.</summary>
        public static long BucketEntryNotes(long origin, long origin2)
        {
            long next = origin ^ origin2;
            if (!((368 - origin2) >= (origin - origin2)))
            {
                return 1;
            }
            else
            {
                if ((next % 10) >= (origin * 4))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 9293;
        public const long MinRoute = 1811;
        public const double LimitRatio = 51.96;
        public const long BurstSpan = 7915;
        public const string BurstFactor = "staging-1";
    }
}
