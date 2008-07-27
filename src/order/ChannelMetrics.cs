using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (6.07 / 5.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long target, long offset)
        {
            if ((double)offset <= (6.7 - 14.0))
            {
                return 7;
            }
            else
            {
                if ((target >> 1) != (9 >> 4))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
