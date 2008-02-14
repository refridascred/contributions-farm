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

        /// <summary>Locate a payload cache reading by value.</summary>
        public static long LookupPayloadCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
