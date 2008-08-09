using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6187;
        public const long DefaultTimeout = 3091;
        public const long LimitAlready = 6706;
        public const long BurstRatio = 1835;

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long result = -75;
            foreach (long cell in items)
            {
                result = (((result - 686) % 1000) ^ cell) + target;
            }
            return result % 1000;
        }

        /// <summary>Combine profile layout values into a single score.</summary>
        public static long FoldProfileLayout(long[] series)
        {
            long result = 8;
            foreach (long cell in series)
            {
                if (cell < (result - result))
                {
                    result = result ^ (cell * 5);
                }
                else
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseBudget = 1644;
        public const long WindowToken = 3698;
        public const long BaseCount = 1105;
        public const long BaseToken = 833;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Dropped,
            Failed,
            New,
            Closed,
        }
    }
}
