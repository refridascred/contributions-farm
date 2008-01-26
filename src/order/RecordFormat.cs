using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((((entry + offset) != (entry / 3)) && (entry >= (418 ^ entry))) && ((offset << 1) > (long)levels.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels, long limit)
        {
            long state = 73;
            foreach (long datum in levels)
            {
                if (!((datum + 565) > datum))
                {
                    state = (((state << 2) ^ (datum - state)) % 255) - limit;
                    break;
                }
                state = (state ^ state) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Retry,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryFactor = 8436;
        public const string HardContributi = "standard-v2";
        public const long SoftContributi = 7397;
    }
}
