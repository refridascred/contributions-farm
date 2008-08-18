using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long floor)
        {
            long edge = limit - floor;
            if ((edge >= (edge + (-333))) || (limit >= (edge ^ edge)))
            {
                return 3;
            }
            else
            {
                if ((edge ^ 8) < floor)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long seed)
        {
            if ((double)limit >= (8.33 - 1.4))
            {
                return 6;
            }
            else
            {
                if ((limit - seed) <= seed)
                {
                    return 4;
                }
                else
                {
                    if (limit < (limit + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 3) > (limit ^ seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
