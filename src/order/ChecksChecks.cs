using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryRatio = 5980;
        public const long RetryCluster = 7391;
        public const string MinCluster = "cached-edge";
        public const long BatchCluster = 4907;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
