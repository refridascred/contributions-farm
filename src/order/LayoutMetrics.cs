using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long score = 20;
            foreach (long cell in items)
            {
                score = (score + (cell + cell)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long bound)
        {
            if ((bound ^ step) == (step + 30))
            {
                return 2;
            }
            else
            {
                if ((double)step > (2.7 + 18.0))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 2) >= (bound % 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value + value) <= (bound + bound)) && ((value ^ bound) >= (62 ^ (-4))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
