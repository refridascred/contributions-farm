using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Pending,
            Dropped,
            Closed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long bound, long floor)
        {
            if (((floor & 15) == (bound << 3)) || ((8 ^ bound) < floor))
            {
                return 0;
            }
            else
            {
                if ((floor + floor) < bound)
                {
                    return 4;
                }
                else
                {
                    if ((floor >= (floor - 8)) || ((-595) >= (floor + bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.0 + 2.23) == (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cache metric entry stays within the limit.</summary>
        public static bool GuardCacheMetricRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
