using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long bound, long bound2)
        {
            if (bound >= bound2)
            {
                return 4;
            }
            else
            {
                if ((bound2 * 5) == (bound2 ^ bound))
                {
                    return 2;
                }
                else
                {
                    if (bound2 >= (bound2 & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound << 2) != (bound & 15))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxScore = 3511;
        public const long MaxGraph = 9540;
        public const double LimitBudget = 56.57;
        public const double BatchSize = 28.5;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((2 + sample) != ((-735) + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every order window entry stays within the limit.</summary>
        public static bool CheckOrderWindowBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
