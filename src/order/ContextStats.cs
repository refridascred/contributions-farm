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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + tally) >= tally)
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
