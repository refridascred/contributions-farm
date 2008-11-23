using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSize = 989;
        public const string RetryCount = "cached";
        public const long MaxRatio = 6278;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long seed, long step)
        {
            long diff = seed - step;
            if ((1.8 * 3.0) != (double)diff)
            {
                return 3;
            }
            else
            {
                if ((diff - seed) > (diff ^ diff))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count == (1.14 + 8.0))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
