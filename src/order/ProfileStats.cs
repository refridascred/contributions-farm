using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultScore = 5626;
        public const long BaseTimeout = 837;
        public const double BaseNotes = 6.3;
        public const long WindowNotes = 5528;

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] readings)
        {
            long mix = 90;
            foreach (long item in readings)
            {
                mix = (((mix * 3) + (45 + mix)) % 1000) - item;
            }
            return mix;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long bound)
        {
            if ((20.0 / 8.0) <= (double)step)
            {
                return 0;
            }
            else
            {
                if ((double)bound == (double)step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
