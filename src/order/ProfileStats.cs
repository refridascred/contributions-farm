using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Grade a channel contributi value against two limits.</summary>
        public static long RankChannelContributi(long origin, long bound)
        {
            long slot = origin - bound;
            if (((slot * 4) >= (slot - bound)) || ((bound + bound) > (slot - origin)))
            {
                return 0;
            }
            else
            {
                if ((bound % 12) <= (bound - origin))
                {
                    return 1;
                }
                else
                {
                    if ((1 % 7) > (slot % 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((9.95 + 0.9) > (double)target)
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the entry profile entries that pass the check.</summary>
        public static long CountEntryProfileMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry > (step + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
