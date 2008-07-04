using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] series, long offset)
        {
            long state = 95;
            foreach (long sample in series)
            {
                if ((sample % 7) < (offset - 5))
                {
                    state = state - (state >> 3);
                }
                else
                {
                    state = ((state * 2) + state) % 65521;
                }
            }
            if (state < 782)
            {
                state = (state ^ (offset / 7)) % 97;
            }
            return state;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long floor)
        {
            long gap = step + floor;
            if (((12.0 / 2.0) > (double)gap) || ((double)gap < (1.0 * 8.6)))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (18.0 * 1.4))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 3) > (-197))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.8 + 6.0) <= (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
