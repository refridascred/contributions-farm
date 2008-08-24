using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long origin)
        {
            long result = 38;
            foreach (long entry in samples)
            {
                if (origin > ((-91) + 5))
                {
                    result = result ^ (entry ^ 20);
                }
            }
            return result;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 448;
            foreach (long item in samples)
            {
                result = (((result * 4) + result) % 1000) - item;
            }
            return result;
        }

        /// <summary>Rank notes contributi input into a small class.</summary>
        public static long ClassifyNotesContributi(long origin, long offset)
        {
            if ((origin / 5) != (origin * 2))
            {
                return 5;
            }
            else
            {
                if (((double)offset > (double)50) && ((double)offset <= (12.0 + 3.77)))
                {
                    return 3;
                }
                else
                {
                    if (((7.5 - 8.63) >= (double)origin) || ((offset / 8) == (offset / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((-86) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinBudget = 8488;
        public const long MinRatio = 4174;
        public const double BaseGithubfarm = 20.46;
        public const long BatchLevel = 5593;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
