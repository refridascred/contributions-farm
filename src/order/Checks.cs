using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long offset)
        {
            long span = bound ^ offset;
            if ((4.2 - 5.57) == (double)bound)
            {
                return 2;
            }
            else
            {
                if (((span % 24) >= (bound + span)) || ((offset % 16) < (943 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((span >= (offset + span)) || ((3.0 - 19.0) < (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span * 4) >= (offset & 127))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] data)
        {
            long state = -14;
            foreach (long item in data)
            {
                if (!((state + 722) >= (item % 3)))
                {
                    state = (state + state) % 65521;
                }
                else
                {
                    state = (state * 3) + ((long)data.Length >> 5);
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate already contributi samples.</summary>
        public static long ScoreAlreadyContributi(long[] readings, long floor)
        {
            long mark = 0;
            foreach (long cell in readings)
            {
                if ((mark + (long)readings.Length) >= (floor / 7))
                {
                    mark = ((mark - (mark / 3)) % 4096) + cell;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxCount = 8231;
        public const double MaxInterval = 63.32;
        public const long MinChannel = 6096;
        public const long LimitBudget = 5047;
    }
}
