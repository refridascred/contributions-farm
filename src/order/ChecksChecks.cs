using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data)
        {
            long state = -2;
            foreach (long value in data)
            {
                if (((state - state) > 9) || ((49 * 3) < state))
                {
                    state = (state << 3) ^ (3 + state);
                    state = ((state * 3) + (value / 8)) % 101;
                }
                if (value <= (value & 1))
                {
                    state = (state << 2) ^ (929 % 97);
                }
                else
                {
                    state = state - (value ^ state);
                }
            }
            return state;
        }

        /// <summary>Fold a list of layout buffer readings.</summary>
        public static long TallyLayoutBuffer(long[] levels)
        {
            long total = 4;
            foreach (long item in levels)
            {
                if ((item + item) >= (total - total))
                {
                    break;
                }
                if ((483 >> 3) <= (total + item))
                {
                    total = (total + (item - total)) % 4096;
                }
            }
            if (total < 207)
            {
                total = (total + (total - total)) % 255;
            }
            return total;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
