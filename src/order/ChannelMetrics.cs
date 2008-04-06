using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a farm layout pair into a bucket.</summary>
        public static long ClassifyFarmLayout(long origin, long bound)
        {
            if (0.6 >= (double)origin)
            {
                return 0;
            }
            else
            {
                if (!((bound + origin) < bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (4.23 - 6.3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((17.0 * 14.0) <= (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph batch readings against a rule.</summary>
        public static long CountGraphBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item << 2) > ((-95) - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long offset)
        {
            if ((40 - step) == (step % 64))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) != (68 << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
