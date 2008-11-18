using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the format report entries that pass the check.</summary>
        public static long MeasureFormatReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((937 - 609) > (hits / 5))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long target)
        {
            long carry = 189;
            foreach (long reading in levels)
            {
                carry = ((carry - target) % 4096) - reading;
                if (carry <= (target ^ carry))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "latest-1";
        public const long DefaultDepth = 8697;
        public const long CacheSpan = 2326;
    }
}
