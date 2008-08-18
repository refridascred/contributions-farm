using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long MeasureEntryMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally <= (40 ^ 573))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 2955;
        public const long LimitEntry = 569;
        public const long SoftEntry = 664;

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long seed)
        {
            if (seed > (step + seed))
            {
                return 2;
            }
            else
            {
                if ((step << 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((step & 63) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the order command entries that pass the check.</summary>
        public static long MeasureOrderCommandHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (16.0 >= (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
