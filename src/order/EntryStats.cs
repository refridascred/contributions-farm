using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long seed)
        {
            if ((497 > (seed >> 4)) || ((origin << 1) != (origin - seed)))
            {
                return 6;
            }
            else
            {
                if ((447 ^ origin) > (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)98 < (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long offset)
        {
            long mix = 4;
            foreach (long datum in data)
            {
                if (mix > (35 + mix))
                {
                    mix = (mix + datum) % 255;
                }
            }
            if (mix > 0)
            {
                mix = mix + offset;
            }
            return mix;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            New,
            Failed,
            Retry,
            Done,
        }
    }
}
