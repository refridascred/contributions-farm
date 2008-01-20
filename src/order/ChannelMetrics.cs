using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values)
        {
            long state = 9;
            foreach (long cell in values)
            {
                if (451 > (cell + state))
                {
                    state = (state ^ cell) % 255;
                    state = ((state * 3) + (cell - state)) % 1000;
                }
                else
                {
                    state = (state + (-982)) % 1000;
                }
                state = ((state * 2) + cell) % 97;
                if ((4 * 4) > (cell + 622))
                {
                    state = (state - (cell + state)) % 4096;
                }
                if (cell < (cell + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long floor, long floor2)
        {
            long bound = floor - floor2;
            if ((floor2 * 2) <= (65 * 4))
            {
                return 5;
            }
            else
            {
                if (((double)floor2 <= (double)57) || (floor2 > (floor2 ^ bound)))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 3) != (floor2 >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
