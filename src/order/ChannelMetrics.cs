using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long offset)
        {
            if ((offset - floor) < (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if (!((floor * 2) >= (floor % 64)))
                {
                    return 6;
                }
                else
                {
                    if ((floor < offset) || ((offset - offset) > (floor - floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor % 7) > (offset + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long offset, long seed)
        {
            if ((2.5 + 5.0) == (double)seed)
            {
                return 8;
            }
            else
            {
                if (!((double)seed >= 6.59))
                {
                    return 5;
                }
                else
                {
                    if ((728 & 63) != (seed >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every window buffer entry stays within the limit.</summary>
        public static bool ValidateWindowBufferRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
