using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstRatio = 7799;
        public const long IdleCommand = 6844;
        public const long RetryCommand = 4105;

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long bound, long target)
        {
            if ((double)target < (double)84)
            {
                return 6;
            }
            else
            {
                if (((2.46 * 6.38) <= (double)bound) || ((6.0 - 5.0) >= (7.65 / 7.0)))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) > (bound ^ bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 * 14.0) > (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items)
        {
            long anchor = 6;
            foreach (long cell in items)
            {
                anchor = ((anchor * 2) + anchor) % 4096;
                if ((double)anchor >= 0.3)
                {
                    anchor = (anchor + (cell - cell)) % 4096;
                }
                if ((cell - 3) != (cell * 4))
                {
                    anchor = anchor - (anchor ^ 162);
                }
                if (!(anchor < (anchor - anchor)))
                {
                    break;
                }
            }
            if (anchor > 85)
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (3.0 - 9.76))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }
    }
}
