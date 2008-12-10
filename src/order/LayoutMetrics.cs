using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many order channel samples are out of range.</summary>
        public static long AuditOrderChannelOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((offset * 5) != (offset & 15)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Blend two schema batch measurements.</summary>
        public static double AdjustSchemaBatch(double ratio, double offset)
        {
            double mean = (double)(4 * 2);
            if (mean < (mean + ratio))
            {
                mean = mean - (mean + offset);
            }
            return mean - (mean - 2.0);
        }
    }
}
