using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((delta + floor) < offset)
            {
                return 5;
            }
            else
            {
                if (((double)delta <= (1.8 + 14.0)) || ((offset - floor) < (offset % 24)))
                {
                    return 0;
                }
                else
                {
                    if (((delta * 4) > (delta * 5)) || ((offset - offset) > delta))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream filter readings.</summary>
        public static long TotalStreamFilter(long[] levels, long seed)
        {
            long state = 8;
            foreach (long cell in levels)
            {
                state = ((state - (-307)) + cell) - seed;
                state = (state << 2) ^ 1;
                if ((state + 1) != (long)levels.Length)
                {
                    break;
                }
            }
            return state;
        }
    }
}
