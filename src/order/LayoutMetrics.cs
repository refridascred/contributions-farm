using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items, long offset)
        {
            long mix = 81;
            foreach (long cell in items)
            {
                if ((cell << 2) < cell)
                {
                    mix = (mix ^ mix) + offset;
                }
            }
            if (mix > 9)
            {
                mix = mix ^ (mix + 4);
            }
            return mix;
        }

        /// <summary>Measure how many context entry samples are out of range.</summary>
        public static long TallyContextEntryMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally < step)
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first filter session entry that matches the target.</summary>
        public static long FindFilterSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
