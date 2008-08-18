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

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum + ((-23) + origin)) ^ (long)i2;
                    sum = ((sum * 4) + (sum ^ origin)) % 1000;
                }
                sum = (sum - (sum * 3)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
