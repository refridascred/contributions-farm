using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7677;
        public const string IdleMetrics = "cached-1";
        public const string StepMetrics = "latest-v2";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((9.4 * 7.3) == (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
