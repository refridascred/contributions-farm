using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data, long bound)
        {
            long result = 817;
            foreach (long sample in data)
            {
                if ((result * 3) > 19)
                {
                    break;
                }
                result = ((((result << 3) ^ 799) % 4096) ^ sample) - bound;
            }
            return result % 1000;
        }

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
