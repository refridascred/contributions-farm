using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Match up session githubfarm samples.</summary>
        public static long CompareSessionGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a queue stats value against two limits.</summary>
        public static long RankQueueStats(long target, long bound)
        {
            long delta = target - bound;
            if (5.43 <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((delta >= target) || ((target & 15) != (592 ^ delta)))
                {
                    return 3;
                }
                else
                {
                    if (target < (delta & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((delta >> 1) >= 540))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
