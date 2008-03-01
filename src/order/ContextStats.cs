using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
