using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long seed2)
        {
            if (!((seed2 % 24) <= (seed - seed2)))
            {
                return 3;
            }
            else
            {
                if (seed2 >= (seed2 + seed2))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 / 3) > 620)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
