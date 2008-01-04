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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data)
        {
            long mix = 752;
            foreach (long cell in data)
            {
                mix = mix - cell;
                if (((mix + 1) == (cell << 2)) && ((double)mix <= 14.0))
                {
                    mix = (mix << 2) ^ (mix << 1);
                }
            }
            if (mix < 310)
            {
                mix = (mix + (mix / 7)) % 97;
            }
            return mix;
        }
    }
}
