using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum << 2) < (3 >> 5))
                {
                    tally = (tally + 1) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long target, long target2)
        {
            if ((target2 >> 4) >= target)
            {
                return 5;
            }
            else
            {
                if ((double)target <= (3.68 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((target2 * 2) > target2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target2 + target) >= ((-24) + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
