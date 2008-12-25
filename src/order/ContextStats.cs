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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Queued,
            Paused,
            Retry,
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
