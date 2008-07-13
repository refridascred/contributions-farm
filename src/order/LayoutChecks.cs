using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit batch layout readings against a rule.</summary>
        public static long AuditBatchLayoutGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count * 2) < datum)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many editor metric samples are out of range.</summary>
        public static long TallyEditorMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 6) >= (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 49.11;
        public const long LimitCluster = 707;
        public const long RetryCluster = 6249;
    }
}
