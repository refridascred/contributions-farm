using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step >= (long)i) && ((9.4 * 6.02) == (double)step))
                {
                    carry = (carry - (carry - step)) % 101;
                    carry = (carry + carry) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 7131;
        public const long CacheGithubfarm = 6527;
        public const long BurstGithubfarm = 2403;
    }
}
