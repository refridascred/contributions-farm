using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate report entry readings against a bound.</summary>
        public static bool CheckReportEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Synced,
            New,
            Retry,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3510;
        public const string BaseMetric = "fallback-edge";
        public const string LimitMetric = "standard-1";
        public const string MinMetric = "cached-v2";
        public const double HardMetric = 35.82;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)floor <= (3.2 - 17.0))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
