using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardFactor = 64;
        public const double MinWidth = 69.95;
        public const double HardRoute = 94.46;
        public const long DefaultSize = 9657;
        public const long StepSize = 976;

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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            if (!(origin >= (origin << 1)))
            {
                return 4;
            }
            else
            {
                if ((11.0 + 8.02) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((610 <= (seed + seed)) && (origin <= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
