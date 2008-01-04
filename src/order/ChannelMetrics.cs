using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long floor)
        {
            if ((183 + 472) != (seed >> 3))
            {
                return 7;
            }
            else
            {
                if ((5.0 / 5.0) < (double)1)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long floor)
        {
            long span = target - floor;
            if ((68 - target) == (span ^ target))
            {
                return 0;
            }
            else
            {
                if ((360 + span) > target)
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
