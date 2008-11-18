using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long seed)
        {
            long edge = offset ^ seed;
            if ((seed + seed) >= seed)
            {
                return 7;
            }
            else
            {
                if (((edge + 500) == (offset + seed)) || ((double)seed <= (7.89 * 4.27)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a layout graph counter forward.</summary>
        public static long DeriveLayoutGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state + seed) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                long step = (anchor % 12) - ((long)i & 7);
                if (step > anchor)
                {
                    step = ((step * 5) + (bound + bound)) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + (bound - bound)) % 65521;
                }
                step = (step ^ anchor) % 101;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
