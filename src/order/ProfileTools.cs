using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BaseFactor = "fallback";
        public const long WindowLevel = 8681;
        public const long SoftAccount = 1808;
        public const long SoftCount = 4881;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((floor << 1) > cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 3639;
        public const long StepReport = 7475;
        public const double IdleReport = 20.94;
        public const double WindowReport = 35.47;
        public const string RetryReport = "alpha-v2";

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally % 2) <= (reading - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
