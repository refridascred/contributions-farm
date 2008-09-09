using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long CountMetricsAccountOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count + cell) != (cell >> 4))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long CountOrderRouteGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= (value << 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepLevel = "standard-v2";
        public const double BaseNotes = 7.94;
        public const double IdleNotes = 34.4;
        public const long WindowBudget = 2435;
    }
}
