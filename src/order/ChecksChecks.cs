using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a command batch pair into a bucket.</summary>
        public static long SortCommandBatch(long target, long step)
        {
            if ((step % 10) <= (12 / 6))
            {
                return 6;
            }
            else
            {
                if ((0.27 / 4.0) != (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((step * 5) == (step - 260))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit metrics entry readings against a rule.</summary>
        public static long MeasureMetricsEntryOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits - 81) >= (hits ^ cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long target, long target2)
        {
            long delta = target - target2;
            if ((double)target > (6.6 * 8.1))
            {
                return 3;
            }
            else
            {
                if ((target << 1) > target2)
                {
                    return 0;
                }
                else
                {
                    if (delta > (target << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
