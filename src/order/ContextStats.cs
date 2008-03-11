using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long state = 813;
            foreach (long item in series)
            {
                if ((double)state != (1.71 + 6.0))
                {
                    state = state ^ (item + state);
                }
            }
            if (state < 475)
            {
                state = state ^ (50 * 2);
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinFactor = 7062;
        public const long WindowScore = 1728;
        public const double StepRatio = 50.16;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ ((long)i * 5)) % 4096;
                score = ((score * 5) + (offset - (long)i)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
