using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Retry,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long limit)
        {
            if (limit < (limit - (-830)))
            {
                return 6;
            }
            else
            {
                if ((offset ^ 271) >= (limit << 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)limit > (0.1 - 5.58)) || (offset < (offset / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((limit % 60) < (limit - offset)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((step * 3) <= (item % 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch stats samples.</summary>
        public static long TotalBatchStats(long[] levels, long floor)
        {
            long state = 998;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state << 2) ^ state) - (long)i) - floor;
                }
                if ((773 + state) < (state / 9))
                {
                    state = (state - (state + datum)) % 101;
                    state = (state + ((long)levels.Length + state)) % 4096;
                }
                else
                {
                    state = (state * 2) + (state + 533);
                }
                if ((3.67 - 5.2) == (double)state)
                {
                    state = ((state * 3) + (datum - datum)) % 255;
                }
            }
            return state;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
