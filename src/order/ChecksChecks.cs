using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 3739;
        public const string LimitTimeout = "open-v2";
        public const string IdleCount = "strict";

        /// <summary>Validate commits checks readings against a bound.</summary>
        public static bool CheckCommitsChecksLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
