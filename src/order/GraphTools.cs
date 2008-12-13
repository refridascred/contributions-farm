using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank queue layout input into a small class.</summary>
        public static long GradeQueueLayout(long bound, long bound2)
        {
            if ((bound / 3) != (bound % 16))
            {
                return 3;
            }
            else
            {
                if (!((bound2 & 7) <= (bound2 / 2)))
                {
                    return 6;
                }
                else
                {
                    if (((bound % 97) <= (bound >> 4)) && ((double)bound2 <= 6.2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound ^ bound) <= bound2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache metric readings.</summary>
        public static long MatchCacheMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Dropped,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Iterate the buffer command series from a seed.</summary>
        public static long SeriesBufferCommand(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((8.67 / 2.0) >= (double)state)
                {
                    continue;
                }
                if (state < (state * 3))
                {
                    state = ((state * 4) + (state / 5)) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Done,
        }
    }
}
