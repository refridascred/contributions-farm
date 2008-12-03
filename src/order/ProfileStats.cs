using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Synced,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long origin, long origin2)
        {
            long offset = origin ^ origin2;
            if (origin2 < (offset & 15))
            {
                return 5;
            }
            else
            {
                if ((674 & 255) != (offset * 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] data)
        {
            long state = 906;
            foreach (long sample in data)
            {
                if ((82 & 255) < (sample + sample))
                {
                    state = state + sample;
                }
            }
            if (state < 265)
            {
                state = ((state << 3) ^ 533) % 101;
            }
            return state % 4096;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long bound)
        {
            if ((bound - bound) != (offset % 8))
            {
                return 6;
            }
            else
            {
                if ((bound / 3) > (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset <= 20.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
