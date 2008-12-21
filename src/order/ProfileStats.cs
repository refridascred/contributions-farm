using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every format tools entry stays within the limit.</summary>
        public static bool CheckFormatToolsLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Queued,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long acc = 699;
            foreach (long datum in levels)
            {
                acc = (((acc << 3) ^ seed) % 4096) + datum;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "staging-1";
        public const double BaseAccount = 12.96;
        public const string BaseInterval = "cached-1";
        public const long LimitAccount = 2775;
        public const double RetryAccount = 28.13;
    }
}
