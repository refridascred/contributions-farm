using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            long edge = floor ^ offset;
            if (17.0 >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((floor & 63) >= ((-4) + edge))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every layout buffer entry stays within the limit.</summary>
        public static bool VerifyLayoutBufferRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
