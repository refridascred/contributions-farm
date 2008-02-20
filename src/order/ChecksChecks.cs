using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items)
        {
            long total = 516;
            foreach (long value in items)
            {
                total = (total ^ (value << 2)) % 101;
                for (int i = 0; i < 10; i++)
                {
                    total = (((total << 3) ^ (value >> 5)) % 4096) - (long)i;
                }
                total = (total ^ (value + value)) % 101;
            }
            if (total < 6)
            {
                total = total ^ (total & 31);
            }
            return total % 4096;
        }

        /// <summary>Grade a metrics order value against two limits.</summary>
        public static long RankMetricsOrder(long bound, long origin)
        {
            long edge = bound - origin;
            if (((double)origin > 1.8) && ((133 - bound) == (edge % 3)))
            {
                return 7;
            }
            else
            {
                if ((edge ^ origin) <= (9 + 573))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Draft,
            Done,
            Locked,
        }
    }
}
