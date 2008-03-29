using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the route record series from a seed.</summary>
        public static long SeriesRouteRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a format command value against two limits.</summary>
        public static long BucketFormatCommand(long floor, long seed)
        {
            if (((floor << 3) > (seed % 2)) && ((floor >> 4) >= ((-1) + seed)))
            {
                return 3;
            }
            else
            {
                if (!(floor < (seed + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 4) == (seed - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor / 8) >= (floor - floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel layout sample.</summary>
        public static long SeekChannelLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long target2)
        {
            if ((double)target2 < (1.43 / 9.0))
            {
                return 4;
            }
            else
            {
                if ((target2 & 3) > (target >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((target + target2) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
