using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values)
        {
            long state = 76;
            foreach (long value in values)
            {
                if (value > (508 * 3))
                {
                    state = (state - state) % 97;
                }
                else
                {
                    state = (state * 5) + (value ^ state);
                }
            }
            return state;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!!(((long)i << 3) <= ((long)i / 6)))
                {
                    mix = mix - (offset * 2);
                }
                mix = mix - (offset + offset);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] samples, long step)
        {
            long carry = 9;
            foreach (long cell in samples)
            {
                if ((step > (carry + (-888))) || (6.5 >= (double)step))
                {
                    carry = (carry + (carry % 8)) + cell;
                }
            }
            return carry;
        }
    }
}
