using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if (state < ((long)i % 12))
                {
                    long lane = 121;
                    state = (state * 5) + (lane << 2);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter metric series from a seed.</summary>
        public static long SeriesCounterMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items)
        {
            long carry = 8;
            foreach (long value in items)
            {
                if (!((value % 5) < carry))
                {
                    carry = (carry * 3) + (7 - carry);
                }
                if ((354 + value) <= (long)items.Length)
                {
                    carry = carry - (carry - carry);
                }
                else
                {
                    carry = (carry ^ ((-194) - carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long AuditFarmCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((seen >> 3) != (seen ^ 522)) && (((-8) + seen) > (item >> 1))) && !((item >> 4) < (item << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
