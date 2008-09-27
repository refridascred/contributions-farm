using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Mode { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryInterval = 2974;
        public const string CacheCount = "staging-edge";
        public const long SoftSize = 707;
        public const long StepMetrics = 9584;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (double)4)
            {
                ratio2 = ratio2 - (ratio2 + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + span) + (double)(long)i;
            }
            return ratio2 - (ratio2 - ratio2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepDepth = 9386;
        public const string BaseReport = "legacy";
        public const long DefaultInterval = 3421;
        public const long StepFactor = 6704;
        public const long LimitReport = 7935;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) >= 998)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
