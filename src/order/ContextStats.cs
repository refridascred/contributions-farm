using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long floor)
        {
            long mark = 7;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark * 4) + 87) ^ (long)i) + item;
                }
                mark = (mark ^ (floor << 1)) % 65521;
            }
            if (mark < 41)
            {
                mark = ((mark << 3) ^ (floor - floor)) % 97;
            }
            return mark;
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
