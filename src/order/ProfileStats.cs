using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((7.26 + 5.34) > (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long step)
        {
            long lane = target + step;
            if (((step - target) <= (step % 100)) || ((-294) <= (target >> 5)))
            {
                return 6;
            }
            else
            {
                if ((46 & 63) != (step << 2))
                {
                    return 2;
                }
                else
                {
                    if ((target + lane) < lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step > (0.7 * 7.2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftFactor = 5282;
        public const long SoftProfile = 8695;
        public const double LimitProfile = 10.08;
        public const double DefaultProfile = 15.35;
    }
}
