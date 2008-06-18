using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (double)origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry + carry) % 97) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Draft,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length >> 2) >= (value ^ 47))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
