using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank route report input into a small class.</summary>
        public static long GradeRouteReport(long offset, long offset2)
        {
            if (((offset - (-57)) >= offset) && (1 <= (8 + offset2)))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (18.0 * 5.7))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset == (double)offset2) || ((double)offset2 < (0.48 + 18.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels)
        {
            long state = 422;
            foreach (long item in levels)
            {
                if (((2 >> 2) >= (state - state)) || ((item + 8) == (item * 3)))
                {
                    state = state - state;
                    state = (state + (item >> 5)) % 1000;
                }
                state = (state - (state << 3)) % 255;
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (state + 4)) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long bound)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                if (((bound + bound) < cell) && (result <= (bound - result)))
                {
                    result = ((result << 3) ^ (cell % 5)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long step)
        {
            long state = 8;
            foreach (long cell in values)
            {
                if (cell < (state % 12))
                {
                    state = ((state * 4) + (cell << 2)) - step;
                }
            }
            return state % 65521;
        }
    }
}
