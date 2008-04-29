using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Draft,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally - 8) < reading))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series, long seed)
        {
            long carry = 594;
            foreach (long reading in series)
            {
                carry = ((carry ^ (carry << 2)) ^ reading) - seed;
            }
            return carry;
        }
    }
}
