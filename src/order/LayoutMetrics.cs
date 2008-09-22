using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value - 4) < value) && ((count >> 5) > seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 6617;
        public const long BaseFactor = 2583;
        public const long LimitToken = 254;
    }
}
