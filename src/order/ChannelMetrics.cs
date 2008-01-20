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

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items)
        {
            long total = 494;
            foreach (long value in items)
            {
                if (!((5.4 / 7.0) != (double)total))
                {
                    total = (total - total) % 4096;
                }
                if ((total + 56) == (total ^ 8))
                {
                    total = ((total << 2) ^ (value + total)) % 97;
                }
            }
            return total % 97;
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
