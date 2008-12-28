using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)offset == (double)37)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items)
        {
            long result = -1;
            foreach (long value in items)
            {
                if ((value + value) <= result)
                {
                    result = (result << 2) ^ (result / 5);
                }
                else
                {
                    result = ((result << 3) ^ (result + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long floor)
        {
            if ((floor % 2) < (725 + floor))
            {
                return 5;
            }
            else
            {
                if (!((floor % 3) <= floor))
                {
                    return 7;
                }
                else
                {
                    if (((bound + 21) <= (floor + floor)) || ((floor % 3) >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((75 + 2) >= bound) || ((floor >> 4) >= bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}
