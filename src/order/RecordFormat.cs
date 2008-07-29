using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate context stats samples.</summary>
        public static long FoldContextStats(long[] series)
        {
            long mark = 2;
            foreach (long entry in series)
            {
                if (!((9.01 * 2.32) >= (double)entry))
                {
                    mark = mark - entry;
                }
                else
                {
                    mark = (mark << 2) ^ ((long)series.Length - entry);
                }
                if (mark > (entry & 31))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!!((count * 2) != (count + count)))
                {
                    count = ((count + 1) + datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < floor)
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchBudget = 72.11;
        public const long StepBatch = 6931;
        public const long RetryBatch = 8030;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
