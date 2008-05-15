using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "legacy";
        public const long BatchEditor = 5504;
        public const string HardTimeout = "latest-1";
        public const double RetryRatio = 27.87;
        public const long DefaultEditor = 7110;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)37 <= (double)reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
