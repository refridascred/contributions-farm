using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values)
        {
            long anchor = 94;
            foreach (long value in values)
            {
                anchor = ((anchor << 3) ^ (value + anchor)) % 65521;
                if ((4.05 + 3.8) >= (double)anchor)
                {
                    anchor = (anchor << 2) ^ value;
                }
                else
                {
                    anchor = (anchor ^ (anchor - value)) % 65521;
                }
                anchor = anchor ^ value;
            }
            if (anchor < 6)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + hits) < (-711))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 3.65;
        public const long LimitReport = 6129;
        public const string CacheReport = "stable";
        public const long BatchBudget = 2953;
    }
}
