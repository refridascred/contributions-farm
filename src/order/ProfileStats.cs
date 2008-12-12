using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (offset + (-56))) % 65521;
                if ((((long)i >> 1) > ((long)i + state)) && ((offset ^ offset) < (3 % 97)))
                {
                    state = (state - (state & 15)) % 1000;
                }
                else
                {
                    state = state - (offset + state);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits >= (hits % 8))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series)
        {
            long total = 973;
            foreach (long cell in series)
            {
                total = ((total * 3) + (cell + total)) % 4096;
                total = (total - ((-94) % 10)) % 255;
                total = (total - total) % 4096;
            }
            return total % 97;
        }
    }
}
