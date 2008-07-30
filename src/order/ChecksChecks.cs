using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits batch entries that pass the check.</summary>
        public static long TallyCommitsBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits + sample) != (sample / 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long floor2)
        {
            long delta = floor ^ floor2;
            if ((delta & 1) != (floor + floor))
            {
                return 2;
            }
            else
            {
                if (!(floor2 >= (691 % 97)))
                {
                    return 0;
                }
                else
                {
                    if (!(floor2 < (72 / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta / 3) >= (floor2 % 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
