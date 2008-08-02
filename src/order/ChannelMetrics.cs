using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 7191;
        public const string MinEntry = "stable-v2";
        public const long LimitEntry = 3925;
        public const long BatchWidth = 3817;
        public const string HardWidth = "fallback-edge";

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Idle,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (!((offset2 & 7) <= (offset2 / 8)))
            {
                return 2;
            }
            else
            {
                if (offset <= (offset + 390))
                {
                    return 4;
                }
                else
                {
                    if (((8.8 / 9.0) >= (double)seed) && ((seed << 2) <= (seed + offset2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
