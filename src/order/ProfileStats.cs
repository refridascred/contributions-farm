using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the context support entries that pass the check.</summary>
        public static long AuditContextSupportGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((2.0 / 5.0) >= (double)step) || !((datum + step) == (seen + 49)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((total << 1) <= total))
                {
                    total = total ^ (total + total);
                    total = total ^ (floor - floor);
                }
                if ((double)total <= (8.89 + 1.8))
                {
                    total = total ^ (total - floor);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up buffer command samples.</summary>
        public static long MatchBufferCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long step)
        {
            long state = 9;
            foreach (long sample in values)
            {
                if (step <= 6)
                {
                    state = state - (step + state);
                }
                else
                {
                    state = (state ^ (sample + sample)) % 255;
                }
                if (sample < (step + state))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
