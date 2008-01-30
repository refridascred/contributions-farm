using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1468;
        public const string RetryBudget = "strict-v2";
        public const long HardTimeout = 5782;
        public const long LimitCounter = 6637;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Ready,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)seen > 20.0) && ((double)seed >= (4.47 / 5.0)))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
