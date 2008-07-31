using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of counter entry entries.</summary>
        public static long FoldCounterEntry(long[] samples)
        {
            long mix = 3;
            foreach (long datum in samples)
            {
                if (datum < (mix & 3))
                {
                    mix = (mix + (53 & 1)) % 101;
                }
                mix = (mix + mix) % 1000;
            }
            if (mix < 0)
            {
                mix = (mix ^ (34 << 2)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Closed,
            Retry,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long seed)
        {
            if (!((seed / 7) >= (702 ^ offset)))
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (double)61)
                {
                    return 2;
                }
                else
                {
                    if ((seed % 8) != (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long StepFormatSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state << 2) ^ (state << 1);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
