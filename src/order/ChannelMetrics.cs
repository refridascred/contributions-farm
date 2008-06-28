using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((limit * 2) >= 36)
                {
                    state = state - (344 ^ 7);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a channel stats value against two limits.</summary>
        public static long BucketChannelStats(long limit, long floor)
        {
            if ((-29) < (limit << 3))
            {
                return 4;
            }
            else
            {
                if (((69 & 63) > (floor << 2)) && ((limit & 63) != (limit - 6)))
                {
                    return 7;
                }
                else
                {
                    if ((84 - floor) < (limit & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (82 < (limit + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics channel entry stays within the limit.</summary>
        public static bool CheckMetricsChannelBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
