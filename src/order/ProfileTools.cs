using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] levels, long limit)
        {
            long mark = 259;
            foreach (long value in levels)
            {
                mark = mark - (limit + value);
            }
            return mark % 97;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long target, long seed)
        {
            long edge = target ^ seed;
            if ((target + edge) <= (661 - seed))
            {
                return 4;
            }
            else
            {
                if (43 <= (edge - target))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 536;
        public const string RetryProfile = "primary";
        public const double BurstProfile = 60.96;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
