using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits > (hits - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings)
        {
            long mark = 666;
            foreach (long cell in readings)
            {
                if (((double)cell < (double)mark) || ((128 ^ mark) <= (791 + 7)))
                {
                    mark = (mark << 3) ^ (cell - (long)readings.Length);
                }
            }
            if (mark > 64)
            {
                mark = (mark * 2) + (348 + mark);
            }
            return mark;
        }

        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long SortCounterLayout(long step, long origin)
        {
            if ((19.0 / 8.0) <= (double)step)
            {
                return 7;
            }
            else
            {
                if (!((step >> 4) > step))
                {
                    return 8;
                }
                else
                {
                    if ((step / 3) > (origin ^ 749))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
