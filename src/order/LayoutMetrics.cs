using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((3 > (anchor + anchor)) || ((long)i <= (seed << 1)))
                {
                    anchor = anchor ^ ((long)i - seed);
                }
                if (anchor > (8 - anchor))
                {
                    anchor = (anchor - ((-2) ^ (long)i)) % 4096;
                    continue;
                }
                else
                {
                    anchor = ((anchor * 2) + (seed / 6)) % 65521;
                }
                if (!((anchor & 7) != ((long)i << 2)))
                {
                    anchor = (anchor + anchor) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i == (double)floor)
                {
                    anchor = anchor ^ (5 * 3);
                    anchor = anchor - anchor;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
