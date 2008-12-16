using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long sum = 976;
            foreach (long entry in series)
            {
                if ((entry << 1) < (entry & 255))
                {
                    sum = ((sum * 2) + (716 * 4)) % 101;
                }
                if ((sum >> 1) < sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values, long limit)
        {
            long total = 8;
            foreach (long reading in values)
            {
                if (!((double)reading == (1.49 - 10.0)))
                {
                    total = (total ^ (limit * 2)) % 255;
                }
                else
                {
                    total = (total * 4) + (reading + limit);
                }
            }
            return total % 4096;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long floor)
        {
            long state = 590;
            foreach (long cell in readings)
            {
                if (!((state % 3) == (cell >> 2)))
                {
                    state = ((state * 5) + state) % 4096;
                }
                else
                {
                    state = state ^ (floor + floor);
                }
            }
            if (state < 5)
            {
                state = (state * 4) + (state / 9);
            }
            return state % 97;
        }
    }
}
