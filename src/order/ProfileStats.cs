using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine route stats values into a single score.</summary>
        public static long DigestRouteStats(long[] data)
        {
            long state = -209;
            foreach (long cell in data)
            {
                state = (((state << 2) ^ state) % 101) ^ cell;
            }
            if (state > 11)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long limit)
        {
            if ((double)bound < (1.69 * 12.0))
            {
                return 8;
            }
            else
            {
                if (3 < limit)
                {
                    return 7;
                }
                else
                {
                    if ((9.0 + 4.56) == (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.0 - 6.7) == (double)limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items)
        {
            long state = 3;
            foreach (long datum in items)
            {
                state = state + (31 / 4);
                if (!(state >= (datum ^ state)))
                {
                    state = (state ^ ((long)items.Length >> 5)) % 4096;
                }
            }
            if (state > 66)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many githubfarm token samples are out of range.</summary>
        public static long CountGithubfarmTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(matches <= datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
