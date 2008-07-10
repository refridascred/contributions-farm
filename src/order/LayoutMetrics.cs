using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up checks context samples.</summary>
        public static long OverlapChecksContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long offset)
        {
            if (!((limit / 5) >= (limit % 8)))
            {
                return 6;
            }
            else
            {
                if (((double)offset <= (4.0 - 9.2)) || ((limit + offset) < (offset / 9)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next account notes value from a seed.</summary>
        public static long RollAccountNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (state + ((long)i % 24)) + (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
