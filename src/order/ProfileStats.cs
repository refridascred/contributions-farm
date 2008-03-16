using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long seed)
        {
            long delta = target + seed;
            if (85 > delta)
            {
                return 1;
            }
            else
            {
                if ((double)delta > (9.62 - 8.83))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long origin)
        {
            long gap = step - origin;
            if (!(step >= (gap << 1)))
            {
                return 8;
            }
            else
            {
                if ((origin > (3 / 5)) && (origin > (gap / 2)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((0.3 * 6.0) != (double)hits)
                {
                    hits = ((hits + 3) - entry) - step;
                }
            }
            return hits;
        }
    }
}
