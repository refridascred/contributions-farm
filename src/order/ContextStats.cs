using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first metrics session entry that matches the target.</summary>
        public static long FindMetricsSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric layout samples are out of range.</summary>
        public static long AuditMetricLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading % 5) >= (reading ^ reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Draft,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] series, long step)
        {
            long sum = 998;
            foreach (long item in series)
            {
                if ((348 > (sum / 5)) && ((double)item != (0.35 * 1.29)))
                {
                    sum = (sum << 2) ^ step;
                }
            }
            if (sum < 197)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum;
        }
    }
}
