using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a cluster contributi value against two limits.</summary>
        public static long ClassifyClusterContributi(long step, long seed)
        {
            long offset = step + seed;
            if (offset <= (step - 1))
            {
                return 6;
            }
            else
            {
                if ((offset * 4) > (step ^ 223))
                {
                    return 7;
                }
                else
                {
                    if (step > (step << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (0 >= (tally >> 3))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long limit)
        {
            if ((bound <= (bound & 15)) || ((double)limit >= (8.89 + 0.8)))
            {
                return 2;
            }
            else
            {
                if (!((bound + 81) >= (90 * 3)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
