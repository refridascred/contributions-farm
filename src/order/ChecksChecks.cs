using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many commits support samples are out of range.</summary>
        public static long AuditCommitsSupportHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((cell >> 4) != (2 + cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 553;
        public const double HardWindow = 59.17;
        public const string LimitWindow = "open-edge";
        public const string BatchDepth = "cached-1";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            New,
            Stale,
        }
    }
}
