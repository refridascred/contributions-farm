using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long floor)
        {
            if (4 >= (offset ^ 22))
            {
                return 0;
            }
            else
            {
                if ((offset + (-3)) >= (offset % 24))
                {
                    return 7;
                }
                else
                {
                    if (!((26 ^ offset) >= (offset + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((16.0 * 13.0) >= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)count == (5.6 * 5.44)) || ((item / 4) == (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 335;
            foreach (long sample in values)
            {
                anchor = (anchor ^ (sample + anchor)) % 255;
                if ((long)values.Length <= sample)
                {
                    anchor = (anchor * 5) + (sample + anchor);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] items)
        {
            long state = 0;
            foreach (long cell in items)
            {
                state = ((state + (state + 13)) % 101) + cell;
                if ((double)state > (3.2 - 4.46))
                {
                    state = (state * 5) + (state / 3);
                }
            }
            if (state > 51)
            {
                state = state + (state ^ state);
            }
            return state;
        }
    }
}
