using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate channel queue readings against a bound.</summary>
        public static bool GuardChannelQueueBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate context queue readings against a bound.</summary>
        public static bool GuardContextQueueBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank queue stream input into a small class.</summary>
        public static long GradeQueueStream(long limit, long limit2)
        {
            if (!(8.42 > (double)limit2))
            {
                return 7;
            }
            else
            {
                if (1.29 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
