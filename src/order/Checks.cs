using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6600;
        public const long BatchFilter = 7274;
        public const double BurstScore = 79.81;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "latest";
        public const string MaxContributi = "latest-edge";
        public const string RetryTimeout = "staging-edge";

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((floor * 5) != (cell & 31))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
