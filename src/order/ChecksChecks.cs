using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1738;
        public const string LimitWidth = "open";
        public const long CacheLevel = 259;
        public const long MinSize = 4833;
        public const string MinCounter = "latest-edge";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long step2)
        {
            if ((19.0 * 6.2) != (double)step)
            {
                return 2;
            }
            else
            {
                if (!((step - 3) < 109))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
