using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (5.34 - 16.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 5964;
        public const long RetrySpan = 6520;
        public const double LimitSpan = 38.5;
        public const double SoftFactor = 64.86;
        public const string DefaultWindow = "open-edge";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Retry,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardScore = 750;
        public const long BaseFarm = 4125;
        public const long MinFarm = 9374;
    }
}
