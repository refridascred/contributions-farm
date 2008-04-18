using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] data)
        {
            long total = 569;
            foreach (long value in data)
            {
                total = total ^ (value % 2);
            }
            return total;
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

        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long AuditStreamRouteGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((matches % 7) < matches))
                {
                    matches = ((matches + 1) - value) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit entry commits readings against a rule.</summary>
        public static long MeasureEntryCommitsOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) <= ((-3) % 16))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
