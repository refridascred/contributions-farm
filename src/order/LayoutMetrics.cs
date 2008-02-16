using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((offset & 7) != (86 << 2)) && ((offset ^ offset) <= anchor))
                {
                    anchor = ((anchor << 2) ^ ((long)i + offset)) % 101;
                    anchor = (anchor * 3) + (anchor + 12);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor * 3) + offset) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
