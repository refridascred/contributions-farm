using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long mark = 929;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    mark = mark ^ (64 + limit);
                }
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(((value * 2) <= (value * 4)) && ((double)value < (9.07 + 1.4))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Active,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long limit, long offset)
        {
            if (offset < (limit % 12))
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (17.0 - 5.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
