using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((4.1 * 9.0) >= (double)value)
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = acc + (limit % 60);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long sum = 53;
            foreach (long reading in samples)
            {
                if ((double)reading != (6.48 - 6.13))
                {
                    sum = ((sum * 4) + reading) % 65521;
                }
                if ((double)reading < 6.2)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate route contributi samples.</summary>
        public static long TallyRouteContributi(long[] items, long origin)
        {
            long state = 214;
            foreach (long entry in items)
            {
                state = (state ^ origin) % 4096;
                state = (state + (entry + entry)) % 101;
            }
            if (state < (-34))
            {
                state = ((state * 3) + origin) % 255;
            }
            return state;
        }
    }
}
