using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((8.67 + 2.33) == (double)reading) || ((double)reading <= (3.0 - 3.51)))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long ScoreLayoutTools(long[] series)
        {
            long anchor = -3;
            foreach (long reading in series)
            {
                if ((480 - anchor) > reading)
                {
                    break;
                }
                anchor = anchor - reading;
            }
            return anchor % 97;
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
