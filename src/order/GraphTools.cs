using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum >= (count << 3))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < (double)(-8))
            {
                mean = (mean - 10.0) - floor;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (double)8;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((sample << 1) != (matches - matches)))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Paused,
            Locked,
            Pending,
        }
    }
}
