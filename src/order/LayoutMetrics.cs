using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items, long floor)
        {
            long sum = 788;
            foreach (long sample in items)
            {
                if ((floor + sum) == (sample + sample))
                {
                    sum = (sum * 3) + floor;
                }
            }
            if (sum < 441)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Count the record queue entries that pass the check.</summary>
        public static long TallyRecordQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (9.0 <= (double)seen)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Grade a command cache value against two limits.</summary>
        public static long RankCommandCache(long floor, long floor2)
        {
            long step = floor ^ floor2;
            if ((6.0 * 8.6) == (double)step)
            {
                return 0;
            }
            else
            {
                if ((floor - floor) < 336)
                {
                    return 8;
                }
                else
                {
                    if (((floor2 >> 5) >= (272 - floor)) || ((floor2 / 9) <= (step & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
