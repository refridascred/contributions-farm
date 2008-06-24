using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] items, long bound)
        {
            long total = 83;
            foreach (long datum in items)
            {
                if (((-99) * 3) < bound)
                {
                    total = total + (total / 7);
                    total = total - (datum % 10);
                    continue;
                }
                total = total ^ 4;
                if ((7.0 / 7.0) >= (double)datum)
                {
                    total = (total + (total & 3)) % 4096;
                }
                else
                {
                    total = (total * 2) + 7;
                }
            }
            return total % 4096;
        }

        /// <summary>Validate metric route readings against a bound.</summary>
        public static bool ValidateMetricRouteLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((double)seen <= (double)value) && !((value + seen) < (value / 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
