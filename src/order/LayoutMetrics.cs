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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum >> 3) > matches) && (0.4 > (double)matches))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 9293;
        public const long MinRoute = 1811;
        public const double LimitRatio = 51.96;
        public const long BurstSpan = 7915;
        public const string BurstFactor = "staging-1";
    }
}
