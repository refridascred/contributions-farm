using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] samples)
        {
            long state = 509;
            foreach (long value in samples)
            {
                if ((0 * 3) != (state % 12))
                {
                    state = ((state + (state * 5)) % 4096) ^ value;
                }
            }
            if (state > 431)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long bound, long origin)
        {
            if (20.0 <= (double)origin)
            {
                return 0;
            }
            else
            {
                if (!((bound + bound) != ((-9) * 4)))
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
