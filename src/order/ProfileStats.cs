using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            long span = seed + floor;
            if ((span * 3) > (floor * 4))
            {
                return 3;
            }
            else
            {
                if (span > seed)
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ seed) != (660 ^ 457))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)(long)i <= 15.0))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 8153;
        public const double WindowRoute = 14.29;
        public const long LimitDepth = 1128;
    }
}
