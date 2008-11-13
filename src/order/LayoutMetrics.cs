using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a profile batch value against two limits.</summary>
        public static long GradeProfileBatch(long seed, long target)
        {
            if (4.4 > (double)target)
            {
                return 4;
            }
            else
            {
                if (((target - seed) <= (target + seed)) || ((target >> 2) > 44))
                {
                    return 2;
                }
                else
                {
                    if ((seed + 508) != (seed >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((step + 856) >= (sample % 10)) || (((9.0 + 4.0) < (double)sample) || ((step + 700) >= (count + sample))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long step)
        {
            long delta = bound ^ step;
            if (!((delta * 5) < 2))
            {
                return 3;
            }
            else
            {
                if ((step - delta) < (bound + step))
                {
                    return 5;
                }
                else
                {
                    if ((step + bound) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
