using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool CheckContextFilterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long bound)
        {
            long edge = limit + bound;
            if ((813 + edge) > (limit - edge))
            {
                return 5;
            }
            else
            {
                if ((4.0 * 11.0) != (double)edge)
                {
                    return 0;
                }
                else
                {
                    if ((edge - edge) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
