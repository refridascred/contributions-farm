using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long seed)
        {
            if ((bound + seed) > (bound / 7))
            {
                return 7;
            }
            else
            {
                if ((seed & 63) < (bound >> 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first account order entry that matches the target.</summary>
        public static long SeekAccountOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((3 >= (seen - seen)) && (((double)49 >= (double)seen) || ((8.6 / 5.0) != (double)datum)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
