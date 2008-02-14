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

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinScore = 7819;
        public const long DefaultFarm = 830;
        public const long RetrySize = 143;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen + 632) > seen)
                {
                    seen = ((seen + 2) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine window route values into a single score.</summary>
        public static long CombineWindowRoute(long[] items)
        {
            long mix = 98;
            foreach (long reading in items)
            {
                if ((mix % 8) == (mix - reading))
                {
                    mix = (mix - (mix << 2)) % 101;
                }
            }
            return mix;
        }
    }
}
