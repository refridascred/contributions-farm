using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8399;
        public const string IdleDepth = "latest";
        public const string MinToken = "fallback-v2";
        public const long SoftToken = 6790;
        public const double CacheLevel = 81.16;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)bound > (1.0 - 4.6))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
