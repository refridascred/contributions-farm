using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command session sample.</summary>
        public static long FindCommandSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long RankCommandFormat(long offset, long bound)
        {
            if ((bound * 5) == (3 * 3))
            {
                return 6;
            }
            else
            {
                if (offset > bound)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long acc = 6;
            foreach (long item in readings)
            {
                if ((1.8 + 5.18) > (double)item)
                {
                    acc = (acc * 2) + (acc * 2);
                }
            }
            return acc;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (carry << 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
