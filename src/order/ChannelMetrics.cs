using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long seed)
        {
            long step = offset + seed;
            if ((step + step) <= (6 + (-8)))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (3.5 / 3.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the editor report series from a seed.</summary>
        public static long SeriesEditorReport(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                if ((state & 31) >= target)
                {
                    state = (state * 4) + target;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Done,
            Synced,
            Retry,
        }
    }
}
