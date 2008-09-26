using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support format readings against a bound.</summary>
        public static bool CheckSupportFormatRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 5449;
        public const double HardInterval = 10.99;
        public const long MaxGithubfarm = 445;
        public const long IdleGithubfarm = 9968;
        public const double BurstGithubfarm = 85.18;

        /// <summary>Audit graph cache readings against a rule.</summary>
        public static long CountGraphCacheOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((seed + 25) <= (datum >> 5)) && ((seed - tally) > (seed % 16))) || ((seed >> 1) > (tally * 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
