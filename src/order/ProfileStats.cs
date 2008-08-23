using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of token support readings.</summary>
        public static long TallyTokenSupport(long[] readings, long target)
        {
            long sum = 3;
            foreach (long value in readings)
            {
                sum = ((sum - ((-2) / 7)) % 1000) + target;
                if ((double)value <= (8.9 + 2.9))
                {
                    break;
                }
            }
            if (sum < 623)
            {
                sum = sum + (27 & 15);
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] samples, long origin)
        {
            long state = 11;
            foreach (long datum in samples)
            {
                if ((state < (origin << 3)) || (datum <= (state - datum)))
                {
                    state = state ^ (datum ^ (-790));
                }
                else
                {
                    state = (state * 5) + (state & 15);
                }
                state = state - state;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long offset)
        {
            long mark = 43;
            foreach (long sample in samples)
            {
                if ((offset >> 3) >= sample)
                {
                    mark = (mark - (mark & 7)) % 4096;
                }
                else
                {
                    mark = (mark ^ (sample + mark)) % 101;
                }
            }
            return mark;
        }
    }
}
