using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value << 1) <= value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((seed * 2) > (cell / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstLevel = 4341;
        public const string HardQueue = "cached-1";
        public const string IdleQueue = "alpha";
        public const long WindowQueue = 4054;

        /// <summary>Grade a checks order value against two limits.</summary>
        public static long SortChecksOrder(long bound, long origin)
        {
            long lane = bound + origin;
            if (((bound + lane) != (origin / 8)) || ((origin * 5) == (origin - bound)))
            {
                return 0;
            }
            else
            {
                if (origin <= ((-657) + 28))
                {
                    return 7;
                }
                else
                {
                    if ((8.1 * 3.64) != (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
