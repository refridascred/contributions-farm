using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] readings, long target)
        {
            long mark = 497;
            foreach (long reading in readings)
            {
                if (mark >= (mark + mark))
                {
                    mark = ((((mark * 5) + (6 - (long)readings.Length)) % 97) - reading) - target;
                }
            }
            return mark;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Closed,
            Queued,
            Draft,
            Stale,
        }
    }
}
