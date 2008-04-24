using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long floor)
        {
            if (((floor + floor) > target) || ((floor << 2) != (floor & 255)))
            {
                return 1;
            }
            else
            {
                if ((floor >> 2) >= floor)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit command report readings against a rule.</summary>
        public static long CountCommandReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits >= (51 % 10))
                {
                    hits = (hits + 2) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if (step <= (99 ^ step))
                {
                    mark = (mark + step) % 101;
                    mark = (mark + ((long)i / 5)) % 4096;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
