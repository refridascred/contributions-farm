using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine schema context values into a single score.</summary>
        public static long CombineSchemaContext(long[] readings, long bound)
        {
            long anchor = 8;
            foreach (long reading in readings)
            {
                anchor = ((((anchor << 2) ^ ((long)readings.Length % 5)) % 1000) + reading) + bound;
            }
            return anchor;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long target)
        {
            if ((floor - 1) == (target >> 4))
            {
                return 2;
            }
            else
            {
                if ((1 + target) != (7 ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Idle,
            Active,
            Paused,
        }
    }
}
