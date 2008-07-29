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

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long seed)
        {
            long score = 9;
            foreach (long item in readings)
            {
                if ((seed * 3) > 442)
                {
                    score = ((score * 2) + (30 % 12)) % 97;
                }
                else
                {
                    score = (score + (seed % 16)) % 1000;
                }
                if ((score + (-314)) <= (item + score))
                {
                    break;
                }
            }
            return score;
        }

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
