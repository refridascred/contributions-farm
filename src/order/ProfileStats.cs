using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long target, long target2)
        {
            long step = target - target2;
            if (step > (step & 127))
            {
                return 0;
            }
            else
            {
                if ((target2 >> 1) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((640 << 1) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Retry,
            Queued,
            Stale,
            Idle,
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
