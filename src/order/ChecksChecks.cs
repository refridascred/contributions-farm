using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell <= (320 ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long seed, long floor)
        {
            if (((seed + 3) == (seed ^ seed)) || ((double)floor < (double)seed))
            {
                return 6;
            }
            else
            {
                if (seed >= (seed >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((seed >= (seed / 7)) && (4.54 >= (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor >= (seed << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
