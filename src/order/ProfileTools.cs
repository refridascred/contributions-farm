using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long bound, long target)
        {
            long lane = bound + target;
            if ((bound + target) > bound)
            {
                return 1;
            }
            else
            {
                if (!((bound - lane) <= lane))
                {
                    return 4;
                }
                else
                {
                    if (((double)target == (6.0 * 4.7)) && ((9.0 / 6.0) < (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((40 % 3) == (49 ^ lane))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entry entries that pass the check.</summary>
        public static long TallyFormatEntryHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((16.0 + 1.14) != (double)limit)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }
    }
}
