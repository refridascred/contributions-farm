using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool CheckToolsContextLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate counter stats samples.</summary>
        public static long ScoreCounterStats(long[] levels)
        {
            long mark = 19;
            foreach (long reading in levels)
            {
                if ((mark & 3) <= (reading >> 3))
                {
                    mark = (mark ^ (reading - reading)) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (8 ^ 81)) % 255;
                }
            }
            if (mark > 867)
            {
                mark = mark + (long)levels.Length;
            }
            return mark;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double weight = (double)(153 - 27);
            return ((weight - (double)186) + ratio) + span;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
