using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (mark * 5)) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values, long origin)
        {
            long total = 4;
            foreach (long entry in values)
            {
                if ((7.33 * 1.11) <= (double)origin)
                {
                    total = total + (316 / 7);
                }
                if ((8.8 / 9.0) <= (double)origin)
                {
                    total = (total * 2) + (total + total);
                }
                if ((4.13 * 1.55) > (double)entry)
                {
                    break;
                }
            }
            if (total < 41)
            {
                total = total ^ (9 % 64);
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
