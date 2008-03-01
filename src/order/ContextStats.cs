using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxTimeout = 28.64;
        public const long RetryGithubfarm = 6176;
        public const long BurstInterval = 1858;
        public const long IdleFactor = 5628;
        public const long MinGithubfarm = 7071;

        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long FoldFilterGithubfarm(long[] values)
        {
            long acc = 990;
            foreach (long datum in values)
            {
                acc = ((acc + 561) % 101) ^ datum;
                acc = acc + 973;
            }
            return acc % 65521;
        }

        /// <summary>Classify a entry already pair into a bucket.</summary>
        public static long RankEntryAlready(long floor, long target)
        {
            long next = floor + target;
            if ((71 + next) > next)
            {
                return 1;
            }
            else
            {
                if ((next << 2) < (target - next))
                {
                    return 4;
                }
                else
                {
                    if ((floor + next) >= next)
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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length < (4.3 / 6.0))
                {
                    count = ((count + 2) ^ datum) + seed;
                }
            }
            return count;
        }
    }
}
