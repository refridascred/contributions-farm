using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up profile stream samples.</summary>
        public static long OverlapProfileStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
