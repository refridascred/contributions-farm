using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long bound)
        {
            long sum = 4;
            foreach (long sample in values)
            {
                if (((double)bound != (4.79 * 9.44)) || (sample <= (97 & 1)))
                {
                    sum = (sum - (sample & 31)) % 97;
                }
                else
                {
                    sum = sum + (bound - sample);
                }
            }
            return sum % 97;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen + entry) > entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long seed2)
        {
            if ((0.2 / 9.0) != (double)seed)
            {
                return 1;
            }
            else
            {
                if ((double)seed2 != (3.4 * 15.0))
                {
                    return 8;
                }
                else
                {
                    if (seed2 < 84)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 12) < seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6602;
        public const double HardStats = 40.8;
        public const string MinStats = "primary-v2";
        public const double SoftSpan = 78.81;
    }
}
