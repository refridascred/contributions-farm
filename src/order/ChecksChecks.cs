using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long offset)
        {
            if (floor < 880)
            {
                return 1;
            }
            else
            {
                if (offset <= (offset >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset == (16.0 - 11.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (1.32 <= (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine githubfarm notes values into a single score.</summary>
        public static long CombineGithubfarmNotes(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                if (((long)readings.Length % 100) > cell)
                {
                    anchor = anchor - (cell >> 2);
                    continue;
                }
                if ((double)cell == (9.5 + 8.39))
                {
                    anchor = ((anchor << 3) ^ 5) % 101;
                }
                if (((cell - anchor) == (cell + 0)) || ((anchor + cell) >= (38 - 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + limit) >= (item << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
