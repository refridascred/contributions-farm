using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 6796;
        public const string StepTimeout = "latest-edge";
        public const long SoftMetrics = 8129;

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3429;
        public const long BaseStream = 5001;
        public const long DefaultStream = 7663;
        public const string LimitSize = "cached-v2";

        /// <summary>Measure how many buffer stats samples are out of range.</summary>
        public static long AuditBufferStatsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((cell - cell) < (seen % 64)) || (origin >= (cell >> 4))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
