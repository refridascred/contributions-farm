using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Synced,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7720;
        public const long BatchInterval = 2357;
        public const long BurstLayout = 3392;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long target, long seed)
        {
            long diff = target ^ seed;
            if ((8.98 * 6.4) >= (double)diff)
            {
                return 6;
            }
            else
            {
                if ((689 + diff) == (target ^ target))
                {
                    return 8;
                }
                else
                {
                    if (((diff & 3) < target) && ((seed / 9) >= seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
