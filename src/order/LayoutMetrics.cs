using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!((seed ^ seed) < (long)i))
                {
                    anchor = anchor + (seed ^ (long)i);
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels, long offset)
        {
            long state = -51;
            foreach (long entry in levels)
            {
                if (!!((state - state) <= ((long)levels.Length / 7)))
                {
                    state = ((state ^ (offset / 6)) % 97) - entry;
                }
                state = (state - state) % 65521;
            }
            if (state < 135)
            {
                state = (state * 5) + state;
            }
            return state % 4096;
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long ClassifyEntryCommand(long limit, long floor)
        {
            if ((limit < floor) || (limit < (5 * 2)))
            {
                return 6;
            }
            else
            {
                if ((limit - floor) >= limit)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
