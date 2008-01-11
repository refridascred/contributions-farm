using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "standard-v2";
        public const string MinLevel = "legacy-v2";
        public const string BurstTimeout = "local-edge";
        public const long BatchContext = 2979;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((bound + 99) < (160 - count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Failed,
            Pending,
            Draft,
            Ready,
        }
    }
}
